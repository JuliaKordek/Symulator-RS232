using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class RS232 : Form
    {
        public RS232()
        {
            InitializeComponent();
        }

        public string[] forbiddenWords;
        private void NadajnikBinaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NadajnikKonwertuj_Click(object sender, EventArgs e)
        {
            NadajnikOutput.Text = ConvertToBinary(NadajnikInput.Text);
        }
        private string ConvertToBinary(string text)
        {
            StringBuilder binaryBuilder = new StringBuilder(); 
            foreach (char c in text)
            {
                
                binaryBuilder.Append("0");

                
                string binaryChar = Convert.ToString(c, 2).PadLeft(8, '0');
                for (int i = binaryChar.Length - 1; i >= 0; i--)
                {
                    binaryBuilder.Append(binaryChar[i]);
                }

                
                binaryBuilder.Append("11");
            }
            return binaryBuilder.ToString();
        }
        private string ConverToAscii(string binaryText)
        {
            StringBuilder asciiBuilder = new StringBuilder();
            int i = 0;

            while ((i + 11) <= binaryText.Length)
            {
                string byteString = binaryText.Substring(i + 1, 8); 
                byteString = ReverseString(byteString); 

                int asciiCode = Convert.ToInt32(byteString, 2);
                asciiBuilder.Append(Convert.ToChar(asciiCode));

                i += 11; 
            }

            return asciiBuilder.ToString();
        }
        private static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void Wyślij_Click(object sender, EventArgs e)
        {
            OdbiornikInput.Text = NadajnikOutput.Text;
        }

        private void OdbiornikKonwertuj_Click(object sender, EventArgs e)
        {
            string convertedText = ConverToAscii(OdbiornikInput.Text);
            if (CenzuraCheckBox.Checked && forbiddenWords != null)
            {
                convertedText = censor(convertedText, forbiddenWords);
            }
            OdbiornikOutput.Text = convertedText;
        }

        private void CenzuraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CenzuraCheckBox.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader f1 = new StreamReader(openFileDialog1.FileName); 
                    int liczbaLinii = countLiczbaLinii(f1); 
                    f1.Close();

                    StreamReader f2 = new StreamReader(openFileDialog1.FileName);
                    forbiddenWords = plikDoTablicy(f2, liczbaLinii);
                    f2.Close();
                }
            }
        }
        private int countLiczbaLinii(StreamReader f)
        {
            int liczbaLinii = 0;
            while ((f.ReadLine()) != null)
            {
                liczbaLinii++;
            }
            return liczbaLinii;
        }

        private string[] plikDoTablicy(StreamReader f, int liczbaLinii)
        {
            string linia = "";
            int i = 0;
            string[] tablica = new string[liczbaLinii];

            while ((linia = f.ReadLine()) != null)
            {
                tablica[i] = linia;
                i++;
            }
            return tablica;
        }

        public string censor(string tekstS, string[] czarnaListaSlow)
        {
            StringBuilder tekst = new StringBuilder(tekstS);
            string star = "";

            for (int i = 0; i < czarnaListaSlow.Length; i++)
            {
                for (int j = 0; j < czarnaListaSlow[i].Length; j++)
                {
                    star += "*";
                }

                tekst.Replace(czarnaListaSlow[i], star);
                tekst.Replace(czarnaListaSlow[i].ToLower(), star);
                tekst.Replace(czarnaListaSlow[i].ToUpper(), star);
                star = "";
            }
            return tekst.ToString();
        }
    }
}

