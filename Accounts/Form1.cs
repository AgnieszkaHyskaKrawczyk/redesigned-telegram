using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Account petersAccount = new Account("123457/8765", "Peter");

            petersAccount.Increase(2000);

            bool firstWithdrawal = petersAccount.Decrease(500);
            bool secondWithdrawal = petersAccount.Decrease(5000);

            MessageBox.Show(
                "Account Number: " + petersAccount.accNumber + Environment.NewLine +
                "Account Owner: " + petersAccount.accOwner + Environment.NewLine +
                "1st Withdrawal: " + firstWithdrawal.ToString() + Environment.NewLine +
                "2nd Withdrawal: " + secondWithdrawal.ToString() + Environment.NewLine +
                "Total Balance: " + petersAccount.accBalance.ToString() + Environment.NewLine
                );
        }
    }
}
