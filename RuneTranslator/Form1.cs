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

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private Image Translator (char symbol)
        {
            if (symbol == 'a' || symbol == 'A')
            {
                return Image.FromFile("LetterA.png");
            }
            else if (symbol == 'b' || symbol == 'B')
            {
                return Image.FromFile("LetterB.png");
            }
            else if (symbol == 'c' || symbol == 'C')
            {
                return Image.FromFile("LetterC.png");
            }
            else if (symbol == 'd' || symbol == 'D')
            {
                return Image.FromFile("LetterD.png");
            }
            else if (symbol == 'e' || symbol == 'E')
            {
                return Image.FromFile("LetterE.png");
            }
            else if (symbol == 'f' || symbol == 'F')
            {
                return Image.FromFile("LetterF.png");
            }
            else if (symbol == 'g' || symbol == 'G')
            {
                return Image.FromFile("LetterG.png");
            }
            else if (symbol == 'h' || symbol == 'H')
            {
                return Image.FromFile("LetterH.png");
            }
            else if (symbol == 'i' || symbol == 'I')
            {
                return Image.FromFile("LetterI.png");
            }
            else if (symbol == 'j' || symbol == 'J')
            {
                return Image.FromFile("LetterJ.png");
            }
            else if (symbol == 'k' || symbol == 'K')
            {
                return Image.FromFile("LetterK.png");
            }
            else if (symbol == 'l' || symbol == 'L')
            {
                return Image.FromFile("LetterL.png");
            }
            else if (symbol == 'm' || symbol == 'M')
            {
                return Image.FromFile("LetterM.png");
            }
            else if (symbol == 'n' || symbol == 'N')
            {
                return Image.FromFile("LetterN.png");
            }



            else
            {
                return Image.FromFile("LetterB.png");
            }
            
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {            
                textBox2.Text = textBox1.Text;

                int i = 0;

                var runeSwitch = textBox1.Text.ToString();

                foreach (char rune in runeSwitch)
                {
                    if (i == 0)
                    {
                        //the idea is to turn each letter in the list to a symbol, then place 
                            //it in a slot that is the number +1, then increase i by 1 to 
                                //show the process finished.
                    }
                    if (i == 1)
                    {
                        ;
                    }
                    if (i == 2)
                    {
                        ;
                    }
                    if (i == 3)
                    {
                        ;
                    }
                    if (i == 4)
                    {
                        ;
                    }
                    if (i == 5)
                    {
                        ;
                    }
                    if (i == 6)
                    {
                        ;
                    }
                    if (i == 7)
                    {
                        ;
                    }
                    if (i == 8)
                    {
                        ;
                    }
                    if (i == 9)
                    {
                        ;
                    }
                    if (i == 10)
                    {
                        ;
                    }
                }
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (!(System.IO.File.Exists("RuneMessage.xml")))
            {
                var newFile = System.IO.File.Create("RuneMessage.xml");

                string saveData = textBox1.Text;

                newFile.Close();
            }
            else
            {
                var writer = new System.IO.StreamWriter("RuneMessage.xml");

                serializer.Serialize(writer, textBox1.Text);

                writer.Close();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                var reader = new System.IO.StreamReader("RuneMessage.xml");

                textBox1.Text = serializer.Deserialize(reader) as string;

                reader.Close();
            }
            catch
            {
                ;
            }
        }
    }
}
