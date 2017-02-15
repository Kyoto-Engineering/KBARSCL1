using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReconciliation.UI
{
    public partial class EditDepositForm : Form
    {
        public EditDepositForm()
        {
            InitializeComponent();
        }

        ChequeDiposit frm=new ChequeDiposit();

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDepositForm2  frm=new EditDepositForm2();
            frm.textBoxk.Text = showBankNameTextBox.Text;
            frm.Show();
        }
       public void GetOtherFormTextBox()
        {
            showBankNameTextBox.Text = frm.txtBankNameCombo.Text;
            //showAccountNoTextBox.Text = frm.cmbAccountDNo.Text;
          // showTransactionTypeTextBox.Text = frm.tr.Text;
        }
        private void EditDepositForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
