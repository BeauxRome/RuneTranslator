using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace RuneTranslator
{
    public partial class Form1 : Form
    {
        System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(string));

        FormFunc formFunc;

        public Form1()
        {
            InitializeComponent();
            formFunc = new FormFunc();
        }
        
        


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                List<Boxes> fullImageValue = new List<Boxes>(39);
                int i = 1;
                foreach (Boxes Box in fullImageValue)
                {
                    Box.value = i;
                    i++;
                }

                List<PictureBox> pictureBoxes = new List<PictureBox>{pictureBox1, pictureBox2,
                    pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                    pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
                    pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18,
                    pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23,
                    pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28,
                    pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33,
                    pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38,
                    pictureBox39 };
                int j = 1;
                foreach (PictureBox picBox in pictureBoxes)
                {
                    foreach (Boxes box in fullImageValue)
                    {
                        if (box.value == j)
                        {
                            box.pictureBox = picBox;
                        }
                    }
                }

                textBox2.Text = textBox1.Text;

                var runeSwitch = textBox1.Text.ToString();
                int k = 1;
                foreach (char symbol in runeSwitch)
                {
                    foreach (Boxes box in fullImageValue)
                    {
                        if (box.value <= 39 && box.value == k)
                        {
                            box.symbol = symbol;
                        }
                    }
                }
                
                formFunc.CharTranslation(serializer, textBox2, textBox1, fullImageValue);

                //int l = 1;
                //foreach (Boxes box in fullImageValue)
                //{
                //    foreach (PictureBox picBox in pictureBoxes)
                //    {
                //        if (box.value == l)
                //        {
                //            picBox = box.pictureBox;
                //        }
                //    }
                //}
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            formFunc.Save(textBox1, serializer);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            formFunc.Load(textBox1, serializer);
        }
    }
}



/// TODO:
/// 
/// Change all rune bindings to loop
/// Fix symbols from blank to an error message
/// Create a class for string to become the runes
/// Create a class for program actions
///
