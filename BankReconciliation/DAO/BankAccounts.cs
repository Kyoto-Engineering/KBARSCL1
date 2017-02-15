using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReconciliation.DAO
{
   public class BankAccounts
   {
       private string accountNumber;
       private string bankName;
       private string bankShortName;
       private string branchName;
       
       private string balance;
       private string typeOfAccount;
       private string accountTitle;



       public string AccountNumber
       {
           set { accountNumber = value; }
           get { return accountNumber; }
       }
       public string  BankName
       {
           set { bankName = value; }
           get { return bankName; }
       }

       public string BankShortName
       {
           set { bankShortName = value; }
           get { return bankShortName; }
       }
       public string BranchName
       {
           set { branchName = value; }
           get { return branchName; }
       }

       public string TypeOfAccount
       {
           get { return typeOfAccount; }
           set { typeOfAccount = value; }
       }
       public string AccountTitle
       {
           set { accountTitle = value; }
           get { return accountTitle; }
       }
       
       public string Balance
       {
           set { balance = value; }
           get { return balance; }
       }
   }
}
