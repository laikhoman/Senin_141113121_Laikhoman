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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barang frm_Barang = new Barang();
            frm_Barang.MdiParent = this;
            frm_Barang.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier frm_Supplier = new Supplier();
            frm_Supplier.MdiParent = this;
            frm_Supplier.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pembayaran frm = new Pembayaran();
            frm.MdiParent = this;
            frm.Show();
        }


    }
}
