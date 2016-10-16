using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //fontDialog1.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fontType in FontFamily.Families)
            {
                FontFamilyCB.Items.Add(fontType.Name.ToString());
            }

            for (int i = 8; i <= 73; i += 2)
            {
                FontSizeCB.Items.Add(i);
            }
            FontSizeCB.SelectedIndex = 2;
            FontFamilyCB.Text = "Times New Roman";
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            Font New,Choosed;
            Choosed = richTextBox1.SelectionFont;
            /*
            if (Choosed.Bold)
            {
               New = new Font(Choosed, Choosed.Style & ~FontStyle.Bold);
               BoldBtn.Checked = false;
            }
            else
            {
               New = new Font(Choosed, Choosed.Style | FontStyle.Bold);
               BoldBtn.Checked = true;
            }
            */
            if (Choosed.Bold == false)
            {
                if (Choosed.Italic == true && Choosed.Underline == false)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Italic);
                }
                else if (Choosed.Italic == false && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Underline);
                }
                else if (Choosed.Italic == true && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    New = new Font(Choosed, FontStyle.Bold);
                }
            }
            else
            {
                if (Choosed.Italic == true && Choosed.Underline == false)
                {
                    New = new Font(Choosed, FontStyle.Italic);
                }
                else if (Choosed.Italic == false && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Underline);
                }
                else if (Choosed.Italic == true && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    New = new Font(Choosed, FontStyle.Regular);
                }
            }
            richTextBox1.SelectionFont = New;
            
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font New, Choosed;
            Choosed = richTextBox1.SelectionFont;
            /*
            if (Choosed.Italic)
            {
                New = new Font(Choosed, Choosed.Style & ~FontStyle.Italic);
                ItalicBtn.Checked = false;
            }
            else
            {
                New = new Font(Choosed, Choosed.Style | FontStyle.Italic);
                ItalicBtn.Checked = true;
            }
            */
            if (Choosed.Italic == false)
            {
                if (Choosed.Bold == true && Choosed.Underline == false)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Italic);
                }
                else if (Choosed.Bold == false && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Italic | FontStyle.Underline);
                }
                else if (Choosed.Bold == true && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    New = new Font(Choosed, FontStyle.Italic);
                }
            }
            else
            {
                if (Choosed.Bold == true && Choosed.Underline == false)
                {
                    New = new Font(Choosed, FontStyle.Bold);
                }
                else if (Choosed.Bold == false && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Underline);
                }
                else if (Choosed.Bold == true && Choosed.Underline == true)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Underline);
                }
                else
                {
                    New = new Font(Choosed, FontStyle.Regular);
                }
            }
            richTextBox1.SelectionFont = New;
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font New, Choosed;
            Choosed = richTextBox1.SelectionFont;
            /*
            if (Choosed.Underline)
            {
                New = new Font(Choosed, Choosed.Style & ~FontStyle.Underline);
                UnderlineBtn.Checked = false;
            }
            else
            {
                New = new Font(Choosed, Choosed.Style | FontStyle.Underline);
                UnderlineBtn.Checked = true;
            }
            */
            if (Choosed.Underline == false)
            {
                if (Choosed.Bold == true && Choosed.Italic == false)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Underline);
                }
                else if (Choosed.Bold == false && Choosed.Italic == true)
                {
                    New = new Font(Choosed, FontStyle.Italic | FontStyle.Underline);
                }
                else if (Choosed.Bold == true && Choosed.Italic == true)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    New = new Font(Choosed, FontStyle.Underline);
                }
            }
            else
            {
                if (Choosed.Bold == true && Choosed.Italic == false)
                {
                    New = new Font(Choosed, FontStyle.Bold);
                }
                else if (Choosed.Bold == false && Choosed.Italic == true)
                {
                    New = new Font(Choosed, FontStyle.Italic);
                }
                else if (Choosed.Bold == true && Choosed.Italic == true)
                {
                    New = new Font(Choosed, FontStyle.Bold | FontStyle.Italic);
                }
                else
                {
                    New = new Font(Choosed, FontStyle.Regular);
                }
            }
            richTextBox1.SelectionFont = New;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            var Warna = new ColorDialog();
            Warna.ShowDialog();
            richTextBox1.ForeColor = Warna.Color;
        }

        private void FontSizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, int.Parse(FontSizeCB.SelectedItem.ToString()));
        }

        private void FontFamilyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamilyCB.SelectedItem.ToString(),richTextBox1.SelectionFont.Size);
        }



    }
}
