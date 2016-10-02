using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = hScrollBar1.Value.ToString();
            int min = Int32.Parse(label3.Text);
            int max = Int32.Parse(label4.Text);
            if (max > min)
            {
                label8.Text = "";
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(max - min);
            }
            else
                label8.Text = "range <= 0 !\nAtur kembali rangenya";
            /*
            try
            {
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(max - min);
            }
            catch
            {
                //label8.Text = "range <= 0 !\nAtur kembali rangenya";
                MessageBox.Show("aaa");
            }
            */
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = hScrollBar2.Value.ToString();
            int min = Int32.Parse(label3.Text);
            int max = Int32.Parse(label4.Text);
            if (max > min)
            {
                label8.Text = "";
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(max - min);
            }
            else
                label8.Text = "range <= 0 !\nAtur kembali rangenya";
                
            /*
            try
            {
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(max - min);
            }
            catch
            {
                //label8.Text = "range <= 0 !\nAtur kembali rangenya";
                MessageBox.Show("aaa");
            }
             */
        }


    }
}
