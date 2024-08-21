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
    public partial class UCUpdate : UserControl
    {

        private clsClientsBusiness Client;
        public UCUpdate(int ClientID=0)
        {
            InitializeComponent();
            if(ClientID!=0)
            {
                Mtxtb_SearchByID.Text = ClientID.ToString();
                Btn_SearchByID_Click(this, new EventArgs());
            }
        }

        private void PutClientData(clsClientsBusiness client)
        {
            Lb_ClientID.Text = "Client ID:" + client._ID.ToString();
            Lb_AccountNumber.Text = "Account Number: " + client._AccountNumber.ToString();
            Lb_AccountBalance.Text ="Account Balance: "+ client._AccountBalance.ToString();
            Txtb_Address.Text= client._Address;
            Txtb_Email.Text = client._Email;
            Txtb_FirstName.Text = client._FirstName;
            Txtb_Middle.Text = client._MiddleName;
            Txtb_Phone.Text = client._Phone;
            Txtb_LastName.Text = client._LastName;
            Mtxtb_NationalID.Text = client._NationalID;
            Mtxtb_Pincode.Text = client._Pincode.ToString();
            dateTimePicker1.Text=client._BirthDate.ToString();
        }

        private void UpdateClientData() 
        {
            Client._FirstName=Txtb_FirstName.Text;
            Client._MiddleName = Txtb_Middle.Text;
            Client._LastName= Txtb_LastName.Text;
            Client._Address=Txtb_Address.Text;
            Client._BirthDate =Convert.ToDateTime( dateTimePicker1.Text);
            Client._NationalID=Mtxtb_NationalID.Text;
            Client._Email=Txtb_Email.Text;
            Client._Phone=Txtb_Phone.Text;
            Client._Pincode =Mtxtb_Pincode.Text;           
        }

        private void Btn_SearchByID_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Mtxtb_SearchByID.Text))
            {
                Client = clsClientsBusiness.FindClientByID(Convert.ToInt32(Mtxtb_SearchByID.Text));
                if (Client != null)
                {
                    Btn_Update.Enabled = true;
                    PutClientData(Client);
                }
                else
                    MessageBox.Show("NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_SearchByName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_FullName.Text))
            {
                var FullName = Txt_FullName.Text.Split(' ');
                Client = clsClientsBusiness.FindClientByFullName(FullName);
                if (Client != null)
                {
                    Btn_Update.Enabled = true;
                    PutClientData(Client);
                    
                }
                else
                    MessageBox.Show("NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Update this Client", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                UpdateClientData();
                if(Client.Update())
                {
                    MessageBox.Show("Updated Successfully", "Information");
                    Pan_Main.Visible = false;
                    Btn_Update.Enabled = false;
                }
                
            }

        }
        
    }
        
}
