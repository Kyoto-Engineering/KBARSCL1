﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReconciliation.UI
{
    public partial class EditDepositForm2 : Form
    {
        public EditDepositForm2()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDepositForm fg=new EditDepositForm();
            fg.showBankNameTextBox.Text = textBoxk.Text;
            fg.Show();

        }
    }
}
