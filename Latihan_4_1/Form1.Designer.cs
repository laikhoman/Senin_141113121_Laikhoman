namespace Latihan_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.FontSizeCB = new System.Windows.Forms.ToolStripComboBox();
            this.BoldBtn = new System.Windows.Forms.ToolStripButton();
            this.ItalicBtn = new System.Windows.Forms.ToolStripButton();
            this.UnderlineBtn = new System.Windows.Forms.ToolStripButton();
            this.FontFamilyLabel = new System.Windows.Forms.ToolStripLabel();
            this.FontFamilyCB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(525, 408);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeLabel,
            this.FontSizeCB,
            this.BoldBtn,
            this.ItalicBtn,
            this.UnderlineBtn,
            this.FontFamilyLabel,
            this.FontFamilyCB,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(371, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 22);
            this.SizeLabel.Text = "Size";
            // 
            // FontSizeCB
            // 
            this.FontSizeCB.Name = "FontSizeCB";
            this.FontSizeCB.Size = new System.Drawing.Size(75, 25);
            this.FontSizeCB.SelectedIndexChanged += new System.EventHandler(this.FontSizeCB_SelectedIndexChanged);
            // 
            // BoldBtn
            // 
            this.BoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldBtn.Image = ((System.Drawing.Image)(resources.GetObject("BoldBtn.Image")));
            this.BoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(23, 22);
            this.BoldBtn.Text = "B";
            this.BoldBtn.Click += new System.EventHandler(this.Bold_Click);
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItalicBtn.Image")));
            this.ItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(23, 22);
            this.ItalicBtn.Text = "I";
            this.ItalicBtn.Click += new System.EventHandler(this.Italic_Click);
            // 
            // UnderlineBtn
            // 
            this.UnderlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineBtn.Image")));
            this.UnderlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineBtn.Name = "UnderlineBtn";
            this.UnderlineBtn.Size = new System.Drawing.Size(23, 22);
            this.UnderlineBtn.Text = "U";
            this.UnderlineBtn.Click += new System.EventHandler(this.Underline_Click);
            // 
            // FontFamilyLabel
            // 
            this.FontFamilyLabel.Name = "FontFamilyLabel";
            this.FontFamilyLabel.Size = new System.Drawing.Size(31, 22);
            this.FontFamilyLabel.Text = "Font";
            // 
            // FontFamilyCB
            // 
            this.FontFamilyCB.Name = "FontFamilyCB";
            this.FontFamilyCB.Size = new System.Drawing.Size(130, 25);
            this.FontFamilyCB.SelectedIndexChanged += new System.EventHandler(this.FontFamilyCB_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "ColorBtn";
            this.toolStripButton1.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(50, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.open,
            this.save,
            this.exit});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(152, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(152, 22);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(152, 22);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 473);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SizeLabel;
        private System.Windows.Forms.ToolStripComboBox FontSizeCB;
        private System.Windows.Forms.ToolStripButton BoldBtn;
        private System.Windows.Forms.ToolStripButton ItalicBtn;
        private System.Windows.Forms.ToolStripButton UnderlineBtn;
        private System.Windows.Forms.ToolStripLabel FontFamilyLabel;
        private System.Windows.Forms.ToolStripComboBox FontFamilyCB;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}

