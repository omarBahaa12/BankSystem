using ClientsBusinessTier;
using ClientTransactionsBusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBusinessTier;

namespace InterFaceSrceen.Users_Control
{
    public partial class UCTransfer : UserControl
    {
        public UCTransfer()
        {
            InitializeComponent();
        }

        private bool CheckTransferfromAndTransferTo()
        {
            if(!string.IsNullOrWhiteSpace(Txtb_TransferFrom.Text)) 
            { 
                if(!string.IsNullOrWhiteSpace(Txtb_TransferTo.Text)) 
                {
                    if (!string.IsNullOrWhiteSpace(Mtxtb_AmountofTransfer.Text))
                        return true;
                }
            }
            return false;
        }
        private clsClientsBusiness GetClientAccount(string AccountNumber)
        {
            return clsClientsBusiness.FindAccountByAccountNumber(AccountNumber);
        }
        private bool Transfer(clsClientsBusiness ClientTransferto,clsClientsBusiness ClientTransferfrom,double AmountTransfer)
        {
            if (ClientTransferfrom.Withdraw(AmountTransfer))
            {
                ClientTransferto.Deposite(AmountTransfer);
                clsClientTransactions.AddTransactionRecord(ClientTransferfrom._ID, ClientTransferfrom._AccountNumber,
                    "Transfer To", "Transfer to " + ClientTransferto._AccountNumber, DateTime.Now, AmountTransfer);
                clsClientTransactions.AddTransactionRecord(ClientTransferto._ID, ClientTransferto._AccountNumber,
                    "Transfer From", "Transfer From " + ClientTransferfrom._AccountNumber, DateTime.Now, AmountTransfer);
                if (ClientTransferfrom.Update())
                {
                    if (ClientTransferto.Update())
                    {
                        MessageBox.Show("Transfer Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Transfer.Enabled = false;
                        Txtb_TransferFrom.Text = "";
                        Txtb_TransferTo.Text = "";
                        Mtxtb_AmountofTransfer.Text = "";
                        return true;
                    }
                    else
                        MessageBox.Show("Failed to Update Client Transfer to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Failed to Update Client Transfer from", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Client Transfer from's Account Balance Can't afford this Transactions",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }
        private void CheckBeforeTransfer(clsClientsBusiness ClientTransferto,clsClientsBusiness ClientTransferfrom, double AmountTransfer)
        {
            if (ClientTransferto != null && ClientTransferfrom != null)
            {
                if (ClientTransferfrom._AccountNumber == ClientTransferto._AccountNumber)
                {
                    MessageBox.Show("Can't Transfer Money to the same Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (AmountTransfer <= 50000)
                    {
                        if (Transfer(ClientTransferto, ClientTransferfrom, AmountTransfer))
                            return;

                    }
                }
            }
            else if(ClientTransferto == null)
            {
                MessageBox.Show("Account Number Transfer to isn't Correct","Failed",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Account Number Transfer from isn't Correct", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void Btn_Transfer_Click(object sender, EventArgs e)
        {
            if(CheckTransferfromAndTransferTo())
            {
                double AmountTransfer = Convert.ToDouble(Mtxtb_AmountofTransfer.Text);
                clsClientsBusiness ClientTransferto = GetClientAccount(Txtb_TransferTo.Text);
                clsClientsBusiness ClientTransferfrom = GetClientAccount(Txtb_TransferFrom.Text);
                CheckBeforeTransfer(ClientTransferto, ClientTransferfrom,AmountTransfer);
            }
            else
            {
                MessageBox.Show("Please enter Account Number Transfer from,to and Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
