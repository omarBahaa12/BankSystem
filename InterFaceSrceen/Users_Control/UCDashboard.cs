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
    public partial class UCDashboard : UserControl
    {
        public UCDashboard(int NumberofUsers,int NumberofClients,double TotalBalances)
        {
            InitializeComponent();

            Lb_NumberClients.Text=NumberofClients.ToString();
            Lb_NumberUser.Text=NumberofUsers.ToString();
            Lb_NumberTotalBalances.Text=TotalBalances.ToString();
        }

       
    }
}
