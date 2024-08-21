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
using UsersBusinessTier;

namespace InterFaceSrceen.Users_Control
{
    public partial class UCUserList : UserControl
    {
        private DataView UsersView;

        public delegate void ReturnUserID(object sender, int UserID);

        public event ReturnUserID UserID;
        public UCUserList()
        {
            InitializeComponent();
            UsersView=clsUserBusiness.UserList().AsDataView();
            UsersView.Sort = "UserID Asc";
            DataG_UserList.DataSource=UsersView;
            Cmbox_Filterby.SelectedIndex = 0;
        }

        private void Txtb_UserName_TextChanged(object sender, EventArgs e)
        {
            UsersView=clsUserBusiness.FindUserByFullName(Txtb_UserName.Text).AsDataView();
            if(UsersView.Count==0)
            {
                UsersView.Table.Rows.Clear();
                DataG_UserList.DataSource= UsersView;
                return;
            }
            Cmbox_Filterby_SelectedIndexChanged(sender, e);
        }

        private void Cmbox_Filterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmbox_Filterby.SelectedIndex==0)
            {
                UsersView.Sort = "UserID Asc";
                DataG_UserList.DataSource= UsersView;
            }
            else if(Cmbox_Filterby.SelectedIndex==1)
            {
                UsersView.Sort = "UserID Desc";
                DataG_UserList.DataSource= UsersView;
            }
            else if(Cmbox_Filterby.SelectedIndex ==2) 
            {
                UsersView.Sort = "UserName Asc";
                DataG_UserList.DataSource= UsersView;
            }
            else
            {
                UsersView.Sort = "UserName Desc";
                DataG_UserList.DataSource= UsersView;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataG_UserList.CurrentRow != null)
            {
                if (MessageBox.Show("Are You Sure to Delete this User", "Warning"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (clsUserBusiness.Delete(Convert.ToInt32(DataG_UserList.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Deleted Successfully", "Done");
                        UsersView = clsUserBusiness.UserList().AsDataView();
                        DataG_UserList.DataSource = UsersView;
                    }
                    else
                        MessageBox.Show("Failed To Delete", "Failed");
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataG_UserList.CurrentRow != null)
            {
                if (MessageBox.Show("Are You Sure to Update this User", "Warning"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    UserID?.Invoke(this, Convert.ToInt32(DataG_UserList.CurrentRow.Cells[0].Value));                    
                }
            }
        }
    }
}
