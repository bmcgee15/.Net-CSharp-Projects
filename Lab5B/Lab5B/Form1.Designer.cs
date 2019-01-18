namespace Lab5B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.theDoctorGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.episodeTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.actorTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanionsGroupBox = new System.Windows.Forms.GroupBox();
            this.companionsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.theDoctorGroupBox.SuspendLayout();
            this.CompanionsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(72, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tardis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // theDoctorGroupBox
            // 
            this.theDoctorGroupBox.Controls.Add(this.doctorComboBox);
            this.theDoctorGroupBox.Controls.Add(this.episodeTextBox);
            this.theDoctorGroupBox.Controls.Add(this.ageTextBox);
            this.theDoctorGroupBox.Controls.Add(this.seriesTextBox);
            this.theDoctorGroupBox.Controls.Add(this.actorTextBox);
            this.theDoctorGroupBox.Controls.Add(this.yearTextBox);
            this.theDoctorGroupBox.Controls.Add(this.label5);
            this.theDoctorGroupBox.Controls.Add(this.label4);
            this.theDoctorGroupBox.Controls.Add(this.label3);
            this.theDoctorGroupBox.Controls.Add(this.label2);
            this.theDoctorGroupBox.Controls.Add(this.label1);
            this.theDoctorGroupBox.Location = new System.Drawing.Point(15, 50);
            this.theDoctorGroupBox.Name = "theDoctorGroupBox";
            this.theDoctorGroupBox.Size = new System.Drawing.Size(266, 215);
            this.theDoctorGroupBox.TabIndex = 1;
            this.theDoctorGroupBox.TabStop = false;
            this.theDoctorGroupBox.Text = "The Doctor";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(78, 45);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(82, 21);
            this.doctorComboBox.TabIndex = 10;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // episodeTextBox
            // 
            this.episodeTextBox.Location = new System.Drawing.Point(9, 181);
            this.episodeTextBox.Name = "episodeTextBox";
            this.episodeTextBox.ReadOnly = true;
            this.episodeTextBox.Size = new System.Drawing.Size(237, 20);
            this.episodeTextBox.TabIndex = 9;
            this.episodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(177, 129);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(69, 20);
            this.ageTextBox.TabIndex = 8;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Location = new System.Drawing.Point(57, 129);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.ReadOnly = true;
            this.seriesTextBox.Size = new System.Drawing.Size(38, 20);
            this.seriesTextBox.TabIndex = 7;
            this.seriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // actorTextBox
            // 
            this.actorTextBox.Location = new System.Drawing.Point(78, 86);
            this.actorTextBox.Name = "actorTextBox";
            this.actorTextBox.ReadOnly = true;
            this.actorTextBox.Size = new System.Drawing.Size(168, 20);
            this.actorTextBox.TabIndex = 6;
            this.actorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(177, 46);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(69, 20);
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Full Episode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Series:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age at Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Played By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor:";
            // 
            // CompanionsGroupBox
            // 
            this.CompanionsGroupBox.Controls.Add(this.companionsListBox);
            this.CompanionsGroupBox.Location = new System.Drawing.Point(296, 50);
            this.CompanionsGroupBox.Name = "CompanionsGroupBox";
            this.CompanionsGroupBox.Size = new System.Drawing.Size(378, 435);
            this.CompanionsGroupBox.TabIndex = 2;
            this.CompanionsGroupBox.TabStop = false;
            this.CompanionsGroupBox.Text = "Companions and their first episode with this Doctor:";
            // 
            // companionsListBox
            // 
            this.companionsListBox.FormattingEnabled = true;
            this.companionsListBox.Location = new System.Drawing.Point(18, 29);
            this.companionsListBox.Name = "companionsListBox";
            this.companionsListBox.Size = new System.Drawing.Size(343, 394);
            this.companionsListBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 497);
            this.Controls.Add(this.CompanionsGroupBox);
            this.Controls.Add(this.theDoctorGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.theDoctorGroupBox.ResumeLayout(false);
            this.theDoctorGroupBox.PerformLayout();
            this.CompanionsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox theDoctorGroupBox;
        private System.Windows.Forms.GroupBox CompanionsGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.TextBox episodeTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox actorTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.ListBox companionsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

