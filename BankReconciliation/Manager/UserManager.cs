using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReconciliation.DAO;
using BankReconciliation.Gateway;

namespace BankReconciliation.Manager
{
   public class UserManager
   {
        UserGateway aGateway;
        public  int SaveUser(User nUser)
        {
            aGateway=new UserGateway();
            return aGateway.SaveUser(nUser);
        }
    }
}
