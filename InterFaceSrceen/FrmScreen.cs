using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientsBusinessTier;
using InterFaceSrceen.Users_Control;
using UsersBusinessTier;
namespace InterFaceSrceen
{
    public partial class FrmScreen : Form
    {
        private Size formsize;
        private int BorderSize=2;
        private int Permissions;
        private string Password;
        private int NumberofUser;
        private int NumberOfClients;
        private double TotalBalances;
        private DataTable ClientsData;
        private DataTable UsersData;
        private int ClientID=0;
        private int UserID=0;
        public FrmScreen() { }
        public FrmScreen (clsUserBusiness user)
        {
            InitializeComponent();
            Lb_UserName.Text = user._UserName;
            Permissions = user._Permissions;
            Password = user._Password;
            ClientsData = clsClientsBusiness.ClientList();
            UsersData = clsUserBusiness.UserList();
            Picbox_User.ImageLocation = user._Image;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern int ReleaseCaputre();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(System.IntPtr ptr, int hty, int htr, int ewq);

        private void Pan_TitlePar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaputre();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                return;
            }
            WindowState = FormWindowState.Maximized;

        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            formsize = this.ClientSize;
            WindowState = FormWindowState.Minimized;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formsize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formsize;
            }
            base.WndProc(ref m);
        }

        private void AdiustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != BorderSize)
                        this.Padding = new Padding(BorderSize);
                    break;

            }
        }

        private void FrmScreen_Resize(object sender, EventArgs e)
        {
            AdiustForm();
            
        }     

        private void FrmScreen_Load(object sender, EventArgs e)
        {
            formsize = this.ClientSize;
            UpdateTablesView();
            UCDashboard uCDashboard = new UCDashboard(NumberofUser,NumberOfClients,TotalBalances);
            AddUserControl(uCDashboard);

        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Pan_Main.Controls.Clear();
            Pan_Main.Controls.Add(userControl);
            userControl.BringToFront();
            UpdateUserOnScreen();

        }

        private bool IsHasPermissions(int Num)
        {
            if (Permissions == -1)
                return true;
            else if(Convert.ToBoolean(Permissions & (int)Math.Pow(2,Num))==Convert.ToBoolean((int)Math.Pow(2,Num)))
            {
                return true;
            }
            else { return false; }
        }

        private void NoPermissions()
        {
            MessageBox.Show("You Don't Have Permission ","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Btn_DashBoard_Click(object sender, EventArgs e)
        {
            UCDashboard uCDashboard = new UCDashboard(NumberofUser, NumberOfClients, TotalBalances);
            AddUserControl(uCDashboard);
        }

        private void UpdateTablesView()
        {
            
            ClientsData = clsClientsBusiness.ClientList();
            NumberOfClients = ClientsData.Rows.Count;
            NumberofUser = UsersData.Rows.Count;
            TotalBalances = Convert.ToDouble(ClientsData.Compute("SUM(AccountBalance)", string.Empty));
        }

        private void UpdateUserOnScreen()
        {
            if (clsUserBusiness.IsExist(Lb_UserName.Text))
            {
                clsUserBusiness User = clsUserBusiness.FindByUserName(Lb_UserName.Text);
                if (User != null)
                {
                    if (Password == User._Password)
                    {
                        Permissions = User._Permissions;
                        Picbox_User.ImageLocation = User._Image;
                    }
                    else
                    {
                        MessageBox.Show("System Will Log out Because There Are SomeThing Change", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("System Will Log out Because There Are SomeThing Change", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void Btn_ClientsList_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(1))
            {
                Lb_MenuContext.Text = Btn_ClientsList.Text;
                UpdateTablesView();
                UCClientsList uCClientsList = new UCClientsList(ClientsData.DefaultView);
                uCClientsList.UpdateEvent += CallUpdateClientButton;
                AddUserControl(uCClientsList);
            }
            else
                NoPermissions();
        }

        private void CallUpdateClientButton(object sender, int ClientId)
        {
            if(ClientId>0)
            {
                ClientID = ClientId;
                Btn_UpdateClient_Click(sender,new EventArgs());              
            }

        }

        private void Btn_AddClient_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(2))
            {
                Lb_MenuContext.Text = Btn_AddClient.Text;
                UCAddClient addClient = new UCAddClient();
                AddUserControl(addClient);
            }
            else
                NoPermissions();
        }

        private void Btn_DeleteClient_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(4))
            {
                Lb_MenuContext.Text = Btn_DeleteClient.Text;
                UCDeleteClient uCDeleteClient = new UCDeleteClient();
                AddUserControl(uCDeleteClient);
            }
            else
                NoPermissions();
        }

        private void Btn_UpdateClient_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(3))
            {
                Lb_MenuContext.Text = Btn_UpdateClient.Text;
                UCUpdate uCUpdate = new UCUpdate(ClientID);
                AddUserControl(uCUpdate);
                ClientID = 0;
            }
            else
                NoPermissions();
        }

        private void Btn_WithDraw_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(11))
            {
                Lb_MenuContext.Text = Btn_WithDraw.Text;
                UCWithdraw uCWithdraw = new UCWithdraw();
                AddUserControl(uCWithdraw);
            }
            else
                NoPermissions();
        }

        private void Btn_Transaction_Click(object sender, EventArgs e)
        {
            if(Pan_TransActions.Visible)
            {
                Pan_TransActions.Visible = false;
                return;
            }
            Pan_TransActions.Visible=true;
        }

        private void Btn_ManageClients_Click(object sender, EventArgs e)
        {
            if(Pan_ManageClients.Visible)
            {
                Pan_ManageClients.Visible = false;
                return;
            }
            Pan_ManageClients.Visible=true;
        }

        private void Btn_AccountBalance_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(9))
            {
                Lb_MenuContext.Text = Btn_AccountBalance.Text;
                FrmAccountBalance frmAccountBalance = new FrmAccountBalance();
                frmAccountBalance.ShowDialog();
            }
            else
                NoPermissions();
        }

        private void Btn_Deposite_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(10))
            {
                Lb_MenuContext.Text = Btn_Deposite.Text;
                UCDeposite uCDeposite = new UCDeposite();
                AddUserControl(uCDeposite);
            }
            else
                NoPermissions();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Transfer_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(12))
            {
                Lb_MenuContext.Text = Btn_Transfer.Text;
                UCTransfer uCTransfer = new UCTransfer();
                AddUserControl(uCTransfer);
            }
            else
                NoPermissions();
        }

        private void Btn_AccountBalancesList_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(13))
            {
                Lb_MenuContext.Text = Btn_AccountBalancesList.Text;
                UCaccountBalancesList uCaccountBalancesList = new UCaccountBalancesList();
                AddUserControl(uCaccountBalancesList);
            }
            else
                NoPermissions();
        }       

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {
            if(Pan_ManageUsers.Visible) 
            {
                Pan_ManageUsers.Visible = false;
                return;
            }
            Pan_ManageUsers.Visible=true;
        }

        private void Btn_UsersList_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(5))
            {
                Lb_MenuContext.Text = Btn_UsersList.Text;
                UCUserList uUserList = new UCUserList();
                uUserList.UserID += CallUpdateUserButton;
                AddUserControl(uUserList);
            }
            else
                NoPermissions();
        }

        private void CallUpdateUserButton(object sender,int Userid)
        {
            if(Userid>0)
            {
                UserID = Userid;
                Btn_UpdateUser_Click(sender,new EventArgs());
            }
        }

        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(6))
            {
                Lb_MenuContext.Text = Btn_AddUser.Text;
                UCAddUser addUser = new UCAddUser();
                AddUserControl(addUser);
            }
            else
                NoPermissions();
        }

        private void Btn_UpdateUser_Click(object sender, EventArgs e)
        {
            if(IsHasPermissions(7))
            {
                Lb_MenuContext.Text = Btn_UpdateUser.Text;
                UCUpdateUser updateUser = new UCUpdateUser(UserID);
                AddUserControl(updateUser);
                UserID = 0;
            }
            else
                NoPermissions();
        }

        private void Btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if(IsHasPermissions(8))
            {
                Lb_MenuContext.Text = Btn_DeleteUser.Text;
                UCDeleteUser delUser = new UCDeleteUser();
                AddUserControl(delUser);
            }
            else
                NoPermissions();
        }

        private void Btn_TransactionHistory_Click(object sender, EventArgs e)
        {
            if (IsHasPermissions(14))
            {
                Lb_MenuContext.Text = Btn_TransactionHistory.Text;
                UCTransactionHistory transactionHistory = new UCTransactionHistory();
                AddUserControl(transactionHistory);
            }
            else
                NoPermissions();
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            Lb_MenuContext.Text = Btn_Settings.Text;
            UCSettings uCSettings = new UCSettings(Lb_UserName.Text, Password, Picbox_User.ImageLocation);
            AddUserControl(uCSettings);

        }
    }
}
