using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CANPro.SDK;

namespace test0515
{
    public delegate void MessageNofified(object sender, CanbusPacket packet);
    public delegate void MessageNofified2(object sender, int channel, CanbusPacket packet);
    public delegate void MessageNofify(object sender, int channel);

    public abstract class CanBusDriver
    {
        public string connectionString { get; set; }

        public event MessageNofified MessageReceived;
        public event MessageNofified2 MessageReceived2;
        public event MessageNofify MessageNotify;
        public abstract bool OpenDevice(byte b, byte z, byte x, byte y);
        public abstract void CloseDevice();
        public abstract void ReadFrame(out object[] objects);
        public abstract void WriteFrame(object[] objects);
        public abstract void InitConfig();
        protected bool _connected;

        public CanBusDriver()
        {
            connectionString = string.Empty;
        }
        public CanBusDriver(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public virtual void OnMessageRecevied(object sender, CanbusPacket packet)
        {
            MessageReceived?.Invoke(sender, packet);
        }
        public virtual void OnMessageRecevied2(object sender, int channel, CanbusPacket packet)
        {
            MessageReceived2?.Invoke(sender, channel, packet);
        }
        public virtual void OnMessageNofity(object sender, int channel)
        {
            MessageNotify?.Invoke(sender, channel);
        }
        public virtual bool Connected()
        {
            return _connected;
        }
    }
    internal class CanProDriver : CanBusDriver
    {
        public List<CanbusPacket> PacketRcvd = new List<CanbusPacket>();
        public CanData CanDataInstance { get; set; }
        private uint _dev_index { get; set; }
        private uint _dev_type { get; set; }
        private bool _open { get; set; }
        private VCI_BOARD_INFO boardInfo = new VCI_BOARD_INFO();
        System.Timers.Timer _timerpoll = null;



        public CanProDriver() : base()
        {

            CanDataInstance = new CanData();
            PacketRcvd = new List<CanbusPacket>();
            _dev_index = 0;
            _dev_type = CANPRO.DEV_USBCAN2;
            _open = false;
            _timerpoll = new System.Timers.Timer();
            _timerpoll.Elapsed += _timerpoll_Elapsed;
            _timerpoll.Interval = 10;
        }
        public CanProDriver(uint devType, uint devindex)
        {
            CanDataInstance = new CanData();
            _dev_type = devType;
            _dev_index = devindex;
            _open = false;
            _timerpoll = new System.Timers.Timer();
            _timerpoll.Elapsed += _timerpoll_Elapsed;
            _timerpoll.Interval = 10;

        }
        public override void OnMessageNofity(object sender, int channel)
        {
            base.OnMessageNofity(sender, channel);
            
        }
        unsafe void _timerpoll_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            uint nofMsg = 0;
            bool newMsg = false;
            VCI_CAN_OBJ[] recvObject = new VCI_CAN_OBJ[2500];
            for (uint canid = 0; canid < 2; canid++)
            {
                newMsg = true;
                nofMsg = CANPRO.VCI_Receive(_dev_type, _dev_index, canid, ref recvObject[0], 1000, 100);
                for (int i = 0; i < nofMsg; i++)
                {
                    CanbusPacket pp = new CanbusPacket();
                    pp.RTR = recvObject[i].RemoteFlag;
                    pp.DLC = recvObject[i].DataLen;
                    pp.extID = recvObject[i].ID;
                    pp.portID = (byte)canid;
                    for (int j = 0; j < pp.DLC; j++)
                    {
                        pp.Data[j] = recvObject[i].Data[j];
                    }
                    PacketRcvd.Add(pp);
                    OnMessageNofity(pp, 0);
                    CanDataInstance.Id = (int)pp.extID & 0x1FFFFF80;
                    CanDataInstance.Data = pp.Data;
                    CanDataInstance.portId = pp.portID;
                }
            }
        }
        public uint returncandevice()
        {
            return CANPRO.VCI_FindUsbDevice(ref boardInfo);
        }
        public override void InitConfig()
        {
        }
        public override bool OpenDevice(byte b0Tim0, byte b0Tim1, byte b1Tim0, byte b1Tim1)
        {
            bool success = false;
            if (CANPRO.VCI_OpenDevice(_dev_type, _dev_index, 0) != 1)
            {
                return false;
            }
            _open = true;
            success = true;
            VCI_INIT_CONFIG config = new VCI_INIT_CONFIG();
            config.AccCode = 0x00000000;
            config.AccMask = 0xffffffff;
            config.Timing1 = b0Tim1;
            config.Timing0 = b0Tim0;
            config.Filter = 0;
            config.Mode = 0;
            if (CANPRO.VCI_InitCAN(_dev_type, _dev_index, 0, ref config) == 1)
            {
                CANPRO.VCI_StartCAN(_dev_type, _dev_index, 0);
            }
            config.Timing0 = b1Tim0;
            config.Timing1 = b1Tim1;
            if (CANPRO.VCI_InitCAN(_dev_type, _dev_index, 1, ref config) == 1)
            {
                CANPRO.VCI_StartCAN(_dev_type, _dev_index, 1);
            }
            _timerpoll.Start();
            _connected = success;
            return success;
        }
        public override void CloseDevice()
        {
            if (_open)
            {
                CANPRO.VCI_CloseDevice(_dev_type, _dev_index);
                _open = false;
                _timerpoll.Stop();
                _connected = false;
            }
        }
        public override void ReadFrame(out object[] objects)
        {
            try
            {
                lock (PacketRcvd)
                {
                    objects = PacketRcvd.ToArray();
                    PacketRcvd.Clear();
                }

                foreach (CanbusPacket packet in objects.OfType<CanbusPacket>())
                {
                    var canData = new CanData
                    {
                        Id = (int)packet.extID,
                        Data = packet.Data
                    };

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in ReadFrame: " + e.Message);
                objects = new object[0];
            }
        }

        unsafe public override void WriteFrame(object[] objects)
        {
            CanbusPacket packet = (CanbusPacket)(objects[0]);

            VCI_CAN_OBJ sendobj = new VCI_CAN_OBJ();

            sendobj.RemoteFlag = packet.RTR;
            sendobj.ExternFlag = packet.mode;
            //            sendobj.ExternFlag = 0;
            sendobj.ID = packet.extID;
            sendobj.DataLen = (byte)packet.DLC;
            for (int i = 0; i < packet.Data.Length; i++)
            {
                sendobj.Data[i] = packet.Data[i];
            }

            CANPRO.VCI_Transmit(_dev_type, _dev_index, packet.portID, ref sendobj, 1);
        }
    }

    public class CanbusPacket
    {
        public int DeviceID;
        public byte portID;
        public uint extID;
        public byte mode;
        public byte RTR;
        public byte DLC;
        public byte[] Data = new byte[8];
        public CanbusPacket() { }
    }
}
