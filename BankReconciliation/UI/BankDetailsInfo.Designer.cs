﻿namespace BankReconciliation.UI
{
    partial class BankDetailsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankDetailsInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bankShortNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accountTitleTextBox = new System.Windows.Forms.TextBox();
            this.typeOfAccountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBankNameCombo = new System.Windows.Forms.ComboBox();
            this.initialBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bankShortNameTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.accountTitleTextBox);
            this.groupBox1.Controls.Add(this.typeOfAccountTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBankNameCombo);
            this.groupBox1.Controls.Add(this.initialBalanceTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.accountNoTextBox);
            this.groupBox1.Controls.Add(this.branchNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Magenta;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Bank Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "(Six Character Max)";
            // 
            // bankShortNameTextBox
            // 
            this.bankShortNameTextBox.Location = new System.Drawing.Point(223, 68);
            this.bankShortNameTextBox.MaxLength = 6;
            this.bankShortNameTextBox.Name = "bankShortNameTextBox";
            this.bankShortNameTextBox.Size = new System.Drawing.Size(235, 29);
            this.bankShortNameTextBox.TabIndex = 1;
            this.bankShortNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bankShortNameTextBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bank Short Name";
            // 
            // accountTitleTextBox
            // 
            this.accountTitleTextBox.Location = new System.Drawing.Point(223, 188);
            this.accountTitleTextBox.Name = "accountTitleTextBox";
            this.accountTitleTextBox.Size = new System.Drawing.Size(235, 29);
            this.accountTitleTextBox.TabIndex = 5;
            this.accountTitleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountTitleTextBox_KeyDown);
            // 
            // typeOfAccountTextBox
            // 
            this.typeOfAccountTextBox.Location = new System.Drawing.Point(223, 148);
            this.typeOfAccountTextBox.Name = "typeOfAccountTextBox";
            this.typeOfAccountTextBox.Size = new System.Drawing.Size(235, 29);
            this.typeOfAccountTextBox.TabIndex = 4;
            this.typeOfAccountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typeOfAccountTextBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account  Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type  of  Account";
            // 
            // txtBankNameCombo
            // 
            this.txtBankNameCombo.FormattingEnabled = true;
            this.txtBankNameCombo.Items.AddRange(new object[] {
            "AB Bank Limited",
            "Agrani Bank Limited",
            "Al-Arafah Islami Bank Limited ",
            "Bangladesh Commerce Bank Limited",
            "Bangladesh Development Bank Limited",
            "Bangladesh Krishi Bank Limited",
            "Bank Al-Falah",
            "Bank Asia Limited",
            "BASIC Bank Limited",
            "BRAC Bank Limited",
            "Citibank NA",
            "Commercial Bank of Ceylon",
            "Dhaka Bank Limited",
            "Dutch Bangla Bank Limited",
            "Eastern Bank Limited",
            "Export Import Bank of Bangladesh Limited",
            "First Security Islami Bank Limited",
            "Habib Bank Limited",
            "HSBC (The Hong Kong and Shanghai Banking Corporation Ltd.)",
            "ICB Islamic Bank Limited",
            "IFIC Bank Limited",
            "Islami Bank Bangladesh Limited",
            "Jamuna Bank Limited",
            "Janata Bank Limited",
            "Meghna Bank Limited",
            "Mercantile Bank Limited",
            "Midland Bank Limited",
            "Modhumoti Bank Limited",
            "Mutual Trust Bank Limited",
            "National Bank of Pakistan",
            "National Bank Limited",
            "NCC Bank Limited",
            "NRB Bank Limited",
            "NRB Commercial Bank Limited",
            "NRB Global Bank Limited",
            "One Bank Limited",
            "Prime Bank Limited",
            "Pubali Bank Limited",
            "Rajshahi Krishi Unnoyon Bank (RKUB)",
            "Rupali Bank Limited",
            "Shahjalal islami Bank Limited",
            "Social Islami Bank Limited ",
            "Sonali Bank Limited ",
            "South Bangla Agriculture and Commerce Bank Limited ",
            "Southeast Bank Limited ",
            "Standard Bank Limited",
            "Standard Chartered Bank",
            "State Bank of India",
            "The City Bank Limited",
            "The Farmers Bank Limited",
            "The Premier Bank Limited",
            "Trust Bank Limited",
            "United Commercial Bank Limited",
            "Uttara Bank Limited ",
            "Union Bank Limited",
            "Woori Bank"});
            this.txtBankNameCombo.Location = new System.Drawing.Point(223, 28);
            this.txtBankNameCombo.Name = "txtBankNameCombo";
            this.txtBankNameCombo.Size = new System.Drawing.Size(235, 29);
            this.txtBankNameCombo.TabIndex = 0;
            this.txtBankNameCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankNameCombo_KeyDown);
            // 
            // initialBalanceTextBox
            // 
            this.initialBalanceTextBox.Location = new System.Drawing.Point(223, 275);
            this.initialBalanceTextBox.Name = "initialBalanceTextBox";
            this.initialBalanceTextBox.Size = new System.Drawing.Size(235, 29);
            this.initialBalanceTextBox.TabIndex = 7;
            this.initialBalanceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.initialBalanceTextBox_KeyDown);
            this.initialBalanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initialBalanceTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Initial Balance";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.Navy;
            this.createButton.Location = new System.Drawing.Point(302, 325);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(132, 53);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(223, 230);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(235, 29);
            this.accountNoTextBox.TabIndex = 6;
            this.accountNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountNoTextBox_KeyDown);
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.Location = new System.Drawing.Point(223, 110);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(235, 29);
            this.branchNameTextBox.TabIndex = 2;
            this.branchNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.branchNameTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branch Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // BankDetailsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(750, 426);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankDetailsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankDetailsInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox branchNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialBalanceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtBankNameCombo;
        private System.Windows.Forms.TextBox accountTitleTextBox;
        private System.Windows.Forms.TextBox typeOfAccountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bankShortNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}