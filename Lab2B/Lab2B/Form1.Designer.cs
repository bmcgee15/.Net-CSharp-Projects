namespace Lab2B
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
            this.hairDresserGroup = new System.Windows.Forms.GroupBox();
            this.lauraRenkinsRadio = new System.Windows.Forms.RadioButton();
            this.suePallonRadio = new System.Windows.Forms.RadioButton();
            this.janeSamleyRadio = new System.Windows.Forms.RadioButton();
            this.ronChambersRadio = new System.Windows.Forms.RadioButton();
            this.patJohnsonRadio = new System.Windows.Forms.RadioButton();
            this.servicesGroup = new System.Windows.Forms.GroupBox();
            this.extensionsCheckBox = new System.Windows.Forms.CheckBox();
            this.colourCheckBox = new System.Windows.Forms.CheckBox();
            this.highlightsCheckBox = new System.Windows.Forms.CheckBox();
            this.cutCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeGroup = new System.Windows.Forms.GroupBox();
            this.seniorRadio = new System.Windows.Forms.RadioButton();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.childRadio = new System.Windows.Forms.RadioButton();
            this.adultRadio = new System.Windows.Forms.RadioButton();
            this.visitsGroup = new System.Windows.Forms.GroupBox();
            this.clientNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientNumberLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalResultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.hairDresserGroup.SuspendLayout();
            this.servicesGroup.SuspendLayout();
            this.clientTypeGroup.SuspendLayout();
            this.visitsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairDresserGroup
            // 
            this.hairDresserGroup.Controls.Add(this.lauraRenkinsRadio);
            this.hairDresserGroup.Controls.Add(this.suePallonRadio);
            this.hairDresserGroup.Controls.Add(this.janeSamleyRadio);
            this.hairDresserGroup.Controls.Add(this.ronChambersRadio);
            this.hairDresserGroup.Controls.Add(this.patJohnsonRadio);
            this.hairDresserGroup.Location = new System.Drawing.Point(35, 38);
            this.hairDresserGroup.Name = "hairDresserGroup";
            this.hairDresserGroup.Size = new System.Drawing.Size(446, 344);
            this.hairDresserGroup.TabIndex = 4;
            this.hairDresserGroup.TabStop = false;
            this.hairDresserGroup.Text = "Hairdresser";
            this.hairDresserGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lauraRenkinsRadio
            // 
            this.lauraRenkinsRadio.AutoSize = true;
            this.lauraRenkinsRadio.Location = new System.Drawing.Point(46, 276);
            this.lauraRenkinsRadio.Name = "lauraRenkinsRadio";
            this.lauraRenkinsRadio.Size = new System.Drawing.Size(182, 29);
            this.lauraRenkinsRadio.TabIndex = 4;
            this.lauraRenkinsRadio.TabStop = true;
            this.lauraRenkinsRadio.Text = "Laura Renkins";
            this.lauraRenkinsRadio.UseVisualStyleBackColor = true;
            this.lauraRenkinsRadio.CheckedChanged += new System.EventHandler(this.lauraRenkinsRadio_CheckedChanged);
            // 
            // suePallonRadio
            // 
            this.suePallonRadio.AutoSize = true;
            this.suePallonRadio.Location = new System.Drawing.Point(46, 218);
            this.suePallonRadio.Name = "suePallonRadio";
            this.suePallonRadio.Size = new System.Drawing.Size(147, 29);
            this.suePallonRadio.TabIndex = 3;
            this.suePallonRadio.TabStop = true;
            this.suePallonRadio.Text = "Sue Pallon";
            this.suePallonRadio.UseVisualStyleBackColor = true;
            this.suePallonRadio.CheckedChanged += new System.EventHandler(this.suePallonRadio_CheckedChanged);
            // 
            // janeSamleyRadio
            // 
            this.janeSamleyRadio.AutoSize = true;
            this.janeSamleyRadio.Location = new System.Drawing.Point(46, 46);
            this.janeSamleyRadio.Name = "janeSamleyRadio";
            this.janeSamleyRadio.Size = new System.Drawing.Size(167, 29);
            this.janeSamleyRadio.TabIndex = 0;
            this.janeSamleyRadio.Text = "Jane Samley";
            this.janeSamleyRadio.UseVisualStyleBackColor = true;
            this.janeSamleyRadio.CheckedChanged += new System.EventHandler(this.janeSamleyRadio_CheckedChanged);
            // 
            // ronChambersRadio
            // 
            this.ronChambersRadio.AutoSize = true;
            this.ronChambersRadio.Location = new System.Drawing.Point(46, 158);
            this.ronChambersRadio.Name = "ronChambersRadio";
            this.ronChambersRadio.Size = new System.Drawing.Size(186, 29);
            this.ronChambersRadio.TabIndex = 2;
            this.ronChambersRadio.TabStop = true;
            this.ronChambersRadio.Text = "Ron Chambers";
            this.ronChambersRadio.UseVisualStyleBackColor = true;
            this.ronChambersRadio.CheckedChanged += new System.EventHandler(this.ronChambersRadio_CheckedChanged);
            // 
            // patJohnsonRadio
            // 
            this.patJohnsonRadio.AutoSize = true;
            this.patJohnsonRadio.Location = new System.Drawing.Point(46, 102);
            this.patJohnsonRadio.Name = "patJohnsonRadio";
            this.patJohnsonRadio.Size = new System.Drawing.Size(163, 29);
            this.patJohnsonRadio.TabIndex = 1;
            this.patJohnsonRadio.TabStop = true;
            this.patJohnsonRadio.Text = "Pat Johnson";
            this.patJohnsonRadio.UseVisualStyleBackColor = true;
            this.patJohnsonRadio.CheckedChanged += new System.EventHandler(this.patJohnsonRadio_CheckedChanged);
            // 
            // servicesGroup
            // 
            this.servicesGroup.Controls.Add(this.extensionsCheckBox);
            this.servicesGroup.Controls.Add(this.colourCheckBox);
            this.servicesGroup.Controls.Add(this.highlightsCheckBox);
            this.servicesGroup.Controls.Add(this.cutCheckBox);
            this.servicesGroup.Location = new System.Drawing.Point(525, 38);
            this.servicesGroup.Name = "servicesGroup";
            this.servicesGroup.Size = new System.Drawing.Size(488, 344);
            this.servicesGroup.TabIndex = 5;
            this.servicesGroup.TabStop = false;
            this.servicesGroup.Text = "Services";
            // 
            // extensionsCheckBox
            // 
            this.extensionsCheckBox.AutoSize = true;
            this.extensionsCheckBox.Location = new System.Drawing.Point(44, 219);
            this.extensionsCheckBox.Name = "extensionsCheckBox";
            this.extensionsCheckBox.Size = new System.Drawing.Size(150, 29);
            this.extensionsCheckBox.TabIndex = 3;
            this.extensionsCheckBox.Text = "Extensions";
            this.extensionsCheckBox.UseVisualStyleBackColor = true;
            this.extensionsCheckBox.CheckedChanged += new System.EventHandler(this.extensionsCheckBox_CheckedChanged);
            // 
            // colourCheckBox
            // 
            this.colourCheckBox.AutoSize = true;
            this.colourCheckBox.Location = new System.Drawing.Point(44, 103);
            this.colourCheckBox.Name = "colourCheckBox";
            this.colourCheckBox.Size = new System.Drawing.Size(107, 29);
            this.colourCheckBox.TabIndex = 1;
            this.colourCheckBox.Text = "Colour";
            this.colourCheckBox.UseVisualStyleBackColor = true;
            this.colourCheckBox.CheckedChanged += new System.EventHandler(this.colourCheckBox_CheckedChanged);
            // 
            // highlightsCheckBox
            // 
            this.highlightsCheckBox.AutoSize = true;
            this.highlightsCheckBox.Location = new System.Drawing.Point(44, 162);
            this.highlightsCheckBox.Name = "highlightsCheckBox";
            this.highlightsCheckBox.Size = new System.Drawing.Size(139, 29);
            this.highlightsCheckBox.TabIndex = 2;
            this.highlightsCheckBox.Text = "Highlights";
            this.highlightsCheckBox.UseVisualStyleBackColor = true;
            this.highlightsCheckBox.CheckedChanged += new System.EventHandler(this.highlightsCheckBox_CheckedChanged);
            // 
            // cutCheckBox
            // 
            this.cutCheckBox.AutoSize = true;
            this.cutCheckBox.Location = new System.Drawing.Point(44, 46);
            this.cutCheckBox.Name = "cutCheckBox";
            this.cutCheckBox.Size = new System.Drawing.Size(77, 29);
            this.cutCheckBox.TabIndex = 0;
            this.cutCheckBox.Text = "Cut";
            this.cutCheckBox.UseVisualStyleBackColor = true;
            this.cutCheckBox.CheckedChanged += new System.EventHandler(this.cutCheckBox_CheckedChanged);
            // 
            // clientTypeGroup
            // 
            this.clientTypeGroup.Controls.Add(this.seniorRadio);
            this.clientTypeGroup.Controls.Add(this.studentRadio);
            this.clientTypeGroup.Controls.Add(this.childRadio);
            this.clientTypeGroup.Controls.Add(this.adultRadio);
            this.clientTypeGroup.Location = new System.Drawing.Point(35, 406);
            this.clientTypeGroup.Name = "clientTypeGroup";
            this.clientTypeGroup.Size = new System.Drawing.Size(446, 276);
            this.clientTypeGroup.TabIndex = 6;
            this.clientTypeGroup.TabStop = false;
            this.clientTypeGroup.Text = "Client Type";
            this.clientTypeGroup.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // seniorRadio
            // 
            this.seniorRadio.AutoSize = true;
            this.seniorRadio.Location = new System.Drawing.Point(44, 214);
            this.seniorRadio.Name = "seniorRadio";
            this.seniorRadio.Size = new System.Drawing.Size(197, 29);
            this.seniorRadio.TabIndex = 3;
            this.seniorRadio.TabStop = true;
            this.seniorRadio.Text = "Senior (over 65)";
            this.seniorRadio.UseVisualStyleBackColor = true;
            this.seniorRadio.CheckedChanged += new System.EventHandler(this.seniorRadio_CheckedChanged);
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Location = new System.Drawing.Point(44, 159);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(117, 29);
            this.studentRadio.TabIndex = 2;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.CheckedChanged += new System.EventHandler(this.studentRadio_CheckedChanged);
            // 
            // childRadio
            // 
            this.childRadio.AutoSize = true;
            this.childRadio.Location = new System.Drawing.Point(44, 108);
            this.childRadio.Name = "childRadio";
            this.childRadio.Size = new System.Drawing.Size(239, 29);
            this.childRadio.TabIndex = 1;
            this.childRadio.TabStop = true;
            this.childRadio.Text = "Child (12 and under)";
            this.childRadio.UseVisualStyleBackColor = true;
            this.childRadio.CheckedChanged += new System.EventHandler(this.childRadio_CheckedChanged);
            // 
            // adultRadio
            // 
            this.adultRadio.AutoSize = true;
            this.adultRadio.Location = new System.Drawing.Point(46, 52);
            this.adultRadio.Name = "adultRadio";
            this.adultRadio.Size = new System.Drawing.Size(185, 29);
            this.adultRadio.TabIndex = 0;
            this.adultRadio.TabStop = true;
            this.adultRadio.Text = "Standard Adult";
            this.adultRadio.UseVisualStyleBackColor = true;
            this.adultRadio.CheckedChanged += new System.EventHandler(this.adultRadio_CheckedChanged);
            // 
            // visitsGroup
            // 
            this.visitsGroup.Controls.Add(this.clientNumberTextBox);
            this.visitsGroup.Controls.Add(this.clientNumberLabel);
            this.visitsGroup.Location = new System.Drawing.Point(525, 406);
            this.visitsGroup.Name = "visitsGroup";
            this.visitsGroup.Size = new System.Drawing.Size(488, 276);
            this.visitsGroup.TabIndex = 7;
            this.visitsGroup.TabStop = false;
            this.visitsGroup.Text = "Client Visits";
            // 
            // clientNumberTextBox
            // 
            this.clientNumberTextBox.Location = new System.Drawing.Point(44, 108);
            this.clientNumberTextBox.Name = "clientNumberTextBox";
            this.clientNumberTextBox.Size = new System.Drawing.Size(400, 31);
            this.clientNumberTextBox.TabIndex = 1;
            this.clientNumberTextBox.TextChanged += new System.EventHandler(this.clientNumberTextBox_TextChanged);
            // 
            // clientNumberLabel
            // 
            this.clientNumberLabel.AutoSize = true;
            this.clientNumberLabel.Location = new System.Drawing.Point(126, 65);
            this.clientNumberLabel.Name = "clientNumberLabel";
            this.clientNumberLabel.Size = new System.Drawing.Size(236, 25);
            this.clientNumberLabel.TabIndex = 0;
            this.clientNumberLabel.Text = "Number of Client Visits:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(259, 730);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(121, 25);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // totalResultLabel
            // 
            this.totalResultLabel.AutoSize = true;
            this.totalResultLabel.Location = new System.Drawing.Point(413, 729);
            this.totalResultLabel.Name = "totalResultLabel";
            this.totalResultLabel.Size = new System.Drawing.Size(0, 25);
            this.totalResultLabel.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculateButton.Location = new System.Drawing.Point(149, 793);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(193, 73);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(426, 793);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(193, 73);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(705, 793);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(193, 73);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1050, 916);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalResultLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.visitsGroup);
            this.Controls.Add(this.clientTypeGroup);
            this.Controls.Add(this.servicesGroup);
            this.Controls.Add(this.hairDresserGroup);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hairDresserGroup.ResumeLayout(false);
            this.hairDresserGroup.PerformLayout();
            this.servicesGroup.ResumeLayout(false);
            this.servicesGroup.PerformLayout();
            this.clientTypeGroup.ResumeLayout(false);
            this.clientTypeGroup.PerformLayout();
            this.visitsGroup.ResumeLayout(false);
            this.visitsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hairDresserGroup;
        private System.Windows.Forms.GroupBox servicesGroup;
        private System.Windows.Forms.GroupBox clientTypeGroup;
        private System.Windows.Forms.GroupBox visitsGroup;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalResultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton lauraRenkinsRadio;
        private System.Windows.Forms.RadioButton suePallonRadio;
        private System.Windows.Forms.RadioButton janeSamleyRadio;
        private System.Windows.Forms.RadioButton ronChambersRadio;
        private System.Windows.Forms.RadioButton patJohnsonRadio;
        private System.Windows.Forms.CheckBox extensionsCheckBox;
        private System.Windows.Forms.CheckBox colourCheckBox;
        private System.Windows.Forms.CheckBox highlightsCheckBox;
        private System.Windows.Forms.CheckBox cutCheckBox;
        private System.Windows.Forms.RadioButton seniorRadio;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton childRadio;
        private System.Windows.Forms.RadioButton adultRadio;
        private System.Windows.Forms.TextBox clientNumberTextBox;
        private System.Windows.Forms.Label clientNumberLabel;
    }
}

