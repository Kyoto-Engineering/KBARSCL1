﻿namespace BankReconciliation
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.button1 = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.addNewBankButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkLoadingButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser3 = new System.Windows.Forms.Label();
            this.lblUser2 = new System.Windows.Forms.Label();
            this.lblUserk = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(6, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.MistyRose;
            this.depositButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.depositButton.Location = new System.Drawing.Point(6, 97);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(121, 57);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseMnemonic = false;
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNewBankButton
            // 
            this.addNewBankButton.BackColor = System.Drawing.Color.Snow;
            this.addNewBankButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBankButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.addNewBankButton.Location = new System.Drawing.Point(10, 19);
            this.addNewBankButton.Name = "addNewBankButton";
            this.addNewBankButton.Size = new System.Drawing.Size(117, 54);
            this.addNewBankButton.TabIndex = 0;
            this.addNewBankButton.Text = "Create Bank  Account";
            this.addNewBankButton.UseVisualStyleBackColor = false;
            this.addNewBankButton.Click += new System.EventHandler(this.addNewBankButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.checkLoadingButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addNewBankButton);
            this.groupBox1.Controls.Add(this.depositButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 576);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(10, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Bank Statements";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(10, 427);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(113, 51);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register New User ";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Ivory;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Olive;
            this.button5.Location = new System.Drawing.Point(10, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 52);
            this.button5.TabIndex = 9;
            this.button5.Text = "About";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkLoadingButton
            // 
            this.checkLoadingButton.BackColor = System.Drawing.Color.SeaShell;
            this.checkLoadingButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLoadingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkLoadingButton.Location = new System.Drawing.Point(6, 248);
            this.checkLoadingButton.Name = "checkLoadingButton";
            this.checkLoadingButton.Size = new System.Drawing.Size(117, 57);
            this.checkLoadingButton.TabIndex = 4;
            this.checkLoadingButton.Text = "Cheque";
            this.checkLoadingButton.UseVisualStyleBackColor = false;
            this.checkLoadingButton.Click += new System.EventHandler(this.checkLoadingButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(973, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "LogOut";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(393, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(354, 32);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Bank Account Reconciliation";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(287, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(598, 109);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loged In As:";
            // 
            // lblUser3
            // 
            this.lblUser3.AutoSize = true;
            this.lblUser3.Location = new System.Drawing.Point(104, 603);
            this.lblUser3.Name = "lblUser3";
            this.lblUser3.Size = new System.Drawing.Size(0, 13);
            this.lblUser3.TabIndex = 9;
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.BackColor = System.Drawing.Color.White;
            this.lblUser2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser2.Location = new System.Drawing.Point(122, 607);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(0, 15);
            this.lblUser2.TabIndex = 10;
            // 
            // lblUserk
            // 
            this.lblUserk.AutoSize = true;
            this.lblUserk.BackColor = System.Drawing.Color.White;
            this.lblUserk.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserk.Location = new System.Drawing.Point(128, 603);
            this.lblUserk.Name = "lblUserk";
            this.lblUserk.Size = new System.Drawing.Size(11, 15);
            this.lblUserk.TabIndex = 11;
            this.lblUserk.Text = "l";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::BankReconciliation.Properties.Resources.Bank_Recounciliation;
            this.ClientSize = new System.Drawing.Size(1051, 625);
            this.Controls.Add(this.lblUserk);
            this.Controls.Add(this.lblUser2);
            this.Controls.Add(this.lblUser3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button addNewBankButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button checkLoadingButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblUser3;
        private System.Windows.Forms.Label lblUser2;
        internal System.Windows.Forms.Label lblUserk;

    }
}

