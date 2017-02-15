using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReconciliation.DAO;

namespace BankReconciliation.Gateway
{
  public   class BankDetailsGateway:ConnectionGateway
    {


        public int  SaveBankdetails(BankAccounts aBankDetails)
        {
            connection.Open();
            string insertquery = "insert into BankAccounts(AccountNo,BankName,ShortName,BranchName,TypeOfAccount,AccountTitle,Balance) values('" + aBankDetails.AccountNumber + "','" + aBankDetails.BankName + "','"+aBankDetails.BankShortName+"','" + aBankDetails.BranchName + "','" + aBankDetails.TypeOfAccount + "','" + aBankDetails.AccountTitle + "','" + aBankDetails.Balance + "')";
            SqlCommand cmd = new SqlCommand(insertquery, connection);
            int affectedrows = cmd.ExecuteNonQuery();
            connection.Close();
            return affectedrows;
        }
    }
}
