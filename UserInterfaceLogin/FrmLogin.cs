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
using UsersBusinessTier;
using InterFaceSrceen;
namespace UserInterfaceLogin
{
    public partial class FrmLogin : Form
    {
        private Size formsize;
        private int BorderSize=2;
        private int Counter = 0;

        public FrmLogin()
        {
            InitializeComponent();
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

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            AdiustForm();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ShowPassword_MouseEnter(object sender, EventArgs e)
        {
            Mtxtbox_Password.UseSystemPasswordChar = false;
        }

        private void Btn_ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            Mtxtbox_Password.UseSystemPasswordChar= true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            formsize= this.ClientSize;
        }

        private void StopLogin()
        {
      
            MessageBox.Show("You Entered Three Times Wrong Wait 30 ٍSeconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            timer1.Enabled = true;
            Btn_Login.Enabled = false;
            Txtbox_UserName.Enabled = false;
            Mtxtbox_Password.Enabled = false;
            
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            clsUserBusiness user = clsUserBusiness.FindByUserNameAndPassword
            (Txtbox_UserName.Text, Mtxtbox_Password.Text);
            if (user != null && user._UserName == Txtbox_UserName.Text)
            {

                FrmScreen frm = new FrmScreen(user);
                frm.ShowDialog();
                Txtbox_UserName.Text = "";
                Mtxtbox_Password.Text = "";
                Counter = 0;
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Counter++;
                if (Counter >= 3)
                {
                    StopLogin();
                }
            
            }
            
        }

        private void Txtbox_UserName_Validating(object sender, CancelEventArgs e)
        {
            if (Txtbox_UserName.Text == "")
            {
                e.Cancel = true;
                Txtbox_UserName.Focus();
                errorProvider1.SetError(Txtbox_UserName, "Enter User Name");
            }
            else
                return;
        }

        private void Mtxtbox_Password_Validating(object sender, CancelEventArgs e)
        {
            if (Mtxtbox_Password.Text == "")
            {
                e.Cancel = true;
                Txtbox_UserName.Focus();
                errorProvider1.SetError(Mtxtbox_Password, "Enter Password");
            }
            else
                return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Btn_Login.Enabled = true;
            Txtbox_UserName.Enabled = true;
            Mtxtbox_Password.Enabled = true;
            Txtbox_UserName.Text = "";
            Mtxtbox_Password.Text = "";
            Counter = 0;
        }
    }
}
