﻿namespace BankReconciliation.UI
{
    partial class ChequeCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeCancel));
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbAccountDNo = new System.Windows.Forms.ComboBox();
            this.chequeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.causeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Location = new System.Drawing.Point(340, 64);
            this.bankNameComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(406, 29);
            this.bankNameComboBox.TabIndex = 0;
            this.bankNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bankNameComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(290, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAccountDNo
            // 
            this.cmbAccountDNo.FormattingEnabled = true;
            this.cmbAccountDNo.Location = new System.Drawing.Point(340, 108);
            this.cmbAccountDNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbAccountDNo.Name = "cmbAccountDNo";
            this.cmbAccountDNo.Size = new System.Drawing.Size(406, 29);
            this.cmbAccountDNo.TabIndex = 2;
            this.cmbAccountDNo.SelectedIndexChanged += new System.EventHandler(this.cmbAccountDNo_SelectedIndexChanged);
            // 
            // chequeComboBox
            // 
            this.chequeComboBox.FormattingEnabled = true;
            this.chequeComboBox.Location = new System.Drawing.Point(340, 153);
            this.chequeComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chequeComboBox.Name = "chequeComboBox";
            this.chequeComboBox.Size = new System.Drawing.Size(406, 29);
            this.chequeComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(147, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(145, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(157, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cheque No ";
            // 
            // causeTextBox
            // 
            this.causeTextBox.Location = new System.Drawing.Point(340, 198);
            this.causeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.Size = new System.Drawing.Size(406, 29);
            this.causeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(157, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cause";
            // 
            // ChequeCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(987, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.causeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chequeComboBox);
            this.Controls.Add(this.cmbAccountDNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankNameComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ChequeCancel";
            this.Text = "ChequeCancel";
            this.Load += new System.EventHandler(this.ChequeCancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbAccountDNo;
        private System.Windows.Forms.ComboBox chequeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox causeTextBox;
        private System.Windows.Forms.Label label4;
    }
}