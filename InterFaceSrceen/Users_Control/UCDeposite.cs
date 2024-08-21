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
    public partial class UCDeposite : UserControl
    {
        public UCDeposite()
        {
            InitializeComponent();
        }

        private clsClientsBusiness Client;
        private void PutDataInLabels( )
        {
            Lb_AccountNumber.Text = "Account Number: " + Client._AccountNumber;
            Lb_FullName.Text="Full Name: "+Client._FirstName+" "+Client._MiddleName+" "+Client._LastName;
            Lb_Phone.Text = "Phone: "+Client._Phone;
            Lb_AccountBalance.Text ="Account Balance: "+Client._AccountBalance.ToString();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Txtb_AccountNumber.Text)&&!string.IsNullOrWhiteSpace(Mtxtb_Pincode.Text))
            {
                 Client=clsClientsBusiness.
                    FindAccountByAccountNumberAndPincode(Txtb_AccountNumber.Text,Mtxtb_Pincode.Text);
                if(Client != null) 
                {
                    PutDataInLabels();
                }
                else
                {
                    MessageBox.Show("NOT FOUND","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("=Please Enter Account Number & Pincode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Deposite_Click(object sender, EventArgs e)
        {
            double DepositeAmount = Convert.ToDouble(Mtxtb_Deposite.Text);
            if (Mtxtb_Deposite.Text != null && DepositeAmount < 500000)
            {
                clsClientTransactions.AddTransactionRecord(Client._ID, Client._AccountNumber,
                    "Deposite", "", DateTime.Now,DepositeAmount);
                Client.Deposite(DepositeAmount);               
                MessageBox.Show("Deposited Succssfully Account Balance: " + Client._AccountBalance, "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Client.Update())
                {
                    PutDataInLabels();
                }               

            }
            else
            {
                MessageBox.Show("Please Enter Deposite amount or Deposite Amount Bigger than 500000",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}
