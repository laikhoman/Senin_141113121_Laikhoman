namespace Latihan_POS
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerTab = new System.Windows.Forms.TabControl();
            this.Cust_Add = new System.Windows.Forms.TabPage();
            this.add_Btn = new System.Windows.Forms.Button();
            this.reset_Btn = new System.Windows.Forms.Button();
            this.add_gender_cust = new System.Windows.Forms.ComboBox();
            this.add_hp_cust = new System.Windows.Forms.TextBox();
            this.add_alamat_cust = new System.Windows.Forms.TextBox();
            this.add_nama_cust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title_tab1 = new System.Windows.Forms.Label();
            this.Cust_Edit = new System.Windows.Forms.TabPage();
            this.edit_gender = new System.Windows.Forms.ComboBox();
            this.edit_HP = new System.Windows.Forms.TextBox();
            this.edit_alamat = new System.Windows.Forms.TextBox();
            this.edit_nama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cust_List = new System.Windows.Forms.TabPage();
            this.edit_Btn = new System.Windows.Forms.Button();
            this.list_customer_view = new System.Windows.Forms.DataGridView();
            this.search_customer_field = new System.Windows.Forms.TextBox();
            this.CustomerTab.SuspendLayout();
            this.Cust_Add.SuspendLayout();
            this.Cust_Edit.SuspendLayout();
            this.Cust_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_customer_view)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.Cust_Add);
            this.CustomerTab.Controls.Add(this.Cust_Edit);
            this.CustomerTab.Controls.Add(this.Cust_List);
            this.CustomerTab.Location = new System.Drawing.Point(2, 2);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.SelectedIndex = 0;
            this.CustomerTab.Size = new System.Drawing.Size(488, 238);
            this.CustomerTab.TabIndex = 0;
            // 
            // Cust_Add
            // 
            this.Cust_Add.Controls.Add(this.add_Btn);
            this.Cust_Add.Controls.Add(this.reset_Btn);
            this.Cust_Add.Controls.Add(this.add_gender_cust);
            this.Cust_Add.Controls.Add(this.add_hp_cust);
            this.Cust_Add.Controls.Add(this.add_alamat_cust);
            this.Cust_Add.Controls.Add(this.add_nama_cust);
            this.Cust_Add.Controls.Add(this.label4);
            this.Cust_Add.Controls.Add(this.label3);
            this.Cust_Add.Controls.Add(this.label2);
            this.Cust_Add.Controls.Add(this.label1);
            this.Cust_Add.Controls.Add(this.title_tab1);
            this.Cust_Add.Location = new System.Drawing.Point(4, 22);
            this.Cust_Add.Name = "Cust_Add";
            this.Cust_Add.Padding = new System.Windows.Forms.Padding(3);
            this.Cust_Add.Size = new System.Drawing.Size(480, 212);
            this.Cust_Add.TabIndex = 0;
            this.Cust_Add.Text = "Tambah Customer";
            this.Cust_Add.UseVisualStyleBackColor = true;
            // 
            // add_Btn
            // 
            this.add_Btn.Location = new System.Drawing.Point(330, 177);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(75, 23);
            this.add_Btn.TabIndex = 10;
            this.add_Btn.Text = "Tambah";
            this.add_Btn.UseVisualStyleBackColor = true;
            // 
            // reset_Btn
            // 
            this.reset_Btn.Location = new System.Drawing.Point(233, 177);
            this.reset_Btn.Name = "reset_Btn";
            this.reset_Btn.Size = new System.Drawing.Size(75, 23);
            this.reset_Btn.TabIndex = 9;
            this.reset_Btn.Text = "Reset";
            this.reset_Btn.UseVisualStyleBackColor = true;
            // 
            // add_gender_cust
            // 
            this.add_gender_cust.FormattingEnabled = true;
            this.add_gender_cust.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.add_gender_cust.Location = new System.Drawing.Point(157, 135);
            this.add_gender_cust.Name = "add_gender_cust";
            this.add_gender_cust.Size = new System.Drawing.Size(248, 21);
            this.add_gender_cust.TabIndex = 8;
            this.add_gender_cust.Text = "Laki-Laki";
            // 
            // add_hp_cust
            // 
            this.add_hp_cust.Location = new System.Drawing.Point(157, 109);
            this.add_hp_cust.Name = "add_hp_cust";
            this.add_hp_cust.Size = new System.Drawing.Size(248, 20);
            this.add_hp_cust.TabIndex = 7;
            // 
            // add_alamat_cust
            // 
            this.add_alamat_cust.Location = new System.Drawing.Point(157, 78);
            this.add_alamat_cust.Name = "add_alamat_cust";
            this.add_alamat_cust.Size = new System.Drawing.Size(248, 20);
            this.add_alamat_cust.TabIndex = 6;
            // 
            // add_nama_cust
            // 
            this.add_nama_cust.Location = new System.Drawing.Point(157, 47);
            this.add_nama_cust.Name = "add_nama_cust";
            this.add_nama_cust.Size = new System.Drawing.Size(248, 20);
            this.add_nama_cust.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // title_tab1
            // 
            this.title_tab1.AutoSize = true;
            this.title_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tab1.Location = new System.Drawing.Point(153, 22);
            this.title_tab1.Name = "title_tab1";
            this.title_tab1.Size = new System.Drawing.Size(140, 20);
            this.title_tab1.TabIndex = 0;
            this.title_tab1.Text = "Tambah Customer";
            // 
            // Cust_Edit
            // 
            this.Cust_Edit.Controls.Add(this.edit_Btn);
            this.Cust_Edit.Controls.Add(this.edit_gender);
            this.Cust_Edit.Controls.Add(this.edit_HP);
            this.Cust_Edit.Controls.Add(this.edit_alamat);
            this.Cust_Edit.Controls.Add(this.edit_nama);
            this.Cust_Edit.Controls.Add(this.label9);
            this.Cust_Edit.Controls.Add(this.label5);
            this.Cust_Edit.Controls.Add(this.label6);
            this.Cust_Edit.Controls.Add(this.label7);
            this.Cust_Edit.Controls.Add(this.label8);
            this.Cust_Edit.Location = new System.Drawing.Point(4, 22);
            this.Cust_Edit.Name = "Cust_Edit";
            this.Cust_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Cust_Edit.Size = new System.Drawing.Size(480, 212);
            this.Cust_Edit.TabIndex = 1;
            this.Cust_Edit.Text = "Edit Customer";
            this.Cust_Edit.UseVisualStyleBackColor = true;
            // 
            // edit_gender
            // 
            this.edit_gender.FormattingEnabled = true;
            this.edit_gender.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.edit_gender.Location = new System.Drawing.Point(127, 127);
            this.edit_gender.Name = "edit_gender";
            this.edit_gender.Size = new System.Drawing.Size(248, 21);
            this.edit_gender.TabIndex = 13;
            this.edit_gender.Text = "Laki-Laki";
            // 
            // edit_HP
            // 
            this.edit_HP.Location = new System.Drawing.Point(127, 101);
            this.edit_HP.Name = "edit_HP";
            this.edit_HP.Size = new System.Drawing.Size(248, 20);
            this.edit_HP.TabIndex = 12;
            // 
            // edit_alamat
            // 
            this.edit_alamat.Location = new System.Drawing.Point(127, 70);
            this.edit_alamat.Name = "edit_alamat";
            this.edit_alamat.Size = new System.Drawing.Size(248, 20);
            this.edit_alamat.TabIndex = 11;
            // 
            // edit_nama
            // 
            this.edit_nama.Location = new System.Drawing.Point(127, 39);
            this.edit_nama.Name = "edit_nama";
            this.edit_nama.Size = new System.Drawing.Size(248, 20);
            this.edit_nama.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(170, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Edit Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nama";
            // 
            // Cust_List
            // 
            this.Cust_List.Controls.Add(this.search_customer_field);
            this.Cust_List.Controls.Add(this.list_customer_view);
            this.Cust_List.Location = new System.Drawing.Point(4, 22);
            this.Cust_List.Name = "Cust_List";
            this.Cust_List.Size = new System.Drawing.Size(480, 212);
            this.Cust_List.TabIndex = 2;
            this.Cust_List.Text = "List Customer";
            this.Cust_List.UseVisualStyleBackColor = true;
            // 
            // edit_Btn
            // 
            this.edit_Btn.Location = new System.Drawing.Point(300, 172);
            this.edit_Btn.Name = "edit_Btn";
            this.edit_Btn.Size = new System.Drawing.Size(75, 23);
            this.edit_Btn.TabIndex = 14;
            this.edit_Btn.Text = "Edit";
            this.edit_Btn.UseVisualStyleBackColor = true;
            // 
            // list_customer_view
            // 
            this.list_customer_view.AllowUserToAddRows = false;
            this.list_customer_view.AllowUserToDeleteRows = false;
            this.list_customer_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_customer_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_customer_view.Location = new System.Drawing.Point(0, 23);
            this.list_customer_view.Name = "list_customer_view";
            this.list_customer_view.RowHeadersVisible = false;
            this.list_customer_view.Size = new System.Drawing.Size(480, 189);
            this.list_customer_view.TabIndex = 0;
            // 
            // search_customer_field
            // 
            this.search_customer_field.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_customer_field.Location = new System.Drawing.Point(0, 0);
            this.search_customer_field.Name = "search_customer_field";
            this.search_customer_field.Size = new System.Drawing.Size(480, 20);
            this.search_customer_field.TabIndex = 1;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 240);
            this.Controls.Add(this.CustomerTab);
            this.Name = "Customer";
            this.Text = "Customer";
            this.CustomerTab.ResumeLayout(false);
            this.Cust_Add.ResumeLayout(false);
            this.Cust_Add.PerformLayout();
            this.Cust_Edit.ResumeLayout(false);
            this.Cust_Edit.PerformLayout();
            this.Cust_List.ResumeLayout(false);
            this.Cust_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_customer_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CustomerTab;
        private System.Windows.Forms.TabPage Cust_Add;
        private System.Windows.Forms.ComboBox add_gender_cust;
        private System.Windows.Forms.TextBox add_hp_cust;
        private System.Windows.Forms.TextBox add_alamat_cust;
        private System.Windows.Forms.TextBox add_nama_cust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_tab1;
        private System.Windows.Forms.TabPage Cust_Edit;
        private System.Windows.Forms.TabPage Cust_List;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.Button reset_Btn;
        private System.Windows.Forms.ComboBox edit_gender;
        private System.Windows.Forms.TextBox edit_HP;
        private System.Windows.Forms.TextBox edit_alamat;
        private System.Windows.Forms.TextBox edit_nama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button edit_Btn;
        private System.Windows.Forms.DataGridView list_customer_view;
        private System.Windows.Forms.TextBox search_customer_field;
    }
}