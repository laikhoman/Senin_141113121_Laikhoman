﻿namespace Latihan_2_1
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2017, 4, 3, 0, 0, 0, 0)};
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 102);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 4;
            this.monthCalendar1.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("13");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Items.Add("17");
            this.domainUpDown1.Items.Add("18");
            this.domainUpDown1.Items.Add("19");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Items.Add("21");
            this.domainUpDown1.Items.Add("22");
            this.domainUpDown1.Items.Add("23");
            this.domainUpDown1.Items.Add("24");
            this.domainUpDown1.Items.Add("25");
            this.domainUpDown1.Items.Add("26");
            this.domainUpDown1.Items.Add("27");
            this.domainUpDown1.Items.Add("28");
            this.domainUpDown1.Items.Add("29");
            this.domainUpDown1.Items.Add("30");
            this.domainUpDown1.Items.Add("31");
            this.domainUpDown1.Location = new System.Drawing.Point(18, 57);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(138, 20);
            this.domainUpDown1.TabIndex = 1;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("Januari");
            this.domainUpDown2.Items.Add("Februari");
            this.domainUpDown2.Items.Add("Maret");
            this.domainUpDown2.Items.Add("April");
            this.domainUpDown2.Items.Add("Mei");
            this.domainUpDown2.Items.Add("Juni");
            this.domainUpDown2.Items.Add("Juli");
            this.domainUpDown2.Items.Add("Agustus");
            this.domainUpDown2.Items.Add("September");
            this.domainUpDown2.Items.Add("Oktober");
            this.domainUpDown2.Items.Add("November");
            this.domainUpDown2.Items.Add("Desember");
            this.domainUpDown2.Location = new System.Drawing.Point(177, 57);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(149, 20);
            this.domainUpDown2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bulan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

