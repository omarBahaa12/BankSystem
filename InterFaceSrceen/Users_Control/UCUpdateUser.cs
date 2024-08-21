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
    public partial class UCUpdateUser : UserControl
    {
        private int Permission;
        private string Image;
        public UCUpdateUser(int ClientID=0)
        {
            InitializeComponent();
            if(ClientID != 0)
            {
                PutData(clsUserBusiness.FindUserByID(ClientID));
            }
        }
       
        private void CheckedAllCheckBox(int permission)
        {
            foreach(Panel panel in Pan_Permissions.Controls.OfType<Panel>()) 
            {
                foreach(CheckBox checkBox in panel.Controls.OfType<CheckBox>()) 
                {
                    if(Convert.ToBoolean(permission & (int)Math.Pow(2,Convert.ToInt32( checkBox.Tag) ))
                        == Convert.ToBoolean((int)Math.Pow(2, Convert.ToInt32(checkBox.Tag))))
                    {
                        checkBox.Checked = true;
                        
                    }
                }
            
            }
            
        }

        private void CheckedAllCheckBox()
        {
            foreach (Panel panel in Pan_Permissions.Controls.OfType<Panel>())
            {
                foreach (CheckBox checkBox in panel.Controls.OfType<CheckBox>())
                {                
                    checkBox.Checked = true;                   
                }
            }

        }

        private void UnCheckedAllCheckBox()
        {
            foreach (Panel panel in Pan_Permissions.Controls.OfType<Panel>())
            {
                foreach (CheckBox checkBox in panel.Controls.OfType<CheckBox>())
                {
                    checkBox.Checked = false;
                }
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
                Permission -= (int)Math.Pow(2, 2);
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
            if (Ckbox_UpdateUser.Checked)
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

        private void PutData(clsUserBusiness User)
        {
            UnCheckedAllCheckBox();
            Lb_ShowUserID.Text = User._UserID.ToString();
            Txtb_UserName.Text = User._UserName;
            Txt_EnterUserName.Text=User._UserName;
            Txtb_Password.Text = User._Password;
            pictureBox1.ImageLocation = User._Image;
            Image = User._Image;
            if (User._Permissions == -1)
                CheckedAllCheckBox();
            else
                CheckedAllCheckBox(User._Permissions);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Pan_Main.Enabled = true;
            if (!string.IsNullOrWhiteSpace(Txt_EnterUserName.Text))
            {
                clsUserBusiness User=clsUserBusiness.FindByUserName(Txt_EnterUserName.Text);
                if (User != null)
                {
                    PutData(User);
                }
                else
                    MessageBox.Show("UserName Wrong", "NOT FOUND",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Enter UserName", "WRONG",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private clsUserBusiness GetUpdateUser(int ID)
        {
            if(!string.IsNullOrWhiteSpace(Txtb_UserName.Text)&&!string.IsNullOrWhiteSpace(Txtb_Password.Text))
            {
                if (Permission == 16382)
                    Permission = -1;
                 clsUserBusiness User=new clsUserBusiness(ID,Txtb_UserName.Text,Txtb_Password.Text
                    ,Permission,Image);
                 return User;
            }
            return null;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            clsUserBusiness User=GetUpdateUser(Convert.ToInt32( Lb_ShowUserID.Text));
            if (User != null) 
            {
                if (User.Update())
                {
                    MessageBox.Show("Updated Successfully", "Done");
                    Pan_Main.Enabled = false;
                    Txt_EnterUserName.Text = "";
                }
                else
                    MessageBox.Show("Failed to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("UserName Wrong", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Btn_ShowPassword_MouseEnter(object sender, EventArgs e)
        {
            Txtb_Password.UseSystemPasswordChar = false;
        }

        private void Btn_ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            Txtb_Password.UseSystemPasswordChar = true;
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

        private void Ckb_TransactionHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_TransactionHistory.Checked)
                Permission += (int)Math.Pow(2, 14);
            else
                Permission -= (int)Math.Pow(2, 14);
        }
    }
}
