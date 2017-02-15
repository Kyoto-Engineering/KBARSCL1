using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation
{
    class ChequeGateway : ConnectionGateway
    {
        public int SaveCheque(Cheque aCheque)
        {
            connection.Open();
            string insertEQuery = "insert into ChequeLoad (BankName,AccountNo,CheckNo,Status) Values('" + aCheque.BankName + "','" + aCheque.AccountNo + "','" + aCheque.CheequeNumber + "','" + aCheque.Status + "')";
            SqlCommand comnd = new SqlCommand(insertEQuery, connection);
            int affectedRows = comnd.ExecuteNonQuery();
            connection.Close();
            return affectedRows;
        }

    }
}
