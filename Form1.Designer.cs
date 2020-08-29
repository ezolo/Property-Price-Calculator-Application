namespace Lab_4
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
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.salesDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.hillRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.propertyPriceTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Location = new System.Drawing.Point(145, 48);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(84, 20);
            this.saleDateLabel.TabIndex = 0;
            this.saleDateLabel.Text = "Sale Date:";
            // 
            // salesDateMaskedTextBox
            // 
            this.salesDateMaskedTextBox.Location = new System.Drawing.Point(227, 48);
            this.salesDateMaskedTextBox.Mask = "00/00/0000";
            this.salesDateMaskedTextBox.Name = "salesDateMaskedTextBox";
            this.salesDateMaskedTextBox.Size = new System.Drawing.Size(114, 26);
            this.salesDateMaskedTextBox.TabIndex = 1;
            this.salesDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(6, 25);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(113, 24);
            this.residentialRadioButton.TabIndex = 3;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(6, 55);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(117, 24);
            this.commercialRadioButton.TabIndex = 4;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // hillRadioButton
            // 
            this.hillRadioButton.AutoSize = true;
            this.hillRadioButton.Checked = true;
            this.hillRadioButton.Location = new System.Drawing.Point(6, 25);
            this.hillRadioButton.Name = "hillRadioButton";
            this.hillRadioButton.Size = new System.Drawing.Size(122, 24);
            this.hillRadioButton.TabIndex = 6;
            this.hillRadioButton.TabStop = true;
            this.hillRadioButton.Text = "Hillsborough";
            this.hillRadioButton.UseVisualStyleBackColor = true;
            this.hillRadioButton.CheckedChanged += new System.EventHandler(this.hillRadioButton_CheckedChanged);
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(6, 55);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(78, 24);
            this.pascoRadioButton.TabIndex = 7;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            this.pascoRadioButton.CheckedChanged += new System.EventHandler(this.pascoRadioButton_CheckedChanged);
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.AutoSize = true;
            this.polkRadioButton.Location = new System.Drawing.Point(6, 85);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(64, 24);
            this.polkRadioButton.TabIndex = 8;
            this.polkRadioButton.Text = "Polk";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Property Price";
            // 
            // propertyPriceTextBox
            // 
            this.propertyPriceTextBox.Location = new System.Drawing.Point(212, 323);
            this.propertyPriceTextBox.Name = "propertyPriceTextBox";
            this.propertyPriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.propertyPriceTextBox.TabIndex = 10;
            this.propertyPriceTextBox.TextChanged += new System.EventHandler(this.propertyPriceTextBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(135, 370);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(177, 31);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "&Update Property Price";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "State Sales Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "County Sales Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Commission:";
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(241, 414);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(96, 23);
            this.stateSalesTaxLabel.TabIndex = 15;
            this.stateSalesTaxLabel.Text = "$0.00";
            this.stateSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(241, 452);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(96, 23);
            this.countySalesTaxLabel.TabIndex = 16;
            this.countySalesTaxLabel.Text = "$0.00";
            this.countySalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // commissionLabel
            // 
            this.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionLabel.Location = new System.Drawing.Point(241, 482);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(96, 23);
            this.commissionLabel.TabIndex = 17;
            this.commissionLabel.Text = "$0.00";
            this.commissionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(241, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 3);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(241, 538);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(96, 23);
            this.totalPriceLabel.TabIndex = 19;
            this.totalPriceLabel.Text = "$0.00";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(89, 605);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 33);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(335, 605);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 33);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(212, 605);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 33);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.residentialRadioButton);
            this.groupBox2.Controls.Add(this.commercialRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(141, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hillRadioButton);
            this.groupBox3.Controls.Add(this.pascoRadioButton);
            this.groupBox3.Controls.Add(this.polkRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(141, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "County:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 695);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.propertyPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesDateMaskedTextBox);
            this.Controls.Add(this.saleDateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.MaskedTextBox salesDateMaskedTextBox;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton hillRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox propertyPriceTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

