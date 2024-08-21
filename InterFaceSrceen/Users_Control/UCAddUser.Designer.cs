namespace InterFaceSrceen.Users_Control
{
    partial class UCAddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.Lb_ShowUserID = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Txtb_UserName = new System.Windows.Forms.TextBox();
            this.Txtb_Password = new System.Windows.Forms.TextBox();
            this.Lb_Permissions = new System.Windows.Forms.Label();
            this.Pan_Permissions = new System.Windows.Forms.Panel();
            this.Pan_Transaction = new System.Windows.Forms.Panel();
            this.Btn_TransactionHistory = new System.Windows.Forms.CheckBox();
            this.Ckbox_AccountBalancesList = new System.Windows.Forms.CheckBox();
            this.Ckbox_AllTransaction = new System.Windows.Forms.CheckBox();
            this.Ckbox_FindAccountBalance = new System.Windows.Forms.CheckBox();
            this.Ckbox_Transfer = new System.Windows.Forms.CheckBox();
            this.Ckbox_Withdraw = new System.Windows.Forms.CheckBox();
            this.Ckbox_Deposite = new System.Windows.Forms.CheckBox();
            this.Lb_Transaction = new System.Windows.Forms.Label();
            this.Pan_ManageUsers = new System.Windows.Forms.Panel();
            this.Ckbox_AllUser = new System.Windows.Forms.CheckBox();
            this.Ck_UserList = new System.Windows.Forms.CheckBox();
            this.Ckbox_UpdateUser = new System.Windows.Forms.CheckBox();
            this.Ckbox_DeleteUser = new System.Windows.Forms.CheckBox();
            this.Ckbox_AddUser = new System.Windows.Forms.CheckBox();
            this.Lb_ManageUsers = new System.Windows.Forms.Label();
            this.Pan_ManageClient = new System.Windows.Forms.Panel();
            this.Ckbox_AllClient = new System.Windows.Forms.CheckBox();
            this.Ckbox_ClientList = new System.Windows.Forms.CheckBox();
            this.Ckbox_UpdateClient = new System.Windows.Forms.CheckBox();
            this.Ckbox_DeleteClient = new System.Windows.Forms.CheckBox();
            this.Ckbox_AddClient = new System.Windows.Forms.CheckBox();
            this.Lb_ManageClient = new System.Windows.Forms.Label();
            this.Btn_SetImage = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.Pan_Permissions.SuspendLayout();
            this.Pan_Transaction.SuspendLayout();
            this.Pan_ManageUsers.SuspendLayout();
            this.Pan_ManageClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserID.Location = new System.Drawing.Point(487, 20);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(88, 20);
            this.Lb_UserID.TabIndex = 0;
            this.Lb_UserID.Text = "User ID :";
            // 
            // Lb_ShowUserID
            // 
            this.Lb_ShowUserID.AutoSize = true;
            this.Lb_ShowUserID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowUserID.Location = new System.Drawing.Point(598, 20);
            this.Lb_ShowUserID.Name = "Lb_ShowUserID";
            this.Lb_ShowUserID.Size = new System.Drawing.Size(21, 21);
            this.Lb_ShowUserID.TabIndex = 1;
            this.Lb_ShowUserID.Text = "0";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.Location = new System.Drawing.Point(119, 142);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(107, 20);
            this.Lb_UserName.TabIndex = 2;
            this.Lb_UserName.Text = "User Name";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.Location = new System.Drawing.Point(119, 292);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(97, 20);
            this.Lb_Password.TabIndex = 3;
            this.Lb_Password.Text = "Password";
            // 
            // Txtb_UserName
            // 
            this.Txtb_UserName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_UserName.Location = new System.Drawing.Point(301, 135);
            this.Txtb_UserName.MaxLength = 10;
            this.Txtb_UserName.Name = "Txtb_UserName";
            this.Txtb_UserName.Size = new System.Drawing.Size(171, 27);
            this.Txtb_UserName.TabIndex = 0;
            this.Txtb_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_UserName_Validating);
            // 
            // Txtb_Password
            // 
            this.Txtb_Password.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Password.Location = new System.Drawing.Point(301, 285);
            this.Txtb_Password.MaxLength = 4;
            this.Txtb_Password.Name = "Txtb_Password";
            this.Txtb_Password.Size = new System.Drawing.Size(171, 27);
            this.Txtb_Password.TabIndex = 1;
            this.Txtb_Password.UseSystemPasswordChar = true;
            this.Txtb_Password.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_Password_Validating);
            // 
            // Lb_Permissions
            // 
            this.Lb_Permissions.AutoSize = true;
            this.Lb_Permissions.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Permissions.Location = new System.Drawing.Point(96, 470);
            this.Lb_Permissions.Name = "Lb_Permissions";
            this.Lb_Permissions.Size = new System.Drawing.Size(120, 20);
            this.Lb_Permissions.TabIndex = 6;
            this.Lb_Permissions.Text = "Permissions";
            // 
            // Pan_Permissions
            // 
            this.Pan_Permissions.Controls.Add(this.Pan_Transaction);
            this.Pan_Permissions.Controls.Add(this.Pan_ManageUsers);
            this.Pan_Permissions.Controls.Add(this.Pan_ManageClient);
            this.Pan_Permissions.Location = new System.Drawing.Point(262, 362);
            this.Pan_Permissions.Name = "Pan_Permissions";
            this.Pan_Permissions.Size = new System.Drawing.Size(789, 332);
            this.Pan_Permissions.TabIndex = 7;
            // 
            // Pan_Transaction
            // 
            this.Pan_Transaction.Controls.Add(this.Btn_TransactionHistory);
            this.Pan_Transaction.Controls.Add(this.Ckbox_AccountBalancesList);
            this.Pan_Transaction.Controls.Add(this.Ckbox_AllTransaction);
            this.Pan_Transaction.Controls.Add(this.Ckbox_FindAccountBalance);
            this.Pan_Transaction.Controls.Add(this.Ckbox_Transfer);
            this.Pan_Transaction.Controls.Add(this.Ckbox_Withdraw);
            this.Pan_Transaction.Controls.Add(this.Ckbox_Deposite);
            this.Pan_Transaction.Controls.Add(this.Lb_Transaction);
            this.Pan_Transaction.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Transaction.Location = new System.Drawing.Point(536, 0);
            this.Pan_Transaction.Name = "Pan_Transaction";
            this.Pan_Transaction.Size = new System.Drawing.Size(252, 332);
            this.Pan_Transaction.TabIndex = 2;
            // 
            // Btn_TransactionHistory
            // 
            this.Btn_TransactionHistory.AutoSize = true;
            this.Btn_TransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TransactionHistory.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TransactionHistory.Location = new System.Drawing.Point(28, 289);
            this.Btn_TransactionHistory.Name = "Btn_TransactionHistory";
            this.Btn_TransactionHistory.Size = new System.Drawing.Size(178, 24);
            this.Btn_TransactionHistory.TabIndex = 21;
            this.Btn_TransactionHistory.Text = "Transaction History";
            this.Btn_TransactionHistory.UseVisualStyleBackColor = true;
            this.Btn_TransactionHistory.CheckedChanged += new System.EventHandler(this.Btn_TransactionHistory_CheckedChanged);
            // 
            // Ckbox_AccountBalancesList
            // 
            this.Ckbox_AccountBalancesList.AutoSize = true;
            this.Ckbox_AccountBalancesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_AccountBalancesList.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_AccountBalancesList.Location = new System.Drawing.Point(29, 250);
            this.Ckbox_AccountBalancesList.Name = "Ckbox_AccountBalancesList";
            this.Ckbox_AccountBalancesList.Size = new System.Drawing.Size(192, 24);
            this.Ckbox_AccountBalancesList.TabIndex = 20;
            this.Ckbox_AccountBalancesList.Text = "Account Balances List";
            this.Ckbox_AccountBalancesList.UseVisualStyleBackColor = true;
            this.Ckbox_AccountBalancesList.CheckedChanged += new System.EventHandler(this.Ckbox_AccountBalancesList_CheckedChanged);
            // 
            // Ckbox_AllTransaction
            // 
            this.Ckbox_AllTransaction.AutoSize = true;
            this.Ckbox_AllTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_AllTransaction.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_AllTransaction.Location = new System.Drawing.Point(28, 55);
            this.Ckbox_AllTransaction.Name = "Ckbox_AllTransaction";
            this.Ckbox_AllTransaction.Size = new System.Drawing.Size(48, 24);
            this.Ckbox_AllTransaction.TabIndex = 19;
            this.Ckbox_AllTransaction.Text = "All";
            this.Ckbox_AllTransaction.UseVisualStyleBackColor = true;
            this.Ckbox_AllTransaction.CheckedChanged += new System.EventHandler(this.Ckbox_AllTransaction_CheckedChanged);
            // 
            // Ckbox_FindAccountBalance
            // 
            this.Ckbox_FindAccountBalance.AutoSize = true;
            this.Ckbox_FindAccountBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_FindAccountBalance.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_FindAccountBalance.Location = new System.Drawing.Point(27, 94);
            this.Ckbox_FindAccountBalance.Name = "Ckbox_FindAccountBalance";
            this.Ckbox_FindAccountBalance.Size = new System.Drawing.Size(192, 24);
            this.Ckbox_FindAccountBalance.TabIndex = 18;
            this.Ckbox_FindAccountBalance.Text = "Find Account Balance";
            this.Ckbox_FindAccountBalance.UseVisualStyleBackColor = true;
            this.Ckbox_FindAccountBalance.CheckedChanged += new System.EventHandler(this.Ckbox_FindAccountBalance_CheckedChanged);
            // 
            // Ckbox_Transfer
            // 
            this.Ckbox_Transfer.AutoSize = true;
            this.Ckbox_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_Transfer.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_Transfer.Location = new System.Drawing.Point(28, 211);
            this.Ckbox_Transfer.Name = "Ckbox_Transfer";
            this.Ckbox_Transfer.Size = new System.Drawing.Size(92, 24);
            this.Ckbox_Transfer.TabIndex = 17;
            this.Ckbox_Transfer.Text = "Transfer";
            this.Ckbox_Transfer.UseVisualStyleBackColor = true;
            this.Ckbox_Transfer.CheckedChanged += new System.EventHandler(this.Ckbox_Transfer_CheckedChanged);
            // 
            // Ckbox_Withdraw
            // 
            this.Ckbox_Withdraw.AutoSize = true;
            this.Ckbox_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_Withdraw.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_Withdraw.Location = new System.Drawing.Point(28, 172);
            this.Ckbox_Withdraw.Name = "Ckbox_Withdraw";
            this.Ckbox_Withdraw.Size = new System.Drawing.Size(104, 24);
            this.Ckbox_Withdraw.TabIndex = 16;
            this.Ckbox_Withdraw.Text = "Withdraw";
            this.Ckbox_Withdraw.UseVisualStyleBackColor = true;
            this.Ckbox_Withdraw.CheckedChanged += new System.EventHandler(this.Ckbox_Withdraw_CheckedChanged);
            // 
            // Ckbox_Deposite
            // 
            this.Ckbox_Deposite.AutoSize = true;
            this.Ckbox_Deposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_Deposite.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_Deposite.Location = new System.Drawing.Point(27, 133);
            this.Ckbox_Deposite.Name = "Ckbox_Deposite";
            this.Ckbox_Deposite.Size = new System.Drawing.Size(93, 24);
            this.Ckbox_Deposite.TabIndex = 15;
            this.Ckbox_Deposite.Text = "Deposite";
            this.Ckbox_Deposite.UseVisualStyleBackColor = true;
            this.Ckbox_Deposite.CheckedChanged += new System.EventHandler(this.Ckbox_Deposite_CheckedChanged);
            // 
            // Lb_Transaction
            // 
            this.Lb_Transaction.AutoSize = true;
            this.Lb_Transaction.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Transaction.Location = new System.Drawing.Point(24, 19);
            this.Lb_Transaction.Name = "Lb_Transaction";
            this.Lb_Transaction.Size = new System.Drawing.Size(120, 20);
            this.Lb_Transaction.TabIndex = 6;
            this.Lb_Transaction.Text = "Transaction";
            // 
            // Pan_ManageUsers
            // 
            this.Pan_ManageUsers.Controls.Add(this.Ckbox_AllUser);
            this.Pan_ManageUsers.Controls.Add(this.Ck_UserList);
            this.Pan_ManageUsers.Controls.Add(this.Ckbox_UpdateUser);
            this.Pan_ManageUsers.Controls.Add(this.Ckbox_DeleteUser);
            this.Pan_ManageUsers.Controls.Add(this.Ckbox_AddUser);
            this.Pan_ManageUsers.Controls.Add(this.Lb_ManageUsers);
            this.Pan_ManageUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_ManageUsers.Location = new System.Drawing.Point(260, 0);
            this.Pan_ManageUsers.Name = "Pan_ManageUsers";
            this.Pan_ManageUsers.Size = new System.Drawing.Size(276, 332);
            this.Pan_ManageUsers.TabIndex = 1;
            // 
            // Ckbox_AllUser
            // 
            this.Ckbox_AllUser.AutoSize = true;
            this.Ckbox_AllUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_AllUser.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_AllUser.Location = new System.Drawing.Point(29, 57);
            this.Ckbox_AllUser.Name = "Ckbox_AllUser";
            this.Ckbox_AllUser.Size = new System.Drawing.Size(48, 24);
            this.Ckbox_AllUser.TabIndex = 14;
            this.Ckbox_AllUser.Text = "All";
            this.Ckbox_AllUser.UseVisualStyleBackColor = true;
            this.Ckbox_AllUser.CheckedChanged += new System.EventHandler(this.Ckbox_AllUser_CheckedChanged);
            // 
            // Ck_UserList
            // 
            this.Ck_UserList.AutoSize = true;
            this.Ck_UserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ck_UserList.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_UserList.Location = new System.Drawing.Point(29, 106);
            this.Ck_UserList.Name = "Ck_UserList";
            this.Ck_UserList.Size = new System.Drawing.Size(101, 24);
            this.Ck_UserList.TabIndex = 13;
            this.Ck_UserList.Text = "Users List";
            this.Ck_UserList.UseVisualStyleBackColor = true;
            this.Ck_UserList.CheckedChanged += new System.EventHandler(this.Ck_UserList_CheckedChanged);
            // 
            // Ckbox_UpdateUser
            // 
            this.Ckbox_UpdateUser.AutoSize = true;
            this.Ckbox_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_UpdateUser.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_UpdateUser.Location = new System.Drawing.Point(29, 215);
            this.Ckbox_UpdateUser.Name = "Ckbox_UpdateUser";
            this.Ckbox_UpdateUser.Size = new System.Drawing.Size(122, 24);
            this.Ckbox_UpdateUser.TabIndex = 12;
            this.Ckbox_UpdateUser.Text = "Update User";
            this.Ckbox_UpdateUser.UseVisualStyleBackColor = true;
            this.Ckbox_UpdateUser.CheckedChanged += new System.EventHandler(this.Ckbox_UpdateUser_CheckedChanged);
            // 
            // Ckbox_DeleteUser
            // 
            this.Ckbox_DeleteUser.AutoSize = true;
            this.Ckbox_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_DeleteUser.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_DeleteUser.Location = new System.Drawing.Point(29, 271);
            this.Ckbox_DeleteUser.Name = "Ckbox_DeleteUser";
            this.Ckbox_DeleteUser.Size = new System.Drawing.Size(114, 24);
            this.Ckbox_DeleteUser.TabIndex = 11;
            this.Ckbox_DeleteUser.Text = "Delete User";
            this.Ckbox_DeleteUser.UseVisualStyleBackColor = true;
            this.Ckbox_DeleteUser.CheckedChanged += new System.EventHandler(this.Ckbox_DeleteUser_CheckedChanged);
            // 
            // Ckbox_AddUser
            // 
            this.Ckbox_AddUser.AutoSize = true;
            this.Ckbox_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_AddUser.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_AddUser.Location = new System.Drawing.Point(29, 163);
            this.Ckbox_AddUser.Name = "Ckbox_AddUser";
            this.Ckbox_AddUser.Size = new System.Drawing.Size(97, 24);
            this.Ckbox_AddUser.TabIndex = 10;
            this.Ckbox_AddUser.Text = "Add User";
            this.Ckbox_AddUser.UseVisualStyleBackColor = true;
            this.Ckbox_AddUser.CheckedChanged += new System.EventHandler(this.Ckbox_AddUser_CheckedChanged);
            // 
            // Lb_ManageUsers
            // 
            this.Lb_ManageUsers.AutoSize = true;
            this.Lb_ManageUsers.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ManageUsers.Location = new System.Drawing.Point(25, 19);
            this.Lb_ManageUsers.Name = "Lb_ManageUsers";
            this.Lb_ManageUsers.Size = new System.Drawing.Size(136, 20);
            this.Lb_ManageUsers.TabIndex = 5;
            this.Lb_ManageUsers.Text = "Manage Users";
            // 
            // Pan_ManageClient
            // 
            this.Pan_ManageClient.Controls.Add(this.Ckbox_AllClient);
            this.Pan_ManageClient.Controls.Add(this.Ckbox_ClientList);
            this.Pan_ManageClient.Controls.Add(this.Ckbox_UpdateClient);
            this.Pan_ManageClient.Controls.Add(this.Ckbox_DeleteClient);
            this.Pan_ManageClient.Controls.Add(this.Ckbox_AddClient);
            this.Pan_ManageClient.Controls.Add(this.Lb_ManageClient);
            this.Pan_ManageClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_ManageClient.Location = new System.Drawing.Point(0, 0);
            this.Pan_ManageClient.Name = "Pan_ManageClient";
            this.Pan_ManageClient.Size = new System.Drawing.Size(260, 332);
            this.Pan_ManageClient.TabIndex = 0;
            // 
            // Ckbox_AllClient
            // 
            this.Ckbox_AllClient.AutoSize = true;
            this.Ckbox_AllClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_AllClient.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_AllClient.Location = new System.Drawing.Point(21, 57);
            this.Ckbox_AllClient.Name = "Ckbox_AllClient";
            this.Ckbox_AllClient.Size = new System.Drawing.Size(48, 24);
            this.Ckbox_AllClient.TabIndex = 9;
            this.Ckbox_AllClient.Text = "All";
            this.Ckbox_AllClient.UseVisualStyleBackColor = true;
            this.Ckbox_AllClient.CheckedChanged += new System.EventHandler(this.Ckbox_AllClient_CheckedChanged);
            // 
            // Ckbox_ClientList
            // 
            this.Ckbox_ClientList.AutoSize = true;
            this.Ckbox_ClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_ClientList.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_ClientList.Location = new System.Drawing.Point(21, 102);
            this.Ckbox_ClientList.Name = "Ckbox_ClientList";
            this.Ckbox_ClientList.Size = new System.Drawing.Size(111, 24);
            this.Ckbox_ClientList.TabIndex = 8;
            this.Ckbox_ClientList.Text = "Clients List";
            this.Ckbox_ClientList.UseVisualStyleBackColor = true;
            this.Ckbox_ClientList.CheckedChanged += new System.EventHandler(this.Ckbox_ClientList_CheckedChanged);
            // 
            // Ckbox_UpdateClient
            // 
            this.Ckbox_UpdateClient.AutoSize = true;
            this.Ckbox_UpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_UpdateClient.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_UpdateClient.Location = new System.Drawing.Point(21, 215);
            this.Ckbox_UpdateClient.Name = "Ckbox_UpdateClient";
            this.Ckbox_UpdateClient.Size = new System.Drawing.Size(132, 24);
            this.Ckbox_UpdateClient.TabIndex = 7;
            this.Ckbox_UpdateClient.Text = "Update Client";
            this.Ckbox_UpdateClient.UseVisualStyleBackColor = true;
            this.Ckbox_UpdateClient.CheckedChanged += new System.EventHandler(this.Ckbox_UpdateClient_CheckedChanged);
            // 
            // Ckbox_DeleteClient
            // 
            this.Ckbox_DeleteClient.AutoSize = true;
            this.Ckbox_DeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_DeleteClient.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_DeleteClient.Location = new System.Drawing.Point(21, 271);
            this.Ckbox_DeleteClient.Name = "Ckbox_DeleteClient";
            this.Ckbox_DeleteClient.Size = new System.Drawing.Size(124, 24);
            this.Ckbox_DeleteClient.TabIndex = 6;
            this.Ckbox_DeleteClient.Text = "Delete Client";
            this.Ckbox_DeleteClient.UseVisualStyleBackColor = true;
            this.Ckbox_DeleteClient.CheckedChanged += new System.EventHandler(this.Ckbox_DeleteClient_CheckedChanged);
            // 
            // Ckbox_AddClient
            // 
            this.Ckbox_AddClient.AutoSize = true;
            this.Ckbox_AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckbox_AddClient.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ckbox_AddClient.Location = new System.Drawing.Point(21, 154);
            this.Ckbox_AddClient.Name = "Ckbox_AddClient";
            this.Ckbox_AddClient.Size = new System.Drawing.Size(107, 24);
            this.Ckbox_AddClient.TabIndex = 5;
            this.Ckbox_AddClient.Text = "Add Client";
            this.Ckbox_AddClient.UseVisualStyleBackColor = true;
            this.Ckbox_AddClient.CheckedChanged += new System.EventHandler(this.Ckbox_AddClient_CheckedChanged);
            // 
            // Lb_ManageClient
            // 
            this.Lb_ManageClient.AutoSize = true;
            this.Lb_ManageClient.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ManageClient.Location = new System.Drawing.Point(17, 19);
            this.Lb_ManageClient.Name = "Lb_ManageClient";
            this.Lb_ManageClient.Size = new System.Drawing.Size(139, 20);
            this.Lb_ManageClient.TabIndex = 4;
            this.Lb_ManageClient.Text = "Manage Client";
            // 
            // Btn_SetImage
            // 
            this.Btn_SetImage.FlatAppearance.BorderSize = 0;
            this.Btn_SetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SetImage.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SetImage.Location = new System.Drawing.Point(836, 292);
            this.Btn_SetImage.Name = "Btn_SetImage";
            this.Btn_SetImage.Size = new System.Drawing.Size(183, 53);
            this.Btn_SetImage.TabIndex = 9;
            this.Btn_SetImage.Text = "Set Image";
            this.Btn_SetImage.UseVisualStyleBackColor = true;
            this.Btn_SetImage.Click += new System.EventHandler(this.Btn_SetImage_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(855, 736);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(164, 64);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.BackgroundImage = global::InterFaceSrceen.Properties.Resources.visual;
            this.Btn_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ShowPassword.FlatAppearance.BorderSize = 0;
            this.Btn_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShowPassword.ImageIndex = 4;
            this.Btn_ShowPassword.Location = new System.Drawing.Point(501, 285);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(46, 28);
            this.Btn_ShowPassword.TabIndex = 11;
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            this.Btn_ShowPassword.MouseEnter += new System.EventHandler(this.Btn_ShowPassword_MouseEnter);
            this.Btn_ShowPassword.MouseLeave += new System.EventHandler(this.Btn_ShowPassword_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(836, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Pan_Main
            // 
            this.Pan_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Main.Location = new System.Drawing.Point(0, 0);
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.Size = new System.Drawing.Size(1201, 803);
            this.Pan_Main.TabIndex = 12;
            // 
            // UCAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_ShowPassword);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_SetImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pan_Permissions);
            this.Controls.Add(this.Lb_Permissions);
            this.Controls.Add(this.Txtb_Password);
            this.Controls.Add(this.Txtb_UserName);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Lb_ShowUserID);
            this.Controls.Add(this.Lb_UserID);
            this.Controls.Add(this.Pan_Main);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCAddUser";
            this.Size = new System.Drawing.Size(1201, 803);
            this.Pan_Permissions.ResumeLayout(false);
            this.Pan_Transaction.ResumeLayout(false);
            this.Pan_Transaction.PerformLayout();
            this.Pan_ManageUsers.ResumeLayout(false);
            this.Pan_ManageUsers.PerformLayout();
            this.Pan_ManageClient.ResumeLayout(false);
            this.Pan_ManageClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.Label Lb_ShowUserID;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox Txtb_UserName;
        private System.Windows.Forms.TextBox Txtb_Password;
        private System.Windows.Forms.Label Lb_Permissions;
        private System.Windows.Forms.Panel Pan_Permissions;
        private System.Windows.Forms.Panel Pan_ManageUsers;
        private System.Windows.Forms.Panel Pan_ManageClient;
        private System.Windows.Forms.Panel Pan_Transaction;
        private System.Windows.Forms.Label Lb_ManageClient;
        private System.Windows.Forms.CheckBox Ckbox_ClientList;
        private System.Windows.Forms.CheckBox Ckbox_UpdateClient;
        private System.Windows.Forms.CheckBox Ckbox_DeleteClient;
        private System.Windows.Forms.CheckBox Ckbox_AddClient;
        private System.Windows.Forms.CheckBox Ckbox_AllUser;
        private System.Windows.Forms.CheckBox Ck_UserList;
        private System.Windows.Forms.CheckBox Ckbox_UpdateUser;
        private System.Windows.Forms.CheckBox Ckbox_DeleteUser;
        private System.Windows.Forms.CheckBox Ckbox_AddUser;
        private System.Windows.Forms.Label Lb_ManageUsers;
        private System.Windows.Forms.CheckBox Ckbox_AllClient;
        private System.Windows.Forms.CheckBox Ckbox_AllTransaction;
        private System.Windows.Forms.CheckBox Ckbox_FindAccountBalance;
        private System.Windows.Forms.CheckBox Ckbox_Transfer;
        private System.Windows.Forms.CheckBox Ckbox_Withdraw;
        private System.Windows.Forms.CheckBox Ckbox_Deposite;
        private System.Windows.Forms.Label Lb_Transaction;
        private System.Windows.Forms.CheckBox Ckbox_AccountBalancesList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_SetImage;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_ShowPassword;
        private System.Windows.Forms.CheckBox Btn_TransactionHistory;
        private System.Windows.Forms.Panel Pan_Main;
    }
}
