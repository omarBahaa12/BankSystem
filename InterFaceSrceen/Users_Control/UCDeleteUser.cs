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
    public partial class UCDeleteUser : UserControl
    {
        public UCDeleteUser()
        {
            InitializeComponent();
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

        private void CheckedCheckBox(int permission)
        {
            foreach (Panel panel in Pan_Permissions.Controls.OfType<Panel>())
            {
                foreach (CheckBox checkBox in panel.Controls.OfType<CheckBox>())
                {
                    if (Convert.ToBoolean(permission & (int)Math.Pow(2, Convert.ToInt32(checkBox.Tag)))
                        == Convert.ToBoolean((int)Math.Pow(2, Convert.ToInt32(checkBox.Tag))))
                    {
                        checkBox.Checked = true;

                    }
                }

            }

        }

        private void SetData(clsUserBusiness User)
        {
            Lb_ShowUserID.Text = User._UserID.ToString();
            Lb_ShowUserName.Text = User._UserName;
            Lb_ShowPassword.Text = User._Password;
            pictureBox1.ImageLocation = User._Image;
            CheckedCheckBox(User._Permissions);
        }

        private void EmptyData()
        {
            Txt_EnterUserName.Text = "";
            Lb_ShowUserID.Text = "";
            Lb_ShowUserName.Text = "";
            Lb_ShowPassword.Text = "";
            pictureBox1.ImageLocation = "";
            UnCheckedAllCheckBox();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Txt_EnterUserName.Text))
            {
                clsUserBusiness User=clsUserBusiness.FindByUserName(Txt_EnterUserName.Text);
                if(User!=null) 
                {
                    UnCheckedAllCheckBox();
                    SetData(User);
                }
                else
                {
                    MessageBox.Show("User Name Not Found", "NOT FOUND",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please,Enter User Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_EnterUserName.Focus();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Lb_ShowUserName.Text)) 
            {
                if (MessageBox.Show("Are You Sure To Delete This User", "Conformation"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsUserBusiness.Delete(Convert.ToInt32(Lb_ShowUserID.Text)))
                    {
                        MessageBox.Show("Deleted Succssfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmptyData();
                    }
                    else
                    {
                        MessageBox.Show("Failed To Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please,Enter User Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_EnterUserName.Focus();
            }
        }
    }
}
