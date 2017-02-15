using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReconciliation.DAO;
using BankReconciliation.Gateway;

namespace BankReconciliation.Manager
{
  public   class BankDetailsManager
  {
      BankDetailsGateway aGateway;


     public  int SaveBankdetails(BankAccounts aBankDetails)
      {
          aGateway=new BankDetailsGateway();
        return aGateway.SaveBankdetails(aBankDetails);
      }
  }
}
