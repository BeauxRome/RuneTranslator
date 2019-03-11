using System.Windows.Forms;

namespace RuneTranslator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {            
                textBox2.Text = textBox1.Text;
            }
        }

        
    }
}
