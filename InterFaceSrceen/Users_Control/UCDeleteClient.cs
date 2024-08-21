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
    public partial class UCDeleteClient : UserControl
    {
        private int ID = 0;
        public UCDeleteClient()
        {
            InitializeComponent();
        }

        private void PutClientData(clsClientsBusiness client)
        {
            Lb_AccountBalance.Text="Account Balance: "+client._AccountBalance.ToString();
            Lb_ClientID.Text="Client ID:"+client._ID.ToString();
            Lb_FirstName.Text="First Name: "+client._FirstName.ToString();
            Lb_MiddleName.Text="Middle Name: "+client._MiddleName.ToString();
            Lb_LastName.Text="Last Name: "+client._LastName.ToString();
            Lb_Address.Text="Address: "+client._Address.ToString();
            Lb_BirthDate.Text="Bith Date: "+client._BirthDate.ToString();
            Lb_NationalID.Text="National ID: "+client._NationalID.ToString();
            Lb_Phone.Text="Phone: "+client._Phone.ToString();
            Lb_Email.Text="Email: "+client._Email.ToString();
            Lb_AccountNumber.Text="Account Number: "+client._AccountNumber.ToString();
            Lb_Pincode.Text="Pincode: "+client._Pincode.ToString();
        }

        private void Btn_SearchByID_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Mtxtb_SearchByID.Text)) 
            {
                clsClientsBusiness Client = clsClientsBusiness.FindClientByID(Convert.ToInt32(Mtxtb_SearchByID.Text));
                if (Client != null)
                {
                    Btn_Delete.Enabled = true;
                    PutClientData(Client);
                    ID = Client._ID;
                }
                else 
                    MessageBox.Show("NOT FOUND","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Btn_SearchByName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_FullName.Text))
            {
                var FullName = Txt_FullName.Text.Split(' ');
                clsClientsBusiness Client=clsClientsBusiness.FindClientByFullName(FullName);
                if (Client != null)
                {
                    Btn_Delete.Enabled=true;
                    PutClientData(Client);
                    ID = Client._ID; 
                    
                }
                else
                    MessageBox.Show("NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Client","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (clsClientsBusiness.Delete(ID))
                    MessageBox.Show("Deleted Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed To Delete", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Pan_Main.Visible = false;
                Btn_Delete.Enabled= false;                
            }
            
        }
    }
}
