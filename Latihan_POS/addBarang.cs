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
    public partial class FormBarang : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=12345");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand comm;
        public FormBarang()
        {
            InitializeComponent();
        }
        string max;
        public string htg_id(string table)
        {
            comm = new MySqlCommand("select ifnull(max(id),0)+1 from barang", con);
            DA = new MySqlDataAdapter(comm);
            DT = new DataTable();
            DA.Fill(DT);
            max = DT.Rows[0][0].ToString();
            return max;
        }
        void insert_data(string table)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Kode barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama barang belum diisi!");
                return;
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Jumlah stock tidak boleh nol !");
                return;
            }
            if (numericUpDown2.Value <= 0)
            {
                MessageBox.Show("Harga masuk tidak valid !");
                return;
            }
            if (numericUpDown3.Value <= 0)
            {
                MessageBox.Show("Harga jual tidak valid !");
                return;
            }

            string id = htg_id(table);
            comm = new MySqlCommand("INSERT INTO barang VALUES(@id,@nama,@jumlahawal,@hargahpp,@hargajual,@kode)", conn);
            comm.Parameters.AddWithValue("@id", id + 1);
            comm.Parameters.AddWithValue("@kode", txtID.Text);
            comm.Parameters.AddWithValue("@nama", txtNama.Text);
            comm.Parameters.AddWithValue("@jumlahawal", numericUpDown1.Value);
            comm.Parameters.AddWithValue("@hargahpp", numericUpDown2.Value);
            comm.Parameters.AddWithValue("@hargajual", numericUpDown3.Value);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("sukses");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            insert_data("barang");
        }

    }
}
