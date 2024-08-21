namespace InterFaceSrceen
{
    partial class FrmScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScreen));
            this.Pan_Menu = new System.Windows.Forms.Panel();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pan_TransActions = new System.Windows.Forms.Panel();
            this.Btn_TransactionHistory = new System.Windows.Forms.Button();
            this.Btn_AccountBalancesList = new System.Windows.Forms.Button();
            this.Btn_Transfer = new System.Windows.Forms.Button();
            this.Btn_WithDraw = new System.Windows.Forms.Button();
            this.Btn_Deposite = new System.Windows.Forms.Button();
            this.Btn_AccountBalance = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Btn_Transaction = new System.Windows.Forms.Button();
            this.Pan_ManageUsers = new System.Windows.Forms.Panel();
            this.Btn_DeleteUser = new System.Windows.Forms.Button();
            this.Btn_UpdateUser = new System.Windows.Forms.Button();
            this.Btn_AddUser = new System.Windows.Forms.Button();
            this.Btn_UsersList = new System.Windows.Forms.Button();
            this.btn_ManageUsers = new System.Windows.Forms.Button();
            this.Pan_ManageClients = new System.Windows.Forms.Panel();
            this.Btn_UpdateClient = new System.Windows.Forms.Button();
            this.Btn_AddClient = new System.Windows.Forms.Button();
            this.Btn_ClientsList = new System.Windows.Forms.Button();
            this.Btn_DeleteClient = new System.Windows.Forms.Button();
            this.Btn_ManageClients = new System.Windows.Forms.Button();
            this.Btn_DashBoard = new System.Windows.Forms.Button();
            this.Pan_PicUserName = new System.Windows.Forms.Panel();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Picbox_User = new System.Windows.Forms.PictureBox();
            this.Pan_TitleBar = new System.Windows.Forms.Panel();
            this.Lb_MenuContext = new System.Windows.Forms.Label();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.Pan_Menu.SuspendLayout();
            this.Pan_TransActions.SuspendLayout();
            this.Pan_ManageUsers.SuspendLayout();
            this.Pan_ManageClients.SuspendLayout();
            this.Pan_PicUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_User)).BeginInit();
            this.Pan_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Menu
            // 
            this.Pan_Menu.AutoScroll = true;
            this.Pan_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_Menu.Controls.Add(this.Btn_LogOut);
            this.Pan_Menu.Controls.Add(this.Pan_TransActions);
            this.Pan_Menu.Controls.Add(this.Btn_Settings);
            this.Pan_Menu.Controls.Add(this.Btn_Transaction);
            this.Pan_Menu.Controls.Add(this.Pan_ManageUsers);
            this.Pan_Menu.Controls.Add(this.btn_ManageUsers);
            this.Pan_Menu.Controls.Add(this.Pan_ManageClients);
            this.Pan_Menu.Controls.Add(this.Btn_ManageClients);
            this.Pan_Menu.Controls.Add(this.Btn_DashBoard);
            this.Pan_Menu.Controls.Add(this.Pan_PicUserName);
            this.Pan_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Menu.Location = new System.Drawing.Point(0, 0);
            this.Pan_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_Menu.Name = "Pan_Menu";
            this.Pan_Menu.Size = new System.Drawing.Size(335, 948);
            this.Pan_Menu.TabIndex = 0;
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_LogOut.FlatAppearance.BorderSize = 0;
            this.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LogOut.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.ImageIndex = 8;
            this.Btn_LogOut.ImageList = this.imageList1;
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 1885);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(314, 82);
            this.Btn_LogOut.TabIndex = 11;
            this.Btn_LogOut.Text = "Log Out";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house.png");
            this.imageList1.Images.SetKeyName(1, "add-user.png");
            this.imageList1.Images.SetKeyName(2, "list.png");
            this.imageList1.Images.SetKeyName(3, "unfollow.png");
            this.imageList1.Images.SetKeyName(4, "profile.png");
            this.imageList1.Images.SetKeyName(5, "transaction.png");
            this.imageList1.Images.SetKeyName(6, "teamwork.png");
            this.imageList1.Images.SetKeyName(7, "settings.png");
            this.imageList1.Images.SetKeyName(8, "log-out.png");
            this.imageList1.Images.SetKeyName(9, "cash-withdrawal.png");
            this.imageList1.Images.SetKeyName(10, "arrow.png");
            this.imageList1.Images.SetKeyName(11, "wallet.png");
            this.imageList1.Images.SetKeyName(12, "customer-satisfaction.png");
            this.imageList1.Images.SetKeyName(13, "transfer.png");
            this.imageList1.Images.SetKeyName(14, "finances.png");
            this.imageList1.Images.SetKeyName(15, "update-profile.png");
            this.imageList1.Images.SetKeyName(16, "delete-user.png");
            this.imageList1.Images.SetKeyName(17, "add-user(1).png");
            this.imageList1.Images.SetKeyName(18, "customer.png");
            this.imageList1.Images.SetKeyName(19, "user-profile.png");
            this.imageList1.Images.SetKeyName(20, "clipboard.png");
            // 
            // Pan_TransActions
            // 
            this.Pan_TransActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Pan_TransActions.Controls.Add(this.Btn_TransactionHistory);
            this.Pan_TransActions.Controls.Add(this.Btn_AccountBalancesList);
            this.Pan_TransActions.Controls.Add(this.Btn_Transfer);
            this.Pan_TransActions.Controls.Add(this.Btn_WithDraw);
            this.Pan_TransActions.Controls.Add(this.Btn_Deposite);
            this.Pan_TransActions.Controls.Add(this.Btn_AccountBalance);
            this.Pan_TransActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_TransActions.Location = new System.Drawing.Point(0, 1365);
            this.Pan_TransActions.Name = "Pan_TransActions";
            this.Pan_TransActions.Size = new System.Drawing.Size(314, 520);
            this.Pan_TransActions.TabIndex = 12;
            this.Pan_TransActions.Visible = false;
            // 
            // Btn_TransactionHistory
            // 
            this.Btn_TransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_TransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_TransactionHistory.FlatAppearance.BorderSize = 0;
            this.Btn_TransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TransactionHistory.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TransactionHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_TransactionHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TransactionHistory.ImageIndex = 20;
            this.Btn_TransactionHistory.ImageList = this.imageList1;
            this.Btn_TransactionHistory.Location = new System.Drawing.Point(0, 428);
            this.Btn_TransactionHistory.Name = "Btn_TransactionHistory";
            this.Btn_TransactionHistory.Size = new System.Drawing.Size(314, 88);
            this.Btn_TransactionHistory.TabIndex = 5;
            this.Btn_TransactionHistory.Text = "Transaction History";
            this.Btn_TransactionHistory.UseVisualStyleBackColor = false;
            this.Btn_TransactionHistory.Click += new System.EventHandler(this.Btn_TransactionHistory_Click);
            // 
            // Btn_AccountBalancesList
            // 
            this.Btn_AccountBalancesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_AccountBalancesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AccountBalancesList.FlatAppearance.BorderSize = 0;
            this.Btn_AccountBalancesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AccountBalancesList.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AccountBalancesList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_AccountBalancesList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AccountBalancesList.ImageIndex = 14;
            this.Btn_AccountBalancesList.ImageList = this.imageList1;
            this.Btn_AccountBalancesList.Location = new System.Drawing.Point(0, 341);
            this.Btn_AccountBalancesList.Name = "Btn_AccountBalancesList";
            this.Btn_AccountBalancesList.Size = new System.Drawing.Size(314, 87);
            this.Btn_AccountBalancesList.TabIndex = 4;
            this.Btn_AccountBalancesList.Text = "AccountBalances List";
            this.Btn_AccountBalancesList.UseVisualStyleBackColor = false;
            this.Btn_AccountBalancesList.Click += new System.EventHandler(this.Btn_AccountBalancesList_Click);
            // 
            // Btn_Transfer
            // 
            this.Btn_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_Transfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Transfer.FlatAppearance.BorderSize = 0;
            this.Btn_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transfer.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Transfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Transfer.ImageIndex = 13;
            this.Btn_Transfer.ImageList = this.imageList1;
            this.Btn_Transfer.Location = new System.Drawing.Point(0, 258);
            this.Btn_Transfer.Name = "Btn_Transfer";
            this.Btn_Transfer.Size = new System.Drawing.Size(314, 83);
            this.Btn_Transfer.TabIndex = 3;
            this.Btn_Transfer.Text = "Transfer";
            this.Btn_Transfer.UseVisualStyleBackColor = false;
            this.Btn_Transfer.Click += new System.EventHandler(this.Btn_Transfer_Click);
            // 
            // Btn_WithDraw
            // 
            this.Btn_WithDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_WithDraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_WithDraw.FlatAppearance.BorderSize = 0;
            this.Btn_WithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_WithDraw.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_WithDraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_WithDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_WithDraw.ImageIndex = 9;
            this.Btn_WithDraw.ImageList = this.imageList1;
            this.Btn_WithDraw.Location = new System.Drawing.Point(0, 169);
            this.Btn_WithDraw.Name = "Btn_WithDraw";
            this.Btn_WithDraw.Size = new System.Drawing.Size(314, 89);
            this.Btn_WithDraw.TabIndex = 0;
            this.Btn_WithDraw.Text = "Withdraw";
            this.Btn_WithDraw.UseVisualStyleBackColor = false;
            this.Btn_WithDraw.Click += new System.EventHandler(this.Btn_WithDraw_Click);
            // 
            // Btn_Deposite
            // 
            this.Btn_Deposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_Deposite.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Deposite.FlatAppearance.BorderSize = 0;
            this.Btn_Deposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deposite.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deposite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Deposite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Deposite.ImageIndex = 10;
            this.Btn_Deposite.ImageList = this.imageList1;
            this.Btn_Deposite.Location = new System.Drawing.Point(0, 82);
            this.Btn_Deposite.Name = "Btn_Deposite";
            this.Btn_Deposite.Size = new System.Drawing.Size(314, 87);
            this.Btn_Deposite.TabIndex = 1;
            this.Btn_Deposite.Text = "Deposite";
            this.Btn_Deposite.UseVisualStyleBackColor = false;
            this.Btn_Deposite.Click += new System.EventHandler(this.Btn_Deposite_Click);
            // 
            // Btn_AccountBalance
            // 
            this.Btn_AccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_AccountBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AccountBalance.FlatAppearance.BorderSize = 0;
            this.Btn_AccountBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AccountBalance.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AccountBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_AccountBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AccountBalance.ImageIndex = 11;
            this.Btn_AccountBalance.ImageList = this.imageList1;
            this.Btn_AccountBalance.Location = new System.Drawing.Point(0, 0);
            this.Btn_AccountBalance.Name = "Btn_AccountBalance";
            this.Btn_AccountBalance.Size = new System.Drawing.Size(314, 82);
            this.Btn_AccountBalance.TabIndex = 2;
            this.Btn_AccountBalance.Text = "  Find Account Balance";
            this.Btn_AccountBalance.UseVisualStyleBackColor = false;
            this.Btn_AccountBalance.Click += new System.EventHandler(this.Btn_AccountBalance_Click);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Settings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Settings.ImageIndex = 7;
            this.Btn_Settings.ImageList = this.imageList1;
            this.Btn_Settings.Location = new System.Drawing.Point(0, 1967);
            this.Btn_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(314, 90);
            this.Btn_Settings.TabIndex = 10;
            this.Btn_Settings.Text = "Settings";
            this.Btn_Settings.UseVisualStyleBackColor = true;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_Transaction
            // 
            this.Btn_Transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Transaction.FlatAppearance.BorderSize = 0;
            this.Btn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transaction.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transaction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Transaction.ImageIndex = 5;
            this.Btn_Transaction.ImageList = this.imageList1;
            this.Btn_Transaction.Location = new System.Drawing.Point(0, 1255);
            this.Btn_Transaction.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Transaction.Name = "Btn_Transaction";
            this.Btn_Transaction.Size = new System.Drawing.Size(314, 110);
            this.Btn_Transaction.TabIndex = 8;
            this.Btn_Transaction.Text = "Transaction";
            this.Btn_Transaction.UseVisualStyleBackColor = true;
            this.Btn_Transaction.Click += new System.EventHandler(this.Btn_Transaction_Click);
            // 
            // Pan_ManageUsers
            // 
            this.Pan_ManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Pan_ManageUsers.Controls.Add(this.Btn_DeleteUser);
            this.Pan_ManageUsers.Controls.Add(this.Btn_UpdateUser);
            this.Pan_ManageUsers.Controls.Add(this.Btn_AddUser);
            this.Pan_ManageUsers.Controls.Add(this.Btn_UsersList);
            this.Pan_ManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_ManageUsers.Location = new System.Drawing.Point(0, 891);
            this.Pan_ManageUsers.Name = "Pan_ManageUsers";
            this.Pan_ManageUsers.Size = new System.Drawing.Size(314, 364);
            this.Pan_ManageUsers.TabIndex = 14;
            this.Pan_ManageUsers.Visible = false;
            // 
            // Btn_DeleteUser
            // 
            this.Btn_DeleteUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteUser.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DeleteUser.ImageIndex = 16;
            this.Btn_DeleteUser.ImageList = this.imageList1;
            this.Btn_DeleteUser.Location = new System.Drawing.Point(0, 267);
            this.Btn_DeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_DeleteUser.Name = "Btn_DeleteUser";
            this.Btn_DeleteUser.Size = new System.Drawing.Size(314, 97);
            this.Btn_DeleteUser.TabIndex = 7;
            this.Btn_DeleteUser.Text = "Delete User";
            this.Btn_DeleteUser.UseVisualStyleBackColor = true;
            this.Btn_DeleteUser.Click += new System.EventHandler(this.Btn_DeleteUser_Click);
            // 
            // Btn_UpdateUser
            // 
            this.Btn_UpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UpdateUser.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateUser.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UpdateUser.ImageIndex = 19;
            this.Btn_UpdateUser.ImageList = this.imageList1;
            this.Btn_UpdateUser.Location = new System.Drawing.Point(0, 168);
            this.Btn_UpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpdateUser.Name = "Btn_UpdateUser";
            this.Btn_UpdateUser.Size = new System.Drawing.Size(314, 94);
            this.Btn_UpdateUser.TabIndex = 6;
            this.Btn_UpdateUser.Text = "Update User";
            this.Btn_UpdateUser.UseVisualStyleBackColor = true;
            this.Btn_UpdateUser.Click += new System.EventHandler(this.Btn_UpdateUser_Click);
            // 
            // Btn_AddUser
            // 
            this.Btn_AddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AddUser.FlatAppearance.BorderSize = 0;
            this.Btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddUser.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddUser.ImageIndex = 17;
            this.Btn_AddUser.ImageList = this.imageList1;
            this.Btn_AddUser.Location = new System.Drawing.Point(0, 87);
            this.Btn_AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddUser.Name = "Btn_AddUser";
            this.Btn_AddUser.Size = new System.Drawing.Size(314, 81);
            this.Btn_AddUser.TabIndex = 4;
            this.Btn_AddUser.Text = "Add User";
            this.Btn_AddUser.UseVisualStyleBackColor = true;
            this.Btn_AddUser.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // Btn_UsersList
            // 
            this.Btn_UsersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UsersList.FlatAppearance.BorderSize = 0;
            this.Btn_UsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UsersList.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UsersList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UsersList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UsersList.ImageIndex = 18;
            this.Btn_UsersList.ImageList = this.imageList1;
            this.Btn_UsersList.Location = new System.Drawing.Point(0, 0);
            this.Btn_UsersList.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UsersList.Name = "Btn_UsersList";
            this.Btn_UsersList.Size = new System.Drawing.Size(314, 87);
            this.Btn_UsersList.TabIndex = 3;
            this.Btn_UsersList.Text = "Users List ";
            this.Btn_UsersList.UseVisualStyleBackColor = true;
            this.Btn_UsersList.Click += new System.EventHandler(this.Btn_UsersList_Click);
            // 
            // btn_ManageUsers
            // 
            this.btn_ManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ManageUsers.FlatAppearance.BorderSize = 0;
            this.btn_ManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ManageUsers.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ManageUsers.ImageIndex = 6;
            this.btn_ManageUsers.ImageList = this.imageList1;
            this.btn_ManageUsers.Location = new System.Drawing.Point(0, 787);
            this.btn_ManageUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ManageUsers.Name = "btn_ManageUsers";
            this.btn_ManageUsers.Size = new System.Drawing.Size(314, 104);
            this.btn_ManageUsers.TabIndex = 9;
            this.btn_ManageUsers.Text = "Manage Users";
            this.btn_ManageUsers.UseVisualStyleBackColor = true;
            this.btn_ManageUsers.Click += new System.EventHandler(this.btn_ManageUsers_Click);
            // 
            // Pan_ManageClients
            // 
            this.Pan_ManageClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Pan_ManageClients.Controls.Add(this.Btn_UpdateClient);
            this.Pan_ManageClients.Controls.Add(this.Btn_AddClient);
            this.Pan_ManageClients.Controls.Add(this.Btn_ClientsList);
            this.Pan_ManageClients.Controls.Add(this.Btn_DeleteClient);
            this.Pan_ManageClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_ManageClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pan_ManageClients.Location = new System.Drawing.Point(0, 450);
            this.Pan_ManageClients.Name = "Pan_ManageClients";
            this.Pan_ManageClients.Size = new System.Drawing.Size(314, 337);
            this.Pan_ManageClients.TabIndex = 13;
            this.Pan_ManageClients.Visible = false;
            // 
            // Btn_UpdateClient
            // 
            this.Btn_UpdateClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UpdateClient.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateClient.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpdateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UpdateClient.ImageIndex = 4;
            this.Btn_UpdateClient.ImageList = this.imageList1;
            this.Btn_UpdateClient.Location = new System.Drawing.Point(0, 168);
            this.Btn_UpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpdateClient.Name = "Btn_UpdateClient";
            this.Btn_UpdateClient.Size = new System.Drawing.Size(314, 94);
            this.Btn_UpdateClient.TabIndex = 5;
            this.Btn_UpdateClient.Text = "Update Client";
            this.Btn_UpdateClient.UseVisualStyleBackColor = true;
            this.Btn_UpdateClient.Click += new System.EventHandler(this.Btn_UpdateClient_Click);
            // 
            // Btn_AddClient
            // 
            this.Btn_AddClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AddClient.FlatAppearance.BorderSize = 0;
            this.Btn_AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddClient.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_AddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddClient.ImageIndex = 1;
            this.Btn_AddClient.ImageList = this.imageList1;
            this.Btn_AddClient.Location = new System.Drawing.Point(0, 87);
            this.Btn_AddClient.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddClient.Name = "Btn_AddClient";
            this.Btn_AddClient.Size = new System.Drawing.Size(314, 81);
            this.Btn_AddClient.TabIndex = 3;
            this.Btn_AddClient.Text = "Add Client";
            this.Btn_AddClient.UseVisualStyleBackColor = true;
            this.Btn_AddClient.Click += new System.EventHandler(this.Btn_AddClient_Click);
            // 
            // Btn_ClientsList
            // 
            this.Btn_ClientsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_ClientsList.FlatAppearance.BorderSize = 0;
            this.Btn_ClientsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ClientsList.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ClientsList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ClientsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ClientsList.ImageIndex = 2;
            this.Btn_ClientsList.ImageList = this.imageList1;
            this.Btn_ClientsList.Location = new System.Drawing.Point(0, 0);
            this.Btn_ClientsList.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ClientsList.Name = "Btn_ClientsList";
            this.Btn_ClientsList.Size = new System.Drawing.Size(314, 87);
            this.Btn_ClientsList.TabIndex = 2;
            this.Btn_ClientsList.Text = "Clients List ";
            this.Btn_ClientsList.UseVisualStyleBackColor = true;
            this.Btn_ClientsList.Click += new System.EventHandler(this.Btn_ClientsList_Click);
            // 
            // Btn_DeleteClient
            // 
            this.Btn_DeleteClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_DeleteClient.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteClient.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_DeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DeleteClient.ImageIndex = 3;
            this.Btn_DeleteClient.ImageList = this.imageList1;
            this.Btn_DeleteClient.Location = new System.Drawing.Point(0, 240);
            this.Btn_DeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_DeleteClient.Name = "Btn_DeleteClient";
            this.Btn_DeleteClient.Size = new System.Drawing.Size(314, 97);
            this.Btn_DeleteClient.TabIndex = 4;
            this.Btn_DeleteClient.Text = "Delete Client";
            this.Btn_DeleteClient.UseVisualStyleBackColor = true;
            this.Btn_DeleteClient.Click += new System.EventHandler(this.Btn_DeleteClient_Click);
            // 
            // Btn_ManageClients
            // 
            this.Btn_ManageClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_ManageClients.FlatAppearance.BorderSize = 0;
            this.Btn_ManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ManageClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ManageClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ManageClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ManageClients.ImageIndex = 12;
            this.Btn_ManageClients.ImageList = this.imageList1;
            this.Btn_ManageClients.Location = new System.Drawing.Point(0, 339);
            this.Btn_ManageClients.Name = "Btn_ManageClients";
            this.Btn_ManageClients.Size = new System.Drawing.Size(314, 111);
            this.Btn_ManageClients.TabIndex = 1;
            this.Btn_ManageClients.Text = "Manage CLients";
            this.Btn_ManageClients.UseVisualStyleBackColor = true;
            this.Btn_ManageClients.Click += new System.EventHandler(this.Btn_ManageClients_Click);
            // 
            // Btn_DashBoard
            // 
            this.Btn_DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_DashBoard.FlatAppearance.BorderSize = 0;
            this.Btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DashBoard.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DashBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DashBoard.ImageIndex = 0;
            this.Btn_DashBoard.ImageList = this.imageList1;
            this.Btn_DashBoard.Location = new System.Drawing.Point(0, 234);
            this.Btn_DashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_DashBoard.Name = "Btn_DashBoard";
            this.Btn_DashBoard.Size = new System.Drawing.Size(314, 105);
            this.Btn_DashBoard.TabIndex = 0;
            this.Btn_DashBoard.Text = "Dashboard";
            this.Btn_DashBoard.UseVisualStyleBackColor = true;
            this.Btn_DashBoard.Click += new System.EventHandler(this.Btn_DashBoard_Click);
            // 
            // Pan_PicUserName
            // 
            this.Pan_PicUserName.Controls.Add(this.Lb_UserName);
            this.Pan_PicUserName.Controls.Add(this.Picbox_User);
            this.Pan_PicUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_PicUserName.Location = new System.Drawing.Point(0, 0);
            this.Pan_PicUserName.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_PicUserName.Name = "Pan_PicUserName";
            this.Pan_PicUserName.Size = new System.Drawing.Size(314, 234);
            this.Pan_PicUserName.TabIndex = 2;
            this.Pan_PicUserName.TabStop = true;
            this.Pan_PicUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_UserName.Location = new System.Drawing.Point(101, 166);
            this.Lb_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(0, 32);
            this.Lb_UserName.TabIndex = 1;
            // 
            // Picbox_User
            // 
            this.Picbox_User.Image = global::InterFaceSrceen.Properties.Resources.unknown;
            this.Picbox_User.Location = new System.Drawing.Point(82, 13);
            this.Picbox_User.Margin = new System.Windows.Forms.Padding(4);
            this.Picbox_User.Name = "Picbox_User";
            this.Picbox_User.Size = new System.Drawing.Size(152, 127);
            this.Picbox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picbox_User.TabIndex = 0;
            this.Picbox_User.TabStop = false;
            // 
            // Pan_TitleBar
            // 
            this.Pan_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_TitleBar.Controls.Add(this.Lb_MenuContext);
            this.Pan_TitleBar.Controls.Add(this.Btn_Minimize);
            this.Pan_TitleBar.Controls.Add(this.Btn_Maxmize);
            this.Pan_TitleBar.Controls.Add(this.Btn_Exit);
            this.Pan_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_TitleBar.Location = new System.Drawing.Point(335, 0);
            this.Pan_TitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_TitleBar.Name = "Pan_TitleBar";
            this.Pan_TitleBar.Size = new System.Drawing.Size(1049, 47);
            this.Pan_TitleBar.TabIndex = 1;
            this.Pan_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Lb_MenuContext
            // 
            this.Lb_MenuContext.AutoSize = true;
            this.Lb_MenuContext.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_MenuContext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_MenuContext.Location = new System.Drawing.Point(57, 9);
            this.Lb_MenuContext.Name = "Lb_MenuContext";
            this.Lb_MenuContext.Size = new System.Drawing.Size(189, 35);
            this.Lb_MenuContext.TabIndex = 3;
            this.Lb_MenuContext.Text = "DashBoard";
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.ImageIndex = 1;
            this.Btn_Minimize.ImageList = this.imageList2;
            this.Btn_Minimize.Location = new System.Drawing.Point(884, 0);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(55, 47);
            this.Btn_Minimize.TabIndex = 2;
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "maximize.png");
            this.imageList2.Images.SetKeyName(1, "minimize.png");
            this.imageList2.Images.SetKeyName(2, "exit-full-screen.png");
            // 
            // Btn_Maxmize
            // 
            this.Btn_Maxmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Maxmize.FlatAppearance.BorderSize = 0;
            this.Btn_Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maxmize.ImageIndex = 0;
            this.Btn_Maxmize.ImageList = this.imageList2;
            this.Btn_Maxmize.Location = new System.Drawing.Point(939, 0);
            this.Btn_Maxmize.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Maxmize.Name = "Btn_Maxmize";
            this.Btn_Maxmize.Size = new System.Drawing.Size(55, 47);
            this.Btn_Maxmize.TabIndex = 1;
            this.Btn_Maxmize.UseVisualStyleBackColor = true;
            this.Btn_Maxmize.Click += new System.EventHandler(this.Btn_Maxmize_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.ImageIndex = 2;
            this.Btn_Exit.ImageList = this.imageList2;
            this.Btn_Exit.Location = new System.Drawing.Point(994, 0);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(55, 47);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Pan_Main
            // 
            this.Pan_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Main.Location = new System.Drawing.Point(335, 47);
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.Size = new System.Drawing.Size(1049, 901);
            this.Pan_Main.TabIndex = 2;
            // 
            // FrmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1384, 948);
            this.Controls.Add(this.Pan_Main);
            this.Controls.Add(this.Pan_TitleBar);
            this.Controls.Add(this.Pan_Menu);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmScreen_Load);
            this.Resize += new System.EventHandler(this.FrmScreen_Resize);
            this.Pan_Menu.ResumeLayout(false);
            this.Pan_TransActions.ResumeLayout(false);
            this.Pan_ManageUsers.ResumeLayout(false);
            this.Pan_ManageClients.ResumeLayout(false);
            this.Pan_PicUserName.ResumeLayout(false);
            this.Pan_PicUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_User)).EndInit();
            this.Pan_TitleBar.ResumeLayout(false);
            this.Pan_TitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Menu;
        private System.Windows.Forms.PictureBox Picbox_User;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Panel Pan_PicUserName;
        private System.Windows.Forms.Button Btn_ClientsList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_DashBoard;
        private System.Windows.Forms.Button Btn_AddClient;
        private System.Windows.Forms.Button Btn_DeleteClient;
        private System.Windows.Forms.Button Btn_UpdateClient;
        private System.Windows.Forms.Button Btn_Transaction;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.Button btn_ManageUsers;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Panel Pan_TitleBar;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel Pan_Main;
        private System.Windows.Forms.Button Btn_Deposite;
        private System.Windows.Forms.Button Btn_WithDraw;
        private System.Windows.Forms.Button Btn_AccountBalance;
        private System.Windows.Forms.Panel Pan_ManageClients;
        private System.Windows.Forms.Button Btn_ManageClients;
        private System.Windows.Forms.Panel Pan_TransActions;
        private System.Windows.Forms.Button Btn_Transfer;
        private System.Windows.Forms.Button Btn_AccountBalancesList;
        private System.Windows.Forms.Panel Pan_ManageUsers;
        private System.Windows.Forms.Button Btn_DeleteUser;
        private System.Windows.Forms.Button Btn_UpdateUser;
        private System.Windows.Forms.Button Btn_AddUser;
        private System.Windows.Forms.Button Btn_UsersList;
        private System.Windows.Forms.Button Btn_TransactionHistory;
        private System.Windows.Forms.Label Lb_MenuContext;
    }
}

