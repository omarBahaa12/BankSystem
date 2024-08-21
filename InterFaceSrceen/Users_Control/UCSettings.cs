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
    public partial class UCSettings : UserControl
    {
        private string Image;
        public UCSettings(string UserName,string Password,string ImageLocation)
        {
            InitializeComponent();
            Lb_ShowUserName.Text = UserName;
            Lb_ShowPassword.Text = Password;
            PicBox_User.ImageLocation = ImageLocation;
        }

        private void Btn_UpdateInformation_Click(object sender, EventArgs e)
        {
            if (Btn_SetImage.Visible)
            {
                Btn_SetImage.Visible = false;
                Lb_NewUserName.Visible = false;
                Lb_NewPassword.Visible = false;
                Txtb_Password.Visible = false;
                Txtb_UserName.Visible = false;
                Btn_Update.Visible = false;
                Btn_ShowPassword.Visible = false;
                return;
            }
            Btn_SetImage.Visible = true;
            Lb_NewUserName.Visible = true;
            Lb_NewPassword.Visible = true;
            Txtb_Password.Visible = true;
            Txtb_UserName.Visible = true;
            Btn_Update.Visible = true;
            Btn_ShowPassword.Visible=true;
        }

        private void Btn_SetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";

            openFileDialog1.DefaultExt = "png,jpeg";

            openFileDialog1.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg) |*.jpeg| JPG files (*.JPG)|*.JPG";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicBox_User.Image = new Bitmap(openFileDialog1.FileName);
                Image = openFileDialog1.FileName;
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

        private void UpdateAttributes(ref clsUserBusiness User)
        {
            User._UserName=Txtb_UserName.Text;
            User._Password=Txtb_Password.Text;
            User._Image = Image;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            clsUserBusiness User=clsUserBusiness.FindByUserName(Lb_ShowUserName.Text);
            if (!string.IsNullOrWhiteSpace(Txtb_UserName.Text)&&!string.IsNullOrWhiteSpace(Txtb_Password.Text)) 
            {
                UpdateAttributes(ref User);
                if(User.Update())
                {
                    MessageBox.Show("Updated Successfully","UPDATED",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Btn_UpdateInformation_Click(sender, new EventArgs());
                    Lb_ShowPassword.Text = User._Password;
                    Lb_ShowUserName.Text = User._UserName;
                }

            }
        }
    }
}
