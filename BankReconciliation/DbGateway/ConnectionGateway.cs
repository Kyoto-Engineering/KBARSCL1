﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation
{
   public class ConnectionGateway
    {
        
       protected SqlConnection connection;

         public ConnectionGateway()
        {

           // string connectionString = @"Data Source=DESKTOP-TQ74LPH\SQLSERVER2018;Initial Catalog=BankReconciliationDB;User=sa;Password=SystemAdministrator;Persist Security Info=True;";
            string connectionString = @"Data Source=tcp:KyotoServer,49172;Initial Catalog=BankReconciliationDB67;User=sa;Password=SystemAdministrator;Persist Security Info=True;";
         //  string connectionString = @"Data Source=tcp:KyotoServer,49172;Initial Catalog=BankReconciliationDB;User=sa;Password=SystemAdministrator;Persist Security Info=True;";
          
            connection = new SqlConnection(connectionString);
        }
    }
}
