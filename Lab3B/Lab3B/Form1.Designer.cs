namespace Lab3B
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
            System.Windows.Forms.Button ExitButton;
            this.HairDresserComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChargedListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new System.Drawing.Point(1154, 583);
            ExitButton.Margin = new System.Windows.Forms.Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new System.Drawing.Size(242, 65);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HairDresserComboBox
            // 
            this.HairDresserComboBox.FormattingEnabled = true;
            this.HairDresserComboBox.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.HairDresserComboBox.Location = new System.Drawing.Point(24, 44);
            this.HairDresserComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.HairDresserComboBox.Name = "HairDresserComboBox";
            this.HairDresserComboBox.Size = new System.Drawing.Size(262, 33);
            this.HairDresserComboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HairDresserComboBox);
            this.groupBox1.Location = new System.Drawing.Point(48, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(310, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServiceListBox);
            this.groupBox2.Location = new System.Drawing.Point(429, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(310, 419);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.ItemHeight = 25;
            this.ServiceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.ServiceListBox.Location = new System.Drawing.Point(28, 44);
            this.ServiceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.Size = new System.Drawing.Size(256, 354);
            this.ServiceListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChargedListBox);
            this.groupBox3.Location = new System.Drawing.Point(810, 40);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(310, 419);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // ChargedListBox
            // 
            this.ChargedListBox.Enabled = false;
            this.ChargedListBox.FormattingEnabled = true;
            this.ChargedListBox.ItemHeight = 25;
            this.ChargedListBox.Location = new System.Drawing.Point(28, 44);
            this.ChargedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChargedListBox.Name = "ChargedListBox";
            this.ChargedListBox.Size = new System.Drawing.Size(254, 354);
            this.ChargedListBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PriceListBox);
            this.groupBox4.Location = new System.Drawing.Point(1191, 40);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(186, 419);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // PriceListBox
            // 
            this.PriceListBox.Enabled = false;
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 25;
            this.PriceListBox.Location = new System.Drawing.Point(24, 44);
            this.PriceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(138, 354);
            this.PriceListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1029, 512);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Price:";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Enabled = false;
            this.TotalPriceTextBox.Location = new System.Drawing.Point(1173, 510);
            this.TotalPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(204, 31);
            this.TotalPriceTextBox.TabIndex = 6;
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Location = new System.Drawing.Point(404, 583);
            this.AddServiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(242, 65);
            this.AddServiceButton.TabIndex = 7;
            this.AddServiceButton.Text = "Add Service";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(654, 583);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(242, 65);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Total Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(904, 583);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(242, 65);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(460, 510);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 25);
            this.MessageLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 673);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HairDresserComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ChargedListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox PriceListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}

