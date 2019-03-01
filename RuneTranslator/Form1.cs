using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuneTranslator
{
    public partial class Form1 : Form
    {
        string textInput;


        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                textInput = textBox1.Text;
                
                System.Windows.Forms.Application.Run(new Form2());
                ShowInTaskbar = false;
                Opacity = 0.01;
            }
        }
    }
}
