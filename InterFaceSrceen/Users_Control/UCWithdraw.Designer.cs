namespace InterFaceSrceen.Users_Control
{
    partial class UCWithdraw
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
            this.Pan_Search = new System.Windows.Forms.Panel();
            this.Lb_EnterPincode = new System.Windows.Forms.Label();
            this.Txtb_AccountNumber = new System.Windows.Forms.TextBox();
            this.Lb_EnterAccountNumber = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Mtxtb_Pincode = new System.Windows.Forms.MaskedTextBox();
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.Lb_Maxium = new System.Windows.Forms.Label();
            this.Mtxtb_Deposite = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Withdraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_AccountBalance = new System.Windows.Forms.Label();
            this.Lb_Phone = new System.Windows.Forms.Label();
            this.Lb_FullName = new System.Windows.Forms.Label();
            this.Lb_AccountNumber = new System.Windows.Forms.Label();
            this.Pan_Search.SuspendLayout();
            this.Pan_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pan_Search
            // 
            this.Pan_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_Search.Controls.Add(this.Lb_EnterPincode);
            this.Pan_Search.Controls.Add(this.Txtb_AccountNumber);
            this.Pan_Search.Controls.Add(this.Lb_EnterAccountNumber);
            this.Pan_Search.Controls.Add(this.Btn_Search);
            this.Pan_Search.Controls.Add(this.Mtxtb_Pincode);
            this.Pan_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_Search.Location = new System.Drawing.Point(0, 0);
            this.Pan_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_Search.Name = "Pan_Search";
            this.Pan_Search.Size = new System.Drawing.Size(1187, 239);
            this.Pan_Search.TabIndex = 6;
            // 
            // Lb_EnterPincode
            // 
            this.Lb_EnterPincode.AutoSize = true;
            this.Lb_EnterPincode.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterPincode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_EnterPincode.Location = new System.Drawing.Point(762, 69);
            this.Lb_EnterPincode.Name = "Lb_EnterPincode";
            this.Lb_EnterPincode.Size = new System.Drawing.Size(137, 21);
            this.Lb_EnterPincode.TabIndex = 7;
            this.Lb_EnterPincode.Text = "Enter Pincode : ";
            // 
            // Txtb_AccountNumber
            // 
            this.Txtb_AccountNumber.Location = new System.Drawing.Point(285, 65);
            this.Txtb_AccountNumber.Name = "Txtb_AccountNumber";
            this.Txtb_AccountNumber.Size = new System.Drawing.Size(163, 25);
            this.Txtb_AccountNumber.TabIndex = 6;
            // 
            // Lb_EnterAccountNumber
            // 
            this.Lb_EnterAccountNumber.AutoSize = true;
            this.Lb_EnterAccountNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterAccountNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_EnterAccountNumber.Location = new System.Drawing.Point(60, 66);
            this.Lb_EnterAccountNumber.Name = "Lb_EnterAccountNumber";
            this.Lb_EnterAccountNumber.Size = new System.Drawing.Size(206, 21);
            this.Lb_EnterAccountNumber.TabIndex = 5;
            this.Lb_EnterAccountNumber.Text = "Enter Account Number :";
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Search.Location = new System.Drawing.Point(519, 139);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(165, 54);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Mtxtb_Pincode
            // 
            this.Mtxtb_Pincode.Location = new System.Drawing.Point(918, 68);
            this.Mtxtb_Pincode.Margin = new System.Windows.Forms.Padding(4);
            this.Mtxtb_Pincode.Mask = "0000";
            this.Mtxtb_Pincode.Name = "Mtxtb_Pincode";
            this.Mtxtb_Pincode.Size = new System.Drawing.Size(209, 25);
            this.Mtxtb_Pincode.TabIndex = 0;
            this.Mtxtb_Pincode.ValidatingType = typeof(int);
            // 
            // Pan_Main
            // 
            this.Pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Pan_Main.Controls.Add(this.Lb_Maxium);
            this.Pan_Main.Controls.Add(this.Mtxtb_Deposite);
            this.Pan_Main.Controls.Add(this.Btn_Withdraw);
            this.Pan_Main.Controls.Add(this.pictureBox1);
            this.Pan_Main.Controls.Add(this.Lb_AccountBalance);
            this.Pan_Main.Controls.Add(this.Lb_Phone);
            this.Pan_Main.Controls.Add(this.Lb_FullName);
            this.Pan_Main.Controls.Add(this.Lb_AccountNumber);
            this.Pan_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Main.Location = new System.Drawing.Point(0, 239);
            this.Pan_Main.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.Size = new System.Drawing.Size(1187, 490);
            this.Pan_Main.TabIndex = 7;
            // 
            // Lb_Maxium
            // 
            this.Lb_Maxium.AutoSize = true;
            this.Lb_Maxium.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Maxium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_Maxium.Location = new System.Drawing.Point(706, 334);
            this.Lb_Maxium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Maxium.Name = "Lb_Maxium";
            this.Lb_Maxium.Size = new System.Drawing.Size(396, 20);
            this.Lb_Maxium.TabIndex = 12;
            this.Lb_Maxium.Text = "The Maxium of Withdraw Amount (50000)";
            // 
            // Mtxtb_Deposite
            // 
            this.Mtxtb_Deposite.Location = new System.Drawing.Point(854, 402);
            this.Mtxtb_Deposite.Margin = new System.Windows.Forms.Padding(4);
            this.Mtxtb_Deposite.Mask = "00000";
            this.Mtxtb_Deposite.Name = "Mtxtb_Deposite";
            this.Mtxtb_Deposite.Size = new System.Drawing.Size(209, 25);
            this.Mtxtb_Deposite.TabIndex = 1;
            this.Mtxtb_Deposite.ValidatingType = typeof(int);
            // 
            // Btn_Withdraw
            // 
            this.Btn_Withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.Btn_Withdraw.FlatAppearance.BorderSize = 0;
            this.Btn_Withdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.Btn_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Withdraw.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Withdraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Withdraw.Location = new System.Drawing.Point(586, 384);
            this.Btn_Withdraw.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Withdraw.Name = "Btn_Withdraw";
            this.Btn_Withdraw.Size = new System.Drawing.Size(185, 61);
            this.Btn_Withdraw.TabIndex = 7;
            this.Btn_Withdraw.Text = "Withdraw";
            this.Btn_Withdraw.UseVisualStyleBackColor = false;
            this.Btn_Withdraw.Click += new System.EventHandler(this.Btn_Withdraw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterFaceSrceen.Properties.Resources.cash_withdrawal;
            this.pictureBox1.Location = new System.Drawing.Point(813, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Lb_AccountBalance
            // 
            this.Lb_AccountBalance.AutoSize = true;
            this.Lb_AccountBalance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AccountBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AccountBalance.Location = new System.Drawing.Point(112, 391);
            this.Lb_AccountBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_AccountBalance.Name = "Lb_AccountBalance";
            this.Lb_AccountBalance.Size = new System.Drawing.Size(0, 24);
            this.Lb_AccountBalance.TabIndex = 10;
            // 
            // Lb_Phone
            // 
            this.Lb_Phone.AutoSize = true;
            this.Lb_Phone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Phone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_Phone.Location = new System.Drawing.Point(112, 254);
            this.Lb_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Phone.Name = "Lb_Phone";
            this.Lb_Phone.Size = new System.Drawing.Size(0, 24);
            this.Lb_Phone.TabIndex = 9;
            // 
            // Lb_FullName
            // 
            this.Lb_FullName.AutoSize = true;
            this.Lb_FullName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FullName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_FullName.Location = new System.Drawing.Point(112, 128);
            this.Lb_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_FullName.Name = "Lb_FullName";
            this.Lb_FullName.Size = new System.Drawing.Size(0, 24);
            this.Lb_FullName.TabIndex = 8;
            // 
            // Lb_AccountNumber
            // 
            this.Lb_AccountNumber.AutoSize = true;
            this.Lb_AccountNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AccountNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AccountNumber.Location = new System.Drawing.Point(448, 22);
            this.Lb_AccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_AccountNumber.Name = "Lb_AccountNumber";
            this.Lb_AccountNumber.Size = new System.Drawing.Size(0, 24);
            this.Lb_AccountNumber.TabIndex = 7;
            // 
            // UCWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan_Main);
            this.Controls.Add(this.Pan_Search);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCWithdraw";
            this.Size = new System.Drawing.Size(1187, 729);
            this.Pan_Search.ResumeLayout(false);
            this.Pan_Search.PerformLayout();
            this.Pan_Main.ResumeLayout(false);
            this.Pan_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Search;
        private System.Windows.Forms.MaskedTextBox Mtxtb_Pincode;
        private System.Windows.Forms.Panel Pan_Main;
        private System.Windows.Forms.Label Lb_Maxium;
        private System.Windows.Forms.MaskedTextBox Mtxtb_Deposite;
        private System.Windows.Forms.Button Btn_Withdraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_AccountBalance;
        private System.Windows.Forms.Label Lb_Phone;
        private System.Windows.Forms.Label Lb_FullName;
        private System.Windows.Forms.Label Lb_AccountNumber;
        private System.Windows.Forms.TextBox Txtb_AccountNumber;
        private System.Windows.Forms.Label Lb_EnterAccountNumber;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lb_EnterPincode;
    }
}
