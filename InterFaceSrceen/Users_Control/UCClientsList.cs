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
    public partial class UCClientsList : UserControl
    {
        public delegate void UpdateClient(object sender, int ClientID);

        public event UpdateClient UpdateEvent;
        private DataView ClientDataView = new DataView(); 
        public UCClientsList(DataView ClientDataTable)
        {
            InitializeComponent();
            ClientDataView = ClientDataTable;
            ClientDataView.Sort = "ClientID Asc";
            DataG_ClientList.DataSource = ClientDataView;
            Cmbox_Sorting.SelectedIndex = 0;
        }

        private void Txtb_Search_TextChanged(object sender, EventArgs e)
        {
            ClientDataView=clsClientsBusiness.FindClientListByName(Txtb_Search.Text).AsDataView();
            if (ClientDataView.Count == 0)
            {
                ClientDataView.Table.Rows.Clear();
                DataG_ClientList.DataSource= ClientDataView;
            }
            else
                Cmbox_Sorting_SelectedIndexChanged(sender, e);
            
        }

        private void Cmbox_Sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Cmbox_Sorting.SelectedIndex == 0)
            {
                ClientDataView.Sort = "ClientID Asc";
                DataG_ClientList.DataSource = ClientDataView;
            }
            else if (Cmbox_Sorting.SelectedIndex == 1)
            {
                ClientDataView.Sort = "ClientID Desc";
                DataG_ClientList.DataSource = ClientDataView;
            }
            else if (Cmbox_Sorting.SelectedIndex == 2)
            {
                ClientDataView.Sort = "FirstName Asc";
                DataG_ClientList.DataSource = ClientDataView;
            }
            else
            {
                ClientDataView.Sort = "FirstName Desc";
                DataG_ClientList.DataSource = ClientDataView;
            }
            
        }            

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DataG_ClientList.CurrentRow != null)
            {
                if(MessageBox.Show("Are You Sure to Delete this Client","Warning"
                    ,MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK) 
                {
                    if (clsClientsBusiness.Delete(Convert.ToInt32(DataG_ClientList.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Deleted Successfully", "Done");
                        ClientDataView = clsClientsBusiness.ClientList().AsDataView();
                        DataG_ClientList.DataSource = ClientDataView;
                    }
                    else
                        MessageBox.Show("Failed To Delete", "Failed");
                }
            }
        }

        
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataG_ClientList.CurrentRow != null)
            {
                if (MessageBox.Show("Are You Sure to Update this Client", "Warning"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    UpdateEvent?.Invoke(this, Convert.ToInt32(DataG_ClientList.CurrentRow.Cells[0].Value));
                }
 
                
            }
        }
    }
}
