﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BankReconciliation.Reports
{
    public partial class Benificiary : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        private delegate void ChangeFocusDelegate(Control ctl);
        public Benificiary()
        {
            InitializeComponent();
        }

        private void changeFocus(Control ctl)
        {
            ctl.Focus();
        }
        private void Benificiary_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
               // string ct = "select distinct RTRIM(Transactions.Benificiary) from Transactions  Where Transactions.Debit is not NULL";
                string ct = "select Benificiary  from BenificiaryInfo ";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   benifiComboBox.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(benifiComboBox.Text))
            {
                MessageBox.Show("Select Benificiary First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ReportViewer f2 = new ReportViewer();
                ParameterField paramField = new ParameterField();

                //creating an object of ParameterFields class
                ParameterFields paramFields = new ParameterFields();

                //creating an object of ParameterDiscreteValue class
                ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                //set the parameter field name
                paramField.Name = "Benificiary Name";

                //set the parameter value
                paramDiscreteValue.Value = benifiComboBox.Text;

                //add the parameter value in the ParameterField object
                paramField.CurrentValues.Add(paramDiscreteValue);

                //add the parameter in the ParameterFields object
                paramFields.Add(paramField);

                //set the parameterfield information in the crystal report
                TableLogOnInfos reportLogonInfos = new TableLogOnInfos();
                TableLogOnInfo reportLogonInfo = new TableLogOnInfo();
                ConnectionInfo reportConInfo = new ConnectionInfo();
                Tables tables = default(Tables);
                //	Table table = default(Table);
                var with1 = reportConInfo;
                with1.ServerName = "tcp:KyotoServer,49172";
                with1.DatabaseName = "BankReconciliationDB";
                with1.UserID = "sa";
                with1.Password = "SystemAdministrator";
                BenificiaryPaymentStatementCrystalReport cr = new BenificiaryPaymentStatementCrystalReport();
                tables = cr.Database.Tables;
                foreach (Table table in tables)
                {
                    reportLogonInfo = table.LogOnInfo;
                    reportLogonInfo.ConnectionInfo = reportConInfo;
                    table.ApplyLogOnInfo(reportLogonInfo);
                }
                f2.crystalReportViewer1.ParameterFieldInfo = paramFields;
                f2.crystalReportViewer1.ReportSource = cr;
                this.Visible = false;

                f2.ShowDialog();
                this.Visible = true;
            }
            
        }

        private void benifiComboBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(benifiComboBox.Text) && !benifiComboBox.Items.Contains(benifiComboBox.Text))
            {
                MessageBox.Show("Please Select A Valid Benificiary Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                benifiComboBox.ResetText();
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), benifiComboBox);
            }
        }

        
        
        }
    }
