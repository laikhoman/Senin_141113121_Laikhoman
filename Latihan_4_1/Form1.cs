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
            System.Drawing.Font choosed = richTextBox1.SelectionFont;
            System.Drawing.FontStyle currentFont = FontStyle.Regular;
            if (richTextBox1.SelectionFont.Italic == true && richTextBox1.SelectionFont.Underline == true)
                currentFont = FontStyle.Italic | FontStyle.Underline;
            else if (richTextBox1.SelectionFont.Italic == true)
                currentFont = FontStyle.Italic;
            else if (richTextBox1.SelectionFont.Underline == true)
                currentFont = FontStyle.Underline;

            if (richTextBox1.SelectionFont.Bold != true)
            {
                currentFont |= FontStyle.Bold;
                BoldBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                BoldBtn.BackColor = System.Drawing.Color.Transparent;
            richTextBox1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            System.Drawing.Font choosed = richTextBox1.SelectionFont;
            System.Drawing.FontStyle currentFont = FontStyle.Regular;
            if (richTextBox1.SelectionFont.Bold == true && richTextBox1.SelectionFont.Underline == true)
                currentFont = FontStyle.Bold | FontStyle.Underline;
            else if (richTextBox1.SelectionFont.Bold == true)
                currentFont = FontStyle.Bold;
            else if (richTextBox1.SelectionFont.Underline == true)
                currentFont = FontStyle.Underline;

            if (richTextBox1.SelectionFont.Italic != true)
            {
                currentFont |= FontStyle.Italic;
                ItalicBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                ItalicBtn.BackColor = System.Drawing.Color.Transparent;
            richTextBox1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            System.Drawing.Font choosed = richTextBox1.SelectionFont;
            System.Drawing.FontStyle currentFont = FontStyle.Regular;
            if (richTextBox1.SelectionFont.Bold == true && richTextBox1.SelectionFont.Italic == true)
                currentFont = FontStyle.Bold | FontStyle.Italic;
            else if (richTextBox1.SelectionFont.Bold == true)
                currentFont = FontStyle.Bold;
            else if (richTextBox1.SelectionFont.Italic == true)
                currentFont = FontStyle.Italic;

            if (richTextBox1.SelectionFont.Underline != true)
            {
                currentFont |= FontStyle.Underline;
                UnderlineBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                UnderlineBtn.BackColor = System.Drawing.Color.Transparent;
            richTextBox1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
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
        private void New_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Tag=="true")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Do you want to save changes ?", "First Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
            }
            else
            {
                ActiveForm.Hide();
                Form1 newform = new Form1();
                newform.ShowDialog();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Tag = "true";
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Tag == "true")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Do you want to save changes ?", "First Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (result == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }






    }
}