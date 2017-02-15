using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation
{
    public class Cheque
    {
        private int id;
        private string bankName;
        private string accountNo;
        private UInt64 chequeNumber;
        private Boolean status;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        public string AccountNo
        {
            set { accountNo = value; }
            get { return accountNo; }
        }
        public UInt64 CheequeNumber
        {
            get{ return chequeNumber;}
            set { chequeNumber = value; }
        }

        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }

        

    }
}
