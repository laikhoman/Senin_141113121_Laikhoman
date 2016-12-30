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
    public partial class Barang : Form
    {
        // Database Connection
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=12345");
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        string maximum_id;
        string session_id;
        public Barang()
        {
            InitializeComponent();
        }
        private void Barang_Load(object sender, EventArgs e)
        {
            tampil_list();
        }
        public void tampil_list()
        {
            cmd = new MySqlCommand("select * from barang", conn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            list_Barang_View.DataSource = dt;
        }
        public void Search_Gridview()
        {
            if (search_text.TextLength != 0)
            {
                cmd = new MySqlCommand("select * from barang where kode like concat('%', @kode, '%') or nama like concat('%', @nama, '%')", conn);
                cmd.Parameters.AddWithValue("@kode", search_text.Text);
                cmd.Parameters.AddWithValue("@nama", search_text.Text);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                list_Barang_View.DataSource = dt;

            }
            else
            {
                tampil_list();
            }

        }
        public static DateTime get_UniversalTimeCNow()
        {
            DateTime UTCNow = DateTime.UtcNow;
            int year = UTCNow.Year;
            int month = UTCNow.Month;
            int day = UTCNow.Day;
            int hour = UTCNow.Hour;
            int min = UTCNow.Minute;
            int sec = UTCNow.Second;
            DateTime datetime = new DateTime(year, month, day, hour, min, sec);
            return datetime;
        }
        public string count_id(string table)
        {
            cmd = new MySqlCommand("select ifnull(max(ID),0)+1 from barang", conn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            maximum_id = dt.Rows[0][0].ToString();
            return maximum_id;
        }
        public void clear_form()
        {
            txt_add_Jual.Text = "";
            txt_add_Kode.Text = "";
            txt_add_Modal.Text = "";
            txt_add_Nama.Text = "";
            txt_add_Stock.Text = "";
        }
        public void checker(TextBox txtBox)
        {
            if (txtBox == null)
            {
                return;
            }

            if (txtBox.Text == "")
            {
                txtBox.BackColor = Color.Red;
            }
            else
            {
                txtBox.BackColor = Color.White;
            }

        }
        public void moneychecking(KeyPressEventArgs ex)
        {
            ex.Handled = !char.IsDigit(ex.KeyChar) && ex.KeyChar != (char)8; // 8 is backspace
        }
        public void zeroblocking(TextBox txt)
        {
            if (txt.TextLength == 1)
            {
                if (txt.Text[0].ToString() == "0")
                {
                    txt.Text = "";
                }
                else
                {
                    return;
                }
            }
        }
        private void add_submit_Click(object sender, EventArgs e)
        {
            string kode, nama, stok, hpp, hj;
            string id = count_id("barang");
            kode = txt_add_Kode.Text;
            nama = txt_add_Nama.Text;
            stok = txt_add_Stock.Text;
            hpp = txt_add_Modal.Text;
            hj = txt_add_Jual.Text;
            if (string.IsNullOrEmpty(kode))
            {
                MessageBox.Show("Kode barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(stok))
            {
                MessageBox.Show("Jumlah stock tidak boleh nol !");
                return;
            }
            if (string.IsNullOrEmpty(hpp))
            {
                MessageBox.Show("Harga masuk tidak ada !");
                return;
            }
            if (string.IsNullOrEmpty(hj))
            {
                MessageBox.Show("Harga jual tidak ada !");
                return;
            }
            DateTime created_at = get_UniversalTimeCNow();
            DateTime edit_at = get_UniversalTimeCNow();
            cmd = new MySqlCommand("INSERT INTO barang VALUES(@id,@kode,@nama,@jumlahawal,@hargahpp,@hargajual,@createdat,@updatedat)", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahawal", stok);
            cmd.Parameters.AddWithValue("@hargahpp", hpp);
            cmd.Parameters.AddWithValue("@hargajual", hj);
            cmd.Parameters.AddWithValue("@createdat", created_at);
            cmd.Parameters.AddWithValue("@updatedat", edit_at);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUKSES");
                conn.Close();
                tampil_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        private void reset_Submit_Click(object sender, EventArgs e)
        {
            clear_form();
            txt_add_Kode.Focus();
        }
        private void txt_add_Kode_TextChanged(object sender, EventArgs e)
        {
            checker(sender as TextBox);
        }
        private void txt_add_Nama_TextChanged(object sender, EventArgs e)
        {
            checker(sender as TextBox);
        }
        private void txt_add_Stock_TextChanged(object sender, EventArgs e)
        {
            zeroblocking(sender as TextBox);
        }
        private void txt_add_Modal_TextChanged(object sender, EventArgs e)
        {
            zeroblocking(sender as TextBox);
        }
        private void txt_add_Jual_TextChanged(object sender, EventArgs e)
        {
            zeroblocking(sender as TextBox);
        }
        private void txt_edit_Kode_TextChanged(object sender, EventArgs e)
        {
            checker(sender as TextBox);
        }
        private void txt_edit_Nama_TextChanged(object sender, EventArgs e)
        {
            checker(sender as TextBox);
        }
        private void txt_edit_Stock_TextChanged(object sender, EventArgs e)
        {
            zeroblocking(sender as TextBox);
        }
        private void txt_edit_Modal_TextChanged(object sender, EventArgs e)
        {
            zeroblocking(sender as TextBox);
        }
        private void txt_edit_Jual_TextChanged(object sender, EventArgs e)
        {
            zeroblocking(sender as TextBox);
        }
        private void txt_add_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            moneychecking(e);
        }
        private void txt_add_Modal_KeyPress(object sender, KeyPressEventArgs e)
        {
            moneychecking(e);
        }
        private void txt_add_Jual_KeyPress(object sender, KeyPressEventArgs e)
        {
            moneychecking(e);
        }
        private void txt_edit_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            moneychecking(e);
        }
        private void txt_edit_Modal_KeyPress(object sender, KeyPressEventArgs e)
        {
            moneychecking(e);
        }
        private void txt_edit_Jual_KeyPress(object sender, KeyPressEventArgs e)
        {
            moneychecking(e);

        }
        private void search_text_TextChanged(object sender, EventArgs e)
        {
            Search_Gridview();
        }
        private void list_Barang_View_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = list_Barang_View.Rows[rowIndex];
                session_id = row.Cells[0].Value.ToString();
                txt_edit_Kode.Text = row.Cells[1].Value.ToString();
                txt_edit_Nama.Text = row.Cells[2].Value.ToString();
                txt_edit_Stock.Text = row.Cells[3].Value.ToString();
                txt_edit_Modal.Text = row.Cells[4].Value.ToString();
                txt_edit_Jual.Text = row.Cells[5].Value.ToString();
                tab_Barang.SelectTab(1);
            }

        }
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            string kode, nama, stok, hpp, hj;
            kode = txt_edit_Kode.Text;
            nama = txt_edit_Nama.Text;
            stok = txt_edit_Stock.Text;
            hpp = txt_edit_Modal.Text;
            hj = txt_edit_Jual.Text;
            if (string.IsNullOrEmpty(kode))
            {
                MessageBox.Show("Kode barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(stok))
            {
                MessageBox.Show("Jumlah stock tidak boleh nol !");
                return;
            }
            if (string.IsNullOrEmpty(hpp))
            {
                MessageBox.Show("Harga masuk tidak ada !");
                return;
            }
            if (string.IsNullOrEmpty(hj))
            {
                MessageBox.Show("Harga jual tidak ada !");
                return;
            }
            DateTime edit_at = get_UniversalTimeCNow();
            cmd = new MySqlCommand("update barang set Kode=@code,Nama=@nama,Stock=@stock,Harga_Beli=@hm,Harga_Jual=@hj,Edited_At=@ed WHERE ID=@session", conn);
            cmd.Parameters.AddWithValue("@code", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@stock", stok);
            cmd.Parameters.AddWithValue("@hm", hpp);
            cmd.Parameters.AddWithValue("@hj", hj);
            cmd.Parameters.AddWithValue("@ed", edit_at);
            cmd.Parameters.AddWithValue("@session", session_id);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUKSES");
                conn.Close();
                tampil_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void tab_Barang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab_Barang.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("1");
                    break;
                case 1:
                    MessageBox.Show("2");
                    break;
                case 2:
                    MessageBox.Show("3");
                    break;
            }
        }
    }
}
