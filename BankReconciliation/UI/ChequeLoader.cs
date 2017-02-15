using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReconciliation
{
    public partial class ChequeLoader : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public ChequeLoader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLBankNameCombo.Text == "")
            {
                MessageBox.Show("Please Select Bank Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLBankNameCombo.Focus();
                return;
            }
            if (cmbCAccountNo.Text == "")
            {
                MessageBox.Show("Please Select Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCAccountNo.Focus();
                return;
            }
            if (chequeStartNoTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Cheque Start Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chequeStartNoTextBox.Focus();
                return;
            }
            if (chequeEndNoTextBox.Text == "")
            {
                MessageBox.Show("You Must Enter Cheque Ending Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chequeEndNoTextBox.Focus();
                return;
            }
            UInt64 L=Convert.ToUInt64(chequeEndNoTextBox.Text);
            UInt64 F = Convert.ToUInt64(chequeStartNoTextBox.Text);
            if ((L - (F-1)) == 25 || (L - (F-1)) == 50 || (L - (F-1)) >= 100)
            {
                int i = 0;

                for (UInt64 k = Convert.ToUInt64(chequeStartNoTextBox.Text); k <= Convert.ToUInt64(chequeEndNoTextBox.Text); k++)
                {


                    ChequeManager aEmpManager = new ChequeManager();

                    Cheque aCheque = new Cheque
                    {

                        BankName = txtLBankNameCombo.Text,
                        AccountNo = cmbCAccountNo.Text,
                        CheequeNumber = k
                      



                    };

                    i = aEmpManager.SaveCheque(aCheque);
                }
                MessageBox.Show("Check Number Successfully Loaded");
                Reset();
                loadButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Checque Book is Not Conventional in Range,Please Select a Conventional Range such as 25,50 or 100");
            }
            
                


        }

        private void Reset()
        {
            txtLBankNameCombo.SelectedIndexChanged -= txtBankNameCombo_SelectedIndexChanged;
            txtLBankNameCombo.Items.Clear();
            txtLBankNameCombo.SelectedIndex = -1;
            txtLBankNameCombo.SelectedIndexChanged += txtBankNameCombo_SelectedIndexChanged;
            cmbCAccountNo.SelectedIndexChanged -= cmbAccountNo_SelectedIndexChanged;
            cmbCAccountNo.Items.Clear();
            cmbCAccountNo.SelectedIndex = -1;
            cmbCAccountNo.SelectedIndexChanged += cmbAccountNo_SelectedIndexChanged;
            chequeStartNoTextBox.Text = "";
            chequeEndNoTextBox.Text = "";
          //  statusheckBox.Checked = false;
            loadButton.Enabled = true;
            FillBank();

        }
        private void newButton_Click(object sender, EventArgs e)
        {
            //Reset();
        }

        private void ChequeLoader_Load(object sender, EventArgs e)
        {
           FillBank();
        }
        public void FillCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(AccountNo) from BankAccounts order by AccountNo";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCAccountNo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBankNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT BankAccounts.BankName from BankAccounts WHERE BankAccounts.BankName = '" + txtLBankNameCombo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    // txtAccountNo.Text = rdr.GetInt32(0).ToString().Trim();
                    //txtAccountNo.Text = rdr.GetInt64(0).ToString().Trim();
                    txtLBankNameCombo.Text = rdr.GetString(0).Trim();
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                txtLBankNameCombo.Text = txtLBankNameCombo.Text.Trim();
                cmbCAccountNo.Items.Clear();
                cmbCAccountNo.Text = "";
                cmbCAccountNo.Enabled = true;
                cmbCAccountNo.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(BankAccounts.AccountNo) from BankAccounts  Where BankAccounts.BankName= '" + txtLBankNameCombo.Text + "' ";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCAccountNo.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAccountNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    con = new SqlConnection(cs.DBConn);

            //    con.Open();
            //    cmd = con.CreateCommand();

            //    cmd.CommandText = "SELECT BankAccounts.AccountNo from BankAccounts WHERE BankAccounts.AccountNo = '" + cmbCAccountNo.Text + "'";
            //    rdr = cmd.ExecuteReader();

            //    if (rdr.Read())
            //    {
            //        txtAccountNo2.Text = rdr.GetInt32(0).ToString().Trim();
            //    }
            //    if ((rdr != null))
            //    {
            //        rdr.Close();
            //    }
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void FillBank()
        {
            try
            {


                txtLBankNameCombo.Items.Clear();
                txtLBankNameCombo.Text = "";
                txtLBankNameCombo.Enabled = true;
                txtLBankNameCombo.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select  distinct RTRIM(BankAccounts.BankName) from BankAccounts";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtLBankNameCombo.Items.Add(rdr[0]);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }
