using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuneTranslator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //was added. Is broken.
            bool completeText = false;

            void input_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
            {
                if (e.KeyData == System.Windows.Forms.Keys.Enter)
                {
                    string textInput = Form1.textBox1.Text;
                    completeText = true;
                }
            }

            if (completeText == false)
            {
                input_KeyDown(Form1.textBox1,
                    new System.Windows.Forms.KeyEventArgs(System.Windows.Forms.Keys.Enter));
            }
            else
            {
                System.Windows.Forms.Application.Run(new Form2());
                Form1.ShowInTaskbar = false;
                Form1.Opacity = 0.01;
            }
            //end of broken.
        }
    }
}
