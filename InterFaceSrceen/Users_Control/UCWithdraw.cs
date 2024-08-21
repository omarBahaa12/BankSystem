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

namespace InterFaceSrceen.Users_Control
{
    public partial class UCWithdraw : UserControl
    {
        public UCWithdraw()
        {
            InitializeComponent();
        }

        private clsClientsBusiness Client;
        private void PutDataInLabels()
        {
            Lb_AccountNumber.Text = "Account Number: " + Client._AccountNumber;
            Lb_FullName.Text = "Full Name: " + Client._FirstName + " " + Client._MiddleName + " " + Client._LastName;
            Lb_Phone.Text = "Phone: " + Client._Phone;
            Lb_AccountBalance.Text = "Account Balance: " + Client._AccountBalance.ToString();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Txtb_AccountNumber.Text)&&!string.IsNullOrWhiteSpace(Mtxtb_Pincode.Text))
            {
                Client = clsClientsBusiness.FindAccountByAccountNumberAndPincode(Txtb_AccountNumber.Text
                    , Mtxtb_Pincode.Text);
                if( Client != null ) 
                {
                    PutDataInLabels();
                }
                else
                {
                    MessageBox.Show("NOT FOUND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Account number & pincode", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Btn_Withdraw_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Mtxtb_Deposite.Text))
            {
                double WithdrawAmount=Convert.ToDouble(Mtxtb_Deposite.Text);
                if (WithdrawAmount <= 50000)
                {
                    if (Client.Withdraw(WithdrawAmount))
                    {
                        clsClientTransactions.AddTransactionRecord(Client._ID, Client._AccountNumber,
                            "Withdraw", "", DateTime.Now, WithdrawAmount);
                        MessageBox.Show("Withdraw Operation Done Succssfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PutDataInLabels();
                        Client.Update();
                    }
                    else
                    {
                        MessageBox.Show("Withdraw Amount Bigger than Account Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                    MessageBox.Show("Withdraw Amount Bigger than 50000", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please Enter Withdraw Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mtxtb_Deposite.Focus();
            }
        }
    }
}
