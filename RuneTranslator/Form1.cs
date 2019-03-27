using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace RuneTranslator
{
    public partial class Form1 : Form
    {
        System.Xml.Serialization.XmlSerializer xmlserializer =
            new System.Xml.Serialization.
                XmlSerializer(typeof(string));

        JsonSerializer jsonserializer = new JsonSerializer();

        /// <summary>
        /// This holds most of the Load and save stuff, along with the 
        /// translation into runes.
        /// </summary>
        FormFunc formFunc;

        /// <summary>
        /// This is the basic instruction and error message given out.
        /// </summary>
        string textbox1ToolTipText = "Type text in, then press Enter "+
            "to have it translated into a selection of runes. Only " +
            "letters, numbers, and the ?, !, ., and _ allowed. Only " +
            "39 characters can be translated at a time.";

        string errorText = "Only letters, numbers, and the ?, !, ., " +
            "and _ allowed. Remove any untranslatable characters, " +
            "and try again.";


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

            formFunc = new FormFunc();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            toolTip1.SetToolTip(textBox1, textbox1ToolTipText);
            textBox1.Select();
            
        }

        void MakeBoxObjects(string Text)
        {
            var runeTrans = new List<Box>();

            foreach (char letter in Text)
            {
                runeTrans.Add(new Box()
                {
                    picBox = new PictureBox
                    {
                        Image = formFunc.Translator(letter),
                    },
                    symbol = letter
                });
            }

            ///This resets the prior display
            foreach (var reset in flowLayoutPanel1.Controls)
            {
                var pb = reset as PictureBox;
                pb.Image = Image.FromFile(System.Environment.
                    CurrentDirectory +
                        @"\Resources\SymbolUnknown.png");

            }

            /// This places the new display in the picture boxes
            for (int i = 0; i < flowLayoutPanel1.Controls.Count &&
                i < Text.Length; i++)
            {
                var pb = flowLayoutPanel1.Controls[i] as PictureBox;
                pb.Image = runeTrans[i].picBox.Image;

            }
            /// This places in the new confirmed text.
            textBox2.Text = Text;
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                foreach (int symbol in textBox1.Text)
                {
                    if (symbol == 33 || symbol == 46 || symbol >= 48 &&
                            symbol <= 57 || symbol == 63 ||
                                symbol >= 65 && symbol <= 90 ||
                                    symbol == 95 || symbol >= 97 &&
                                        symbol <= 122)
                    {
                        // this is to account for error messages
                        toolTip1.Hide(textBox1);

                        continue;
                    }
                    /// This causes the box to turn red and the 
                    /// reminder to activate if there are any 
                    /// incorrect symbols
                    else
                    {
                        textBox1.BackColor = Color.OrangeRed;
                        toolTip1.Show(errorText, panel1, new 
                            Point(25, 25));
                        textBox1.Select();
                        return;
                    }
                }
                textBox1.BackColor = Color.White;
                MakeBoxObjects(textBox1.Text);
                textBox1.Select();

            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            formFunc.LoadXml(textBox1, xmlserializer);
            textBox1.Select();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            formFunc.SaveXml(textBox1, xmlserializer);
            textBox1.Select();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            formFunc.LoadJson(textBox1, jsonserializer);
            textBox1.Select();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            formFunc.SaveJson(textBox1, jsonserializer);
            textBox1.Select();
        }


        ///When they hover over the textbox, a message explains 
        ///allowed text parameters
        private void panel1_MouseHover(object sender, 
            System.EventArgs e)
        {
            toolTip1.Show(textbox1ToolTipText, panel1);
        }

        
    }
}



/// TODO:
/// 
/// Change all rune bindings to loop
/// Fix symbols from blank to an error message
/// Create a class for string to become the runes
/// Create a class for program actions
/// Add a sort of alert made from a message box 
/// (MessageBox.Show("text"))
