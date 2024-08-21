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
    public partial class UCAddUser : UserControl
    {
        public UCAddUser()
        {
            InitializeComponent();
        }


        private int Permission;
        private string Image="";
        private void CheckedAllCheckBox(Panel panel, bool Decission=true)
        {
            
            if(Decission) 
            {
                foreach (CheckBox c in panel.Controls.OfType<CheckBox>()) 
                {
                    c.Checked = true;
                    
                }
            }
            else
            {
                foreach (CheckBox c in panel.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
            }
        }

        private void Ckbox_AllClient_CheckedChanged(object sender, EventArgs e)
        {

            if(Ckbox_AllClient.Checked) 
            {
                CheckedAllCheckBox(Pan_ManageClient);
            }
            else
            {
                CheckedAllCheckBox(Pan_ManageClient,false);
            }
        }

        private void Ckbox_AllUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_AllUser.Checked)
            {
                CheckedAllCheckBox(Pan_ManageUsers);
            }
            else
            {
                CheckedAllCheckBox(Pan_ManageUsers,false);
            }
        }

        private void Ckbox_AllTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_AllTransaction.Checked)
            {
                CheckedAllCheckBox(Pan_Transaction);
            }
            else
            {
                CheckedAllCheckBox(Pan_Transaction, false);
            }
        }
      
        private void Ckbox_ClientList_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_ClientList.Checked)
                Permission += (int)Math.Pow(2, 1);
            else
                Permission -= (int)Math.Pow(2, 1);
        }

        private void Ckbox_AddClient_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_AddClient.Checked)
                Permission += (int)Math.Pow(2, 2);
            else
                Permission-=(int)Math.Pow(2, 2);
        }

        private void Ckbox_UpdateClient_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_UpdateClient.Checked)
                Permission += (int)Math.Pow(2, 3);
            else
                Permission -= (int)Math.Pow(2, 3);
        }

        private void Ckbox_DeleteClient_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_DeleteClient.Checked)
                Permission += (int)Math.Pow(2, 4);
            else
                Permission -= (int)Math.Pow(2, 4);
        }

        private void Ck_UserList_CheckedChanged(object sender, EventArgs e)
        {
            if (Ck_UserList.Checked)
                Permission += (int)Math.Pow(2, 5);
            else
                Permission -= (int)Math.Pow(2, 5);
        }

        private void Ckbox_AddUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_AddUser.Checked)
                Permission += (int)Math.Pow(2, 6);
            else
                Permission -= (int)Math.Pow(2, 6);
        }       

        private void Ckbox_UpdateUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_UpdateClient.Checked)
                Permission += (int)Math.Pow(2, 7);
            else
                Permission -= (int)Math.Pow(2, 7);
        }

        private void Ckbox_DeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_DeleteUser.Checked)
                Permission += (int)Math.Pow(2, 8);
            else
                Permission -= (int)Math.Pow(2, 8);
        }

        private void Ckbox_FindAccountBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_FindAccountBalance.Checked)
                Permission += (int)Math.Pow(2, 9);
            else
                Permission -= (int)Math.Pow(2, 9);
        }

        private void Ckbox_Deposite_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_Deposite.Checked)
                Permission += (int)Math.Pow(2, 10);
            else
                Permission -= (int)Math.Pow(2, 10);
        }

        private void Ckbox_Withdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_Withdraw.Checked)
                Permission += (int)Math.Pow(2, 11);
            else
                Permission -= (int)Math.Pow(2, 11);
        }

        private void Ckbox_Transfer_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_Transfer.Checked)
                Permission += (int)Math.Pow(2, 12);
            else
                Permission -= (int)Math.Pow(2, 12);
        }

        private void Ckbox_AccountBalancesList_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbox_AccountBalancesList.Checked)
                Permission += (int)Math.Pow(2, 13);
            else
                Permission -= (int)Math.Pow(2, 13);
        }

        private void Btn_SetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";

            openFileDialog1.DefaultExt = "png,jpeg";

            openFileDialog1.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg) |*.jpeg| JPG files (*.JPG)|*.JPG";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                Image = openFileDialog1.FileName;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(Permission==16382)
            {
                Permission = -1;
            }
            clsUserBusiness User=new clsUserBusiness(0,Txtb_UserName.Text,Txtb_Password.Text,
                Permission,Image);
            if (User.AddNewUser())
            {
                MessageBox.Show("Added Succssfully ", "Done");
                Lb_ShowUserID.Text = User._UserID.ToString();
                Pan_Main.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed To Add", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txtb_UserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(Txtb_UserName.Text))
            {
                e.Cancel = true;
                Txtb_UserName.Focus();
                errorProvider1.SetError(Txtb_UserName, "Enter UserName");
            }
        }

        private void Txtb_Password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Txtb_Password.Text))
            {
                e.Cancel = true;
                Txtb_Password.Focus();
                errorProvider1.SetError(Txtb_Password, "Enter Password");
            }
        }

        private void Btn_ShowPassword_MouseEnter(object sender, EventArgs e)
        {
            Txtb_Password.UseSystemPasswordChar = false;
        }

        private void Btn_ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            Txtb_Password.UseSystemPasswordChar = true;
        }

        private void Btn_TransactionHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (Btn_TransactionHistory.Checked)
                Permission += (int)Math.Pow(2, 14);
            else
                Permission -= (int)Math.Pow(2, 14);
        }
    }
}
