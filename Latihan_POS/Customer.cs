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
    public partial class Customer : Form
    {
        // Database Connection
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=12345");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand job;
        string maximum_id;
        string session_id;
        public Customer()
        {
            InitializeComponent();
        }

        #region Function
        public void show_list()
        {
            job = new MySqlCommand("select * from customer", con);
            DA = new MySqlDataAdapter(job);
            DT = new DataTable();
            DA.Fill(DT);
            list_customer_view.DataSource = DT;
        }
        public void Search_With_Gridview()
        {
            if (search_customer_field.TextLength != 0)
            {
                job = new MySqlCommand("select * from customer where Nama like concat('%', @kode, '%') OR ID like concat('%', @nama, '%')", con);
                job.Parameters.AddWithValue("@kode", search_customer_field.Text);
                job.Parameters.AddWithValue("@nama", search_customer_field.Text);
                DA = new MySqlDataAdapter(job);
                DT = new DataTable();
                DA.Fill(DT);
                list_customer_view.DataSource = DT;

            }
            else
            {
                show_list();
            }

        }
        public void reset_field()
        {
            add_nama_cust.Text = "";
            add_hp_cust.Text = "";
            add_alamat_cust.Text = "";
        }
        public string count_id(string table)
        {
            job = new MySqlCommand("select ifnull(max(ID),0)+1 from customer", con);
            DA = new MySqlDataAdapter(job);
            DT = new DataTable();
            DA.Fill(DT);
            maximum_id = DT.Rows[0][0].ToString();
            return maximum_id;
        }
        public void number_checker(KeyPressEventArgs ex, TextBox txt)
        {
            ex.Handled = !char.IsDigit(ex.KeyChar) && ex.KeyChar != (char)8; // 8 is backspace
            //MessageBox.Show(ex.KeyChar.ToString());
            if (txt.Text == "" || txt.TextLength <= 0)
            {
                txt.BackColor = Color.White;
                if (Convert.ToInt32(ex.KeyChar) == 49)
                {
                    txt.BackColor = Color.Red;
                }
            }

            else if (txt.TextLength >= 0)
            {
                if ((Convert.ToInt32(ex.KeyChar) >= 49 && Convert.ToInt32(ex.KeyChar) <= 57 && txt.TextLength == 0) || (txt.Text[0].ToString() != "0" && txt.TextLength >= -1))
                {
                    txt.BackColor = Color.Red;
                }
                else
                {
                    txt.BackColor = Color.White;
                }
            }

            // Jika sudah lebih dari 12 digit maka tidak akan menerima inputan lagi
            if (add_hp_cust.Text.Length >= 12)
            {
                ex.Handled = ex.KeyChar != (char)8;
            }


        }

        public static DateTime get_UTCNow()
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
        private void reset_Btn_Click(object sender, EventArgs e)
        {
            reset_field();
        }
        #endregion

        #region Event-Form-Handling
        private void Customer_Load(object sender, EventArgs e)
        {
            show_list();
        }
        private void add_hp_cust_KeyPress(object sender, KeyPressEventArgs e)
        {
            number_checker(e, sender as TextBox);
        }
        private void edit_hp_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            number_checker(e, sender as TextBox);
        }
        private void add_Btn_Click(object sender, EventArgs e)
        {
            string nama, alamat, hp, gender;
            string id = count_id("customer");
            nama = add_nama_cust.Text;
            alamat = add_alamat_cust.Text;
            hp = add_hp_cust.Text;
            gender = add_gender_cust.Text;
            if (string.IsNullOrEmpty(nama)) { return; }
            if (string.IsNullOrEmpty(alamat)) { return; }
            if (string.IsNullOrEmpty(hp) || Convert.ToInt32(hp[0]) == 49) { return; }
            if (string.IsNullOrEmpty(gender)) { return; }
            DateTime created_at = get_UTCNow();
            DateTime edit_at = get_UTCNow();
            job = new MySqlCommand("INSERT INTO customer VALUES(@id,@nama,@alamat,@hp,@gender,@cr,@ed)", con);
            job.Parameters.AddWithValue("@id", id);
            job.Parameters.AddWithValue("@nama", nama);
            job.Parameters.AddWithValue("@alamat", alamat);
            job.Parameters.AddWithValue("@hp", hp);
            job.Parameters.AddWithValue("@gender", gender);
            job.Parameters.AddWithValue("@cr", created_at);
            job.Parameters.AddWithValue("@ed", edit_at);
            try
            {
                con.Open();
                job.ExecuteNonQuery();
                MessageBox.Show("SUKSES");
                con.Close();
                show_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void search_customer_field_TextChanged(object sender, EventArgs e)
        {
            Search_With_Gridview();
        }
        #endregion

        private void list_customer_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = list_customer_view.Rows[rowIndex];
                session_id = row.Cells[0].Value.ToString();
                edit_nama.Text = row.Cells[1].Value.ToString();
                edit_alamat.Text = row.Cells[2].Value.ToString();
                edit_HP.Text = row.Cells[3].Value.ToString();
                edit_gender.Text = row.Cells[4].Value.ToString();
                CustomerTab.SelectTab(1);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            string nama, alamat, hp, gender;
            string id = session_id;
            nama = edit_nama.Text;
            alamat = edit_alamat.Text;
            hp = edit_HP.Text;
            gender = edit_gender.Text;
            if (string.IsNullOrEmpty(nama)) { return; }
            if (string.IsNullOrEmpty(alamat)) { return; }
            if (string.IsNullOrEmpty(hp) || Convert.ToInt32(hp[0]) == 49 || hp.Length > 12) { edit_HP.BackColor = Color.Red; return; }
            if (string.IsNullOrEmpty(gender)) { return; }
            DateTime edit_at = get_UTCNow();
            job = new MySqlCommand("update customer set Nama=@nama,Alamat=@alamat, NoHp=@hp,Gender=@gender,Editied_At=@ed WHERE ID=@session", con);
            job.Parameters.AddWithValue("@nama", nama);
            job.Parameters.AddWithValue("@alamat", alamat);
            job.Parameters.AddWithValue("@hp", hp);
            job.Parameters.AddWithValue("@gender", gender);
            job.Parameters.AddWithValue("@ed", edit_at);
            job.Parameters.AddWithValue("@session", id);
            try
            {
                con.Open();
                job.ExecuteNonQuery();
                MessageBox.Show("SUKSES");
                con.Close();
                show_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
