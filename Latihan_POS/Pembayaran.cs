using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Latihan_POS
{
    public partial class Pembayaran : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=12345");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand job;
        public Pembayaran()
        {
            InitializeComponent();
        }
        public void Show_Datagridview_By(string table)
        {
            job = new MySqlCommand("select * from " + table, con);
            DA = new MySqlDataAdapter(job);
            DT = new DataTable();
            DA.Fill(DT);
            if (table == "barang")
            {
                Dataview_Barang.DataSource = DT;
            }
            else if (table == "customer")
            {
                Dataview_Customer.DataSource = DT;
            }
        }

        private void tab_pembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab_pembayaran.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    Show_Datagridview_By("barang");
                    break;
                case 2:
                    Show_Datagridview_By("customer");
                    break;
            }
        }

        private void SearchText_Customer_TextChanged(object sender, EventArgs e)
        {
            if (SearchText_Customer.TextLength != 0)
            {
                job = new MySqlCommand("select * from customer where Nama like concat('%', @kode, '%') OR ID like concat('%', @nama, '%')", con);
                job.Parameters.AddWithValue("@kode", SearchText_Customer.Text);
                job.Parameters.AddWithValue("@nama", SearchText_Customer.Text);
                DA = new MySqlDataAdapter(job);
                DT = new DataTable();
                DA.Fill(DT);
                Dataview_Customer.DataSource = DT;

            }
            else
            {
                Show_Datagridview_By("customer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = User_Validation_Field.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                job = new MySqlCommand("select * from customer where ID like concat('%', @ID, '%')", con);
                job.Parameters.AddWithValue("@ID", text);
                con.Open();
                try
                {
                    job.ExecuteNonQuery();
                    DA = new MySqlDataAdapter(job);
                    DT = new DataTable();
                    DA.Fill(DT);
                    DataView dv = new DataView(DT);
                    dv.RowFilter = "ID = " + text;
                    if (dv.Table.Rows.Count > 0)
                    {
                        MessageBox.Show("User ditemukan !");
                        User_Validation_Field.BackColor = Color.Green;
                        Kode_Barang_Field.Enabled = true;
                        Nama_Barang_Field.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("User tidak ditemukan.");
                        User_Validation_Field.BackColor = Color.Red;
                    }
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }

        private void User_Validation_Field_TextChanged(object sender, EventArgs e)
        {
            if (User_Validation_Field.TextLength == 0 || string.IsNullOrWhiteSpace(User_Validation_Field.Text))
            {
                Kode_Barang_Field.Enabled = false;
                Nama_Barang_Field.Enabled = false;
                User_Validation_Field.BackColor = Color.White;
            }
        }

        private void User_Validation_Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > (char)0)
            {
                Kode_Barang_Field.Enabled = false;
                Nama_Barang_Field.Enabled = false;
                User_Validation_Field.BackColor = Color.White;
            }
        }
    }
}
