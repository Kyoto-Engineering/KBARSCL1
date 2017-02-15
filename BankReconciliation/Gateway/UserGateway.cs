using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankReconciliation.DAO;

namespace BankReconciliation.Gateway
{
    public class UserGateway : ConnectionGateway
    {
        private SqlCommand cmd;
        //private SqlDataReader rdr;

        public int SaveUser(User nUser)
        {
            connection.Open();
            string insertquery = " insert into Registration(UserName,UserType,Passwords,Name,ContactNo) Values('" + nUser.UserName + "','" + nUser.UserType + "','" + nUser.Password + "','" + nUser.Name + "','" + nUser.ContactNumber + "')";
            cmd = new SqlCommand(insertquery, connection);
            int affectedrows = cmd.ExecuteNonQuery();
            connection.Close();
            return affectedrows;
        }

        //public int Saveuser2(User nUser)
        //{

        //    try
        //    {

        //        connection.Open();
        //        string ct = "select Name from Registration where UserName='" + nUser.UserName + "'";

        //        cmd = new SqlCommand(ct);
        //        cmd.Connection = connection;
        //        rdr = cmd.ExecuteReader();

        //        if (rdr.Read())
        //        {
        //            MessageBox.Show("User Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            nUser.UserName = "";


        //            if ((rdr != null))
        //            {
        //                rdr.Close();
        //            }

        //        }



        //        connection = new SqlConnection();
        //        connection.Open();

        //        string insertquery = " insert into Registration(UserName,UserType,Passwords,Name,ContactNo) Values('" +
        //                             nUser.UserName + "','" + nUser.UserType + "','" + nUser.Password + "','" +
        //                             nUser.Name +
        //                             "','" + nUser.ContactNumber + "')";

        //        cmd = new SqlCommand(insertquery);
        //        cmd.Connection = connection;
        //        cmd.ExecuteReader();
        //        connection.Close();
        //        MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        //Autocomplete();
        //        //btnSave.Enabled = false;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}
    }
}