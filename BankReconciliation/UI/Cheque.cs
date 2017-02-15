using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankReconciliation.Reports;

namespace BankReconciliation.UI
{
    public partial class Cheque : Form
    {
        public Cheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dynamic d = new ChequeLoader();
            this.Visible = false;
            d.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChequePrint f2 = new ChequePrint();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeStatusofCheque f2 = new ChangeStatusofCheque();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChequeCancel f2=new ChequeCancel();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChequeDestroy f2=new ChequeDestroy();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }
    }
}
