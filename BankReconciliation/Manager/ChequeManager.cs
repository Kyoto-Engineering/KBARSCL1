using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation
{
  public  class ChequeManager
    {
        private ChequeGateway ngateway;
        public int SaveCheque(Cheque aCheque)
        {
           
            ngateway = new ChequeGateway();
            return ngateway.SaveCheque(aCheque);
        }
    }
}
