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

namespace BankReconciliation.UI
{
    public partial class TestScopeIdentity : Form
    {
         SqlConnection con;
        ConnectionString cs=new ConnectionString();
         SqlCommand cmd;
        SqlDataReader rdr;
        public int newRowID; 
        public TestScopeIdentity()
        {
            InitializeComponent();
        }

        private void NewScopId()
        {
            MessageBox.Show("Successfully saved, Your scopeId is:" + newRowID, "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     public void InsertData(string Name, string roll, string contactNo)
                        
       {
    
          string query = "INSERT INTO Person (Name, Roll, ContactNo) VALUES (@Name, @Roll, @ContactNo) SELECT CONVERT(int, SCOPE_IDENTITY());";

    // create connection and command
    using (SqlConnection cn = new SqlConnection(cs.DBConn))
    using(SqlCommand cmd = new SqlCommand(query, cn))
    {
        // define parameters and their values
        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = Name;
        cmd.Parameters.Add("@Roll", SqlDbType.VarChar, 50).Value = roll;
        cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar, 50).Value = contactNo;
        
        cn.Open();
      // cmd.ExecuteNonQuery();
        newRowID = (int)cmd.ExecuteScalar();
        cn.Close();
        MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        NewScopId();
    }
}
        private void saveButton_Click(object sender, EventArgs e)
        {
            InsertData(nameTextBox.Text, rollTextBox.Text, contactNoTextBox.Text);
            //try
            //{


            //con = new SqlConnection(cs.DBConn);
            //con.Open();
            //string ct = "select CategoryName from Category where CategoryName='" + txtCategoryName.Text + "'";

            //cmd = new SqlCommand(ct);
            //cmd.Connection = con;
            //rdr = cmd.ExecuteReader();

            //if (rdr.Read())
            //{
            //    MessageBox.Show("Category Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCategoryName.Text = "";
            //    txtCategoryName.Focus();


            //    if ((rdr != null))
            //    {
            //        rdr.Close();
            //    }
            //    return;
            //}



            //con = new SqlConnection(cs.DBConn);
            //con.Open();

            //string cb = "insert into Person(Name,Roll,ContactNo) VALUES ('" + nameTextBox.Text + "','"+rollTextBox.Text+"','"+contactNoTextBox.Text+"')";

            //cmd = new SqlCommand(cb);
            //cmd.Connection = con;
            //cmd.ExecuteReader();
            //con.Close();
            //MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Autocomplete();
            //btnSave.Enabled = false;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
