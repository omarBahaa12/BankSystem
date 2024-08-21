namespace InterFaceSrceen.Users_Control
{
    partial class UCDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashboard));
            this.Pan_DashBoard = new System.Windows.Forms.Panel();
            this.Pan_UserNumber = new System.Windows.Forms.Panel();
            this.Lb_NumberUser = new System.Windows.Forms.Label();
            this.Lb_NumberOfUser = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pan_ClientsNumber = new System.Windows.Forms.Panel();
            this.Lb_NumberClients = new System.Windows.Forms.Label();
            this.Lb_NumberOfClients = new System.Windows.Forms.Label();
            this.Pan_TotalBalance = new System.Windows.Forms.Panel();
            this.Lb_NumberTotalBalances = new System.Windows.Forms.Label();
            this.Lb_TotalBalances = new System.Windows.Forms.Label();
            this.Pan_DashBoard.SuspendLayout();
            this.Pan_UserNumber.SuspendLayout();
            this.Pan_ClientsNumber.SuspendLayout();
            this.Pan_TotalBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_DashBoard
            // 
            this.Pan_DashBoard.Controls.Add(this.Pan_UserNumber);
            this.Pan_DashBoard.Controls.Add(this.Pan_ClientsNumber);
            this.Pan_DashBoard.Controls.Add(this.Pan_TotalBalance);
            this.Pan_DashBoard.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pan_DashBoard.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pan_DashBoard.Location = new System.Drawing.Point(750, 0);
            this.Pan_DashBoard.Name = "Pan_DashBoard";
            this.Pan_DashBoard.Size = new System.Drawing.Size(490, 905);
            this.Pan_DashBoard.TabIndex = 3;
            // 
            // Pan_UserNumber
            // 
            this.Pan_UserNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_UserNumber.Controls.Add(this.Lb_NumberUser);
            this.Pan_UserNumber.Controls.Add(this.Lb_NumberOfUser);
            this.Pan_UserNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_UserNumber.Enabled = false;
            this.Pan_UserNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pan_UserNumber.Location = new System.Drawing.Point(0, 20);
            this.Pan_UserNumber.Margin = new System.Windows.Forms.Padding(40);
            this.Pan_UserNumber.Name = "Pan_UserNumber";
            this.Pan_UserNumber.Size = new System.Drawing.Size(490, 295);
            this.Pan_UserNumber.TabIndex = 2;
            // 
            // Lb_NumberUser
            // 
            this.Lb_NumberUser.AutoSize = true;
            this.Lb_NumberUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumberUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_NumberUser.Location = new System.Drawing.Point(107, 105);
            this.Lb_NumberUser.Name = "Lb_NumberUser";
            this.Lb_NumberUser.Size = new System.Drawing.Size(0, 25);
            this.Lb_NumberUser.TabIndex = 1;
            // 
            // Lb_NumberOfUser
            // 
            this.Lb_NumberOfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumberOfUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_NumberOfUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_NumberOfUser.ImageIndex = 1;
            this.Lb_NumberOfUser.ImageList = this.imageList1;
            this.Lb_NumberOfUser.Location = new System.Drawing.Point(92, 6);
            this.Lb_NumberOfUser.Name = "Lb_NumberOfUser";
            this.Lb_NumberOfUser.Size = new System.Drawing.Size(281, 65);
            this.Lb_NumberOfUser.TabIndex = 0;
            this.Lb_NumberOfUser.Text = "Number Of Users :";
            this.Lb_NumberOfUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "client.png");
            this.imageList1.Images.SetKeyName(1, "customer-satisfaction.png");
            this.imageList1.Images.SetKeyName(2, "gross.png");
            // 
            // Pan_ClientsNumber
            // 
            this.Pan_ClientsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_ClientsNumber.Controls.Add(this.Lb_NumberClients);
            this.Pan_ClientsNumber.Controls.Add(this.Lb_NumberOfClients);
            this.Pan_ClientsNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_ClientsNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pan_ClientsNumber.Location = new System.Drawing.Point(0, 315);
            this.Pan_ClientsNumber.Margin = new System.Windows.Forms.Padding(40);
            this.Pan_ClientsNumber.Name = "Pan_ClientsNumber";
            this.Pan_ClientsNumber.Size = new System.Drawing.Size(490, 295);
            this.Pan_ClientsNumber.TabIndex = 1;
            // 
            // Lb_NumberClients
            // 
            this.Lb_NumberClients.AutoSize = true;
            this.Lb_NumberClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumberClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_NumberClients.Location = new System.Drawing.Point(92, 149);
            this.Lb_NumberClients.Name = "Lb_NumberClients";
            this.Lb_NumberClients.Size = new System.Drawing.Size(0, 25);
            this.Lb_NumberClients.TabIndex = 1;
            // 
            // Lb_NumberOfClients
            // 
            this.Lb_NumberOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumberOfClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_NumberOfClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_NumberOfClients.ImageIndex = 0;
            this.Lb_NumberOfClients.ImageList = this.imageList1;
            this.Lb_NumberOfClients.Location = new System.Drawing.Point(81, 28);
            this.Lb_NumberOfClients.Name = "Lb_NumberOfClients";
            this.Lb_NumberOfClients.Size = new System.Drawing.Size(292, 62);
            this.Lb_NumberOfClients.TabIndex = 0;
            this.Lb_NumberOfClients.Text = "Number Of Clients :";
            this.Lb_NumberOfClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pan_TotalBalance
            // 
            this.Pan_TotalBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_TotalBalance.Controls.Add(this.Lb_NumberTotalBalances);
            this.Pan_TotalBalance.Controls.Add(this.Lb_TotalBalances);
            this.Pan_TotalBalance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_TotalBalance.Location = new System.Drawing.Point(0, 610);
            this.Pan_TotalBalance.Margin = new System.Windows.Forms.Padding(40);
            this.Pan_TotalBalance.Name = "Pan_TotalBalance";
            this.Pan_TotalBalance.Size = new System.Drawing.Size(490, 295);
            this.Pan_TotalBalance.TabIndex = 2;
            // 
            // Lb_NumberTotalBalances
            // 
            this.Lb_NumberTotalBalances.AutoSize = true;
            this.Lb_NumberTotalBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumberTotalBalances.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_NumberTotalBalances.Location = new System.Drawing.Point(107, 152);
            this.Lb_NumberTotalBalances.Name = "Lb_NumberTotalBalances";
            this.Lb_NumberTotalBalances.Size = new System.Drawing.Size(0, 25);
            this.Lb_NumberTotalBalances.TabIndex = 1;
            // 
            // Lb_TotalBalances
            // 
            this.Lb_TotalBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TotalBalances.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_TotalBalances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_TotalBalances.ImageIndex = 2;
            this.Lb_TotalBalances.ImageList = this.imageList1;
            this.Lb_TotalBalances.Location = new System.Drawing.Point(92, 25);
            this.Lb_TotalBalances.Name = "Lb_TotalBalances";
            this.Lb_TotalBalances.Size = new System.Drawing.Size(265, 67);
            this.Lb_TotalBalances.TabIndex = 0;
            this.Lb_TotalBalances.Text = "Total Balances : ";
            this.Lb_TotalBalances.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan_DashBoard);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(1240, 905);
            this.Pan_DashBoard.ResumeLayout(false);
            this.Pan_UserNumber.ResumeLayout(false);
            this.Pan_UserNumber.PerformLayout();
            this.Pan_ClientsNumber.ResumeLayout(false);
            this.Pan_ClientsNumber.PerformLayout();
            this.Pan_TotalBalance.ResumeLayout(false);
            this.Pan_TotalBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_DashBoard;
        private System.Windows.Forms.Panel Pan_UserNumber;
        private System.Windows.Forms.Label Lb_NumberUser;
        private System.Windows.Forms.Label Lb_NumberOfUser;
        private System.Windows.Forms.Panel Pan_ClientsNumber;
        private System.Windows.Forms.Label Lb_NumberClients;
        private System.Windows.Forms.Label Lb_NumberOfClients;
        private System.Windows.Forms.Panel Pan_TotalBalance;
        private System.Windows.Forms.Label Lb_NumberTotalBalances;
        private System.Windows.Forms.Label Lb_TotalBalances;
        private System.Windows.Forms.ImageList imageList1;
    }
}
