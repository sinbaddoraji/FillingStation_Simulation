using System;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
            LogUpdateTimer.Start();
        }

        private void LogUpdateTimer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Transactions.TransactionLog;
        }
    }
}