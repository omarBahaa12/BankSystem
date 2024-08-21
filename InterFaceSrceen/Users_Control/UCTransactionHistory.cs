using ClientTransactionsBusinessTier;
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
    public partial class UCTransactionHistory : UserControl
    {
        private DataView DataTransaction=new DataView();
        public UCTransactionHistory()
        {
            InitializeComponent();
            DataTransaction=clsClientTransactions.Find("").AsDataView();
            DataTransaction.Sort=("TransactionDate Asc");
            DataG_TransactionsHistory.DataSource=DataTransaction;
        }

        private void Txtb_Search_TextChanged(object sender, EventArgs e)
        {
           
            if(clsClientTransactions.Find(Txtb_Search.Text).AsDataView()!=null) 
            {
                DataTransaction = clsClientTransactions.Find(Txtb_Search.Text).AsDataView();
               DataG_TransactionsHistory.DataSource=DataTransaction;
                DataTransaction.Sort = ("TransactionDate Asc");
            }
            else
            {
                DataG_TransactionsHistory.Rows.Clear();

            }

        }
    }
}
