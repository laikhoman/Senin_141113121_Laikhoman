using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime firstOfDay = new DateTime(2016, 1, 1);
            DateTime currentDay = firstOfDay;
            while (firstOfDay.Year == currentDay.Year)
            {
                DayOfWeek dayOfWeek = currentDay.DayOfWeek;
                if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(currentDay);
                }
                currentDay = currentDay.AddDays(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bulan;
            int tgl;
            try
            {
                switch (domainUpDown2.SelectedItem.ToString())
                {
                    case "Januari":
                        bulan = 1;
                        break;
                    case "Februari":
                        bulan = 2;
                        break;
                    case "Maret":
                        bulan = 3;
                        break;
                    case "April":
                        bulan = 4;
                        break;
                    case "Mei":
                        bulan = 5;
                        break;
                    case "Juni":
                        bulan = 6;
                        break;
                    case "Juli":
                        bulan = 7;
                        break;
                    case "Agustus":
                        bulan = 8;
                        break;
                    case "September":
                        bulan = 9;
                        break;
                    case "Oktober":
                        bulan = 10;
                        break;
                    case "November":
                        bulan = 11;
                        break;
                    default:
                        bulan = 12;
                        break;
                }
                int tahun = monthCalendar1.SelectionStart.Year;
                tgl = Int16.Parse(domainUpDown1.Text);
                monthCalendar1.AddAnnuallyBoldedDate(new DateTime(tahun, bulan, tgl));
            }
            catch
            {
                MessageBox.Show("Mohon pilih tanggal dan bulan");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int tahun = monthCalendar1.SelectionStart.Year;
            int bulan = monthCalendar1.SelectionStart.Month;
            int tgl = monthCalendar1.SelectionStart.Day;
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(tahun, bulan, tgl));
        }
    }
}
