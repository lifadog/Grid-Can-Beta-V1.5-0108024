using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace test0515
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExecuteCode(richTextBox1.Text);
        }

        private void ExecuteCode(string code)
        {
            // 设置编译器参数
            var compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false,
                TreatWarningsAsErrors = false
            };

            // 添加引用
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");

            // 定义需要编译的代码
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Windows.Forms;");
            sb.AppendLine("namespace DynamicCodeExecution {");
            sb.AppendLine("    public class Program {");
            sb.AppendLine("        public void Execute() {");
            sb.AppendLine(code);
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            // 使用CSharpCodeProvider编译代码
            var provider = new CSharpCodeProvider();
            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, sb.ToString());

            // 检查编译错误
            if (results.Errors.HasErrors)
            {
                var errors = new StringBuilder("编译错误:\n");
                foreach (CompilerError error in results.Errors)
                {
                    errors.AppendLine($"行 {error.Line}: {error.ErrorText}");
                }
                MessageBox.Show(errors.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 执行编译后的代码
            Assembly assembly = results.CompiledAssembly;
            object programInstance = assembly.CreateInstance("DynamicCodeExecution.Program");
            MethodInfo method = programInstance.GetType().GetMethod("Execute");
            method.Invoke(programInstance, null);
        }
    }
}

