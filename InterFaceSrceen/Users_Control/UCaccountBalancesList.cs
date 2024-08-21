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
    public partial class UCaccountBalancesList : UserControl
    {
        DataView dataView;
        public UCaccountBalancesList()
        {
            InitializeComponent();
            dataView = clsClientsBusiness.AccountBalancesList("","","").AsDataView();
            Cmbox_Sorting.SelectedIndex = 0;
            dataView.Sort = "ClientID Asc";
            DataG_AccountBalancesList.DataSource = dataView;
        }  

        private void Txtb_Search_TextChanged(object sender, EventArgs e)
        {
            var FullName = Txtb_Search.Text.Split(' ');
            if( FullName.Length ==1) 
            {
                dataView = clsClientsBusiness.AccountBalancesList(FullName[0],"","").AsDataView();
            }
            else if(FullName.Length ==2) 
            {
                dataView=clsClientsBusiness.AccountBalancesList(FullName[0], FullName[1], "").AsDataView();

            }
            else
                dataView = clsClientsBusiness.AccountBalancesList(FullName[0], FullName[1], FullName[2]).AsDataView();
            if(dataView.Count==0)
            {
                dataView.Table.Rows.Clear();
                DataG_AccountBalancesList.DataSource= dataView;
                return;
            }
                Cmbox_Sorting_SelectedIndexChanged(sender, new EventArgs());
        }

        private void Cmbox_Sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataView!=null)
            {
                if (Cmbox_Sorting.SelectedIndex == 0)
                {
                    dataView.Sort = "ClientID Asc";
                    DataG_AccountBalancesList.DataSource = dataView;
                }
                else if (Cmbox_Sorting.SelectedIndex == 1)
                {
                    dataView.Sort = "ClientID Desc";
                    DataG_AccountBalancesList.DataSource = dataView;
                }
                else if (Cmbox_Sorting.SelectedIndex == 2)
                {
                    dataView.Sort = "FirstName Asc";
                    DataG_AccountBalancesList.DataSource = dataView;
                }
                else
                {
                    dataView.Sort = "FirstName Desc";
                    DataG_AccountBalancesList.DataSource = dataView;
                }
            }
        }
    }
}
