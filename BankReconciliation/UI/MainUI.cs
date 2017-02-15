﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BankReconciliation.DAO;
using BankReconciliation.LoginUI;
using BankReconciliation.Reports;
using BankReconciliation.UI;

namespace BankReconciliation
{
    public partial class MainUI : Form
    {
        ToolStripStatusLabel ToolStripStatusLabel4=new ToolStripStatusLabel();
        public MainUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic ww=new  Withdraw();
            this.Visible = false;
            ww.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic dd=new ChequeDiposit();
            this.Visible = false;
            dd.ShowDialog();
            this.Visible = true;
        }

        private void addNewBankButton_Click(object sender, EventArgs e)
        {
            dynamic d=new BankDetailsInfo();
            this.Visible = false;
            d.ShowDialog();
            this.Visible = true;

        }

        private void checkLoadingButton_Click(object sender, EventArgs e)
        {
            dynamic f2=new UI.Cheque();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ToolStripStatusLabel4.Text = System.DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            LoginForm frm = new LoginForm();
            this.Dispose();
            frm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
           //Registration d = new Registration();
           //           d.Show();
            //dynamic d = new UserRegistrationForm();
            //this.Visible = false;
            //d.ShowDialog();
            //this.Visible = true;
            UserRegistrationForm frm = new UserRegistrationForm();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAbout frm=new frmAbout();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BankStatements x = new BankStatements();
            this.Visible = false;
            x.ShowDialog();
            this.Visible = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
