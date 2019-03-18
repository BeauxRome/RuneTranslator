﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing;

namespace RuneTranslator
{

    public class FormFunc
    {
        public void Save(TextBox textBox1, XmlSerializer serializer)
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

        public void Load (TextBox textBox1, XmlSerializer serializer)
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

        //////////////////////////////////////////////

        private Image Translator(char symbol)
        {
            if (symbol == 'a' || symbol == 'A')
            {
                return Image.FromFile(@"..\..\Resources\LetterA.png");
            }
            else if (symbol == 'b' || symbol == 'B')
            {
                return Image.FromFile(@"..\..\Resources\LetterB.png");
            }
            else if (symbol == 'c' || symbol == 'C')
            {
                return Image.FromFile(@"..\..\Resources\LetterC.png");
            }
            else if (symbol == 'd' || symbol == 'D')
            {
                return Image.FromFile(@"..\..\Resources\LetterD.png");
            }
            else if (symbol == 'e' || symbol == 'E')
            {
                return Image.FromFile(@"..\..\Resources\LetterE.png");
            }
            else if (symbol == 'f' || symbol == 'F')
            {
                return Image.FromFile(@"..\..\Resources\LetterF.png");
            }
            else if (symbol == 'g' || symbol == 'G')
            {
                return Image.FromFile(@"..\..\Resources\LetterG.png");
            }
            else if (symbol == 'h' || symbol == 'H')
            {
                return Image.FromFile(@"..\..\Resources\LetterH.png");
            }
            else if (symbol == 'i' || symbol == 'I')
            {
                return Image.FromFile(@"..\..\Resources\LetterI.png");
            }
            else if (symbol == 'j' || symbol == 'J')
            {
                return Image.FromFile(@"..\..\Resources\LetterJ.png");
            }
            else if (symbol == 'k' || symbol == 'K')
            {
                return Image.FromFile(@"..\..\Resources\LetterK.png");
            }
            else if (symbol == 'l' || symbol == 'L')
            {
                return Image.FromFile(@"..\..\Resources\LetterL.png");
            }
            else if (symbol == 'm' || symbol == 'M')
            {
                return Image.FromFile(@"..\..\Resources\LetterM.png");
            }
            else if (symbol == 'n' || symbol == 'N')
            {
                return Image.FromFile(@"..\..\Resources\LetterN.png");
            }
            else if (symbol == 'o' || symbol == 'O')
            {
                return Image.FromFile(@"..\..\Resources\LetterO.png");
            }
            else if (symbol == 'p' || symbol == 'P')
            {
                return Image.FromFile(@"..\..\Resources\LetterP.png");
            }
            else if (symbol == 'q' || symbol == 'Q')
            {
                return Image.FromFile(@"..\..\Resources\LetterQ.png");
            }
            else if (symbol == 'r' || symbol == 'R')
            {
                return Image.FromFile(@"..\..\Resources\LetterR.png");
            }
            else if (symbol == 's' || symbol == 'S')
            {
                return Image.FromFile(@"..\..\Resources\LetterS.png");
            }
            else if (symbol == 't' || symbol == 'T')
            {
                return Image.FromFile(@"..\..\Resources\LetterT.png");
            }
            else if (symbol == 'u' || symbol == 'U')
            {
                return Image.FromFile(@"..\..\Resources\LetterU.png");
            }
            else if (symbol == 'v' || symbol == 'V')
            {
                return Image.FromFile(@"..\..\Resources\LetterV.png");
            }
            else if (symbol == 'w' || symbol == 'W')
            {
                return Image.FromFile(@"..\..\Resources\LetterW.png");
            }
            else if (symbol == 'x' || symbol == 'X')
            {
                return Image.FromFile(@"..\..\Resources\LetterX.png");
            }
            else if (symbol == 'y' || symbol == 'Y')
            {
                return Image.FromFile(@"..\..\Resources\LetterY.png");
            }
            else if (symbol == 'z' || symbol == 'Z')
            {
                return Image.FromFile(@"..\..\Resources\LetterZ.png");
            }


            else if (symbol == '0')
            {
                return Image.FromFile(@"..\..\Resources\Number0.png");
            }
            else if (symbol == '1')
            {
                return Image.FromFile(@"..\..\Resources\Number1.png");
            }
            else if (symbol == '2')
            {
                return Image.FromFile(@"..\..\Resources\Number2.png");
            }
            else if (symbol == '3')
            {
                return Image.FromFile(@"..\..\Resources\Number3.png");
            }
            else if (symbol == '4')
            {
                return Image.FromFile(@"..\..\Resources\Number4.png");
            }
            else if (symbol == '5')
            {
                return Image.FromFile(@"..\..\Resources\Number5.png");
            }
            else if (symbol == '6')
            {
                return Image.FromFile(@"..\..\Resources\Number6.png");
            }
            else if (symbol == '7')
            {
                return Image.FromFile(@"..\..\Resources\Number7.png");
            }
            else if (symbol == '8')
            {
                return Image.FromFile(@"..\..\Resources\Number8.png");
            }
            else if (symbol == '9')
            {
                return Image.FromFile(@"..\..\Resources\Number9.png");
            }


            else if (symbol == ' ')
            {
                return Image.FromFile(@"..\..\Resources\SymbolSpace.png");
            }
            else if (symbol == '.')
            {
                return Image.FromFile(@"..\..\Resources\SymbolPeriod.png");
            }
            else if (symbol == '?')
            {
                return Image.FromFile(@"..\..\Resources\SymbolQuestion.png");
            }
            else if (symbol == '!')
            {
                return Image.FromFile(@"..\..\Resources\SymbolExclaim.png");
            }


            else
            {
                return Image.FromFile(@"..\..\Resources\SymbolUnknown.png");
            }

        }
        /// //////////////////////////////////////////////////////////////
        
        public void CharTranslation(XmlSerializer serializer, TextBox textBox2, TextBox textBox1,
            List<Boxes> boxes)
        {

            foreach (Boxes box in boxes)
            {
                
                box.pictureBox.Image = Translator(box.symbol);
                
            }
        }
    }
}
