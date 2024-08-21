using ClientsBusinessTier;
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
    public partial class UCAddClient : UserControl
    {
        public UCAddClient()
        {
            InitializeComponent();
        }

        private void UCAddClient_Load(object sender, EventArgs e)
        {
            Pan_ContactInfo.Enabled = false;
            Pan_Accountinfo.Enabled = false;
        }

        private void Txtb_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Txtb_FirstName.Text)) 
            {
                e.Cancel = true;
                Txtb_FirstName.Focus();
                errorProvider1.SetError(Txtb_FirstName, "Should Have Value");
                return;
            }
        }

        private void Txtb_LastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtb_LastName.Text))
            {
                e.Cancel = true;
                Txtb_LastName.Focus();
                errorProvider1.SetError(Txtb_LastName, "Should Have Value");
                return;
            }
        }

        private void Txtb_Address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtb_Address.Text))
            {
                e.Cancel = true;
                Txtb_Address.Focus();
                errorProvider1.SetError(Txtb_Address, "Should Have Value");
                return;
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker1 == null) 
            {
                e.Cancel = true;
                dateTimePicker1.Focus();
                errorProvider1.SetError(dateTimePicker1, "Should Have Value");
                return;
            }
        }

        private void Mtxtb_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Mtxtb_NationalID.Text))
            {
                e.Cancel = true;
                Mtxtb_NationalID.Focus();
                errorProvider1.SetError(Mtxtb_NationalID, "Should Have Value");
                return;
            }
        }

        private bool CheckBeforeSave(Panel panel)
        {
            foreach(TextBox box in panel.Controls.OfType<TextBox>())
            {
                if(box.Text =="")
                    return false;
            }
            foreach (MaskedTextBox maskedTextBox in panel.Controls.OfType<MaskedTextBox>())
            {
                if(maskedTextBox.Text =="")
                    return false;
            }
            return true;
        }

        private void Btn_SavePersonalInfo_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave(Pan_PersonalInfo)&&!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                Pan_ContactInfo.Enabled = true;
            }
            else 
            {
                MessageBox.Show("One of Data Don't Have Value","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Btn_SaveContactInfo_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave(Pan_ContactInfo))
            {
                Pan_Accountinfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("One of Data Don't Have Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SaveAccountInformation_Click(object sender, EventArgs e)
        {
            clsClientsBusiness Client = new clsClientsBusiness(0,Txtb_FirstName.Text,Txtb_Middle.Text,Txtb_LastName.Text
                ,Txtb_Email.Text,Txtb_Address.Text,Txtb_Phone.Text,Convert.ToDateTime(dateTimePicker1.Text),
                Mtxtb_NationalID.Text,Mtxtb_Pincode.Text,
                Convert.ToDouble(Txtb_AccountBalance.Text));

            if(Client.AddClient())
            {
                MessageBox.Show("Added Succssfully \nClient ID: "+ Client._ID+"\n AccountNumber: "+Client._AccountNumber, "Information");
                Lb_ClientID.Text = "Client ID: " + Client._ID.ToString();
                Lb_AccountNumber.Text ="Account Number: "+ Client._AccountNumber;
                Pan_Accountinfo.Enabled = false;
                Pan_ContactInfo.Enabled = false;
                Pan_PersonalInfo.Enabled = false;

            }
            else
            {
                MessageBox.Show("Failed to Add","Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        
    }
}
