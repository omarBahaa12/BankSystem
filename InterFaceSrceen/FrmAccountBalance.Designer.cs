namespace InterFaceSrceen
{
    partial class FrmAccountBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountBalance));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Pan_TitleBar = new System.Windows.Forms.Panel();
            this.Lb_Header = new System.Windows.Forms.Label();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txtb_AccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_AccountNumber = new System.Windows.Forms.Label();
            this.Lb_FullName = new System.Windows.Forms.Label();
            this.Lb_Pincode = new System.Windows.Forms.Label();
            this.Lb_AccountBalance = new System.Windows.Forms.Label();
            this.Pan_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "maximize.png");
            this.imageList2.Images.SetKeyName(1, "minimize.png");
            this.imageList2.Images.SetKeyName(2, "exit-full-screen.png");
            this.imageList2.Images.SetKeyName(3, "search(1).png");
            // 
            // Pan_TitleBar
            // 
            this.Pan_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_TitleBar.Controls.Add(this.Lb_Header);
            this.Pan_TitleBar.Controls.Add(this.Btn_Minimize);
            this.Pan_TitleBar.Controls.Add(this.Btn_Maxmize);
            this.Pan_TitleBar.Controls.Add(this.Btn_Exit);
            this.Pan_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.Pan_TitleBar.Margin = new System.Windows.Forms.Padding(5);
            this.Pan_TitleBar.Name = "Pan_TitleBar";
            this.Pan_TitleBar.Size = new System.Drawing.Size(656, 51);
            this.Pan_TitleBar.TabIndex = 2;
            this.Pan_TitleBar.TabStop = true;
            this.Pan_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Lb_Header
            // 
            this.Lb_Header.AutoSize = true;
            this.Lb_Header.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_Header.Location = new System.Drawing.Point(13, 6);
            this.Lb_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Header.Name = "Lb_Header";
            this.Lb_Header.Size = new System.Drawing.Size(223, 32);
            this.Lb_Header.TabIndex = 3;
            this.Lb_Header.Text = "Account Balance";
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.ImageIndex = 1;
            this.Btn_Minimize.ImageList = this.imageList2;
            this.Btn_Minimize.Location = new System.Drawing.Point(449, 0);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(69, 51);
            this.Btn_Minimize.TabIndex = 2;
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Maxmize
            // 
            this.Btn_Maxmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Maxmize.FlatAppearance.BorderSize = 0;
            this.Btn_Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maxmize.ImageIndex = 0;
            this.Btn_Maxmize.ImageList = this.imageList2;
            this.Btn_Maxmize.Location = new System.Drawing.Point(518, 0);
            this.Btn_Maxmize.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Maxmize.Name = "Btn_Maxmize";
            this.Btn_Maxmize.Size = new System.Drawing.Size(69, 51);
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
            this.Btn_Exit.Location = new System.Drawing.Point(587, 0);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(69, 51);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.ImageIndex = 3;
            this.Btn_Search.ImageList = this.imageList2;
            this.Btn_Search.Location = new System.Drawing.Point(81, 123);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(155, 44);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txtb_AccountNumber
            // 
            this.Txtb_AccountNumber.Location = new System.Drawing.Point(304, 140);
            this.Txtb_AccountNumber.Name = "Txtb_AccountNumber";
            this.Txtb_AccountNumber.Size = new System.Drawing.Size(187, 27);
            this.Txtb_AccountNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(264, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Account Number";
            // 
            // Lb_AccountNumber
            // 
            this.Lb_AccountNumber.AutoSize = true;
            this.Lb_AccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Lb_AccountNumber.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AccountNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AccountNumber.Location = new System.Drawing.Point(77, 192);
            this.Lb_AccountNumber.Name = "Lb_AccountNumber";
            this.Lb_AccountNumber.Size = new System.Drawing.Size(0, 27);
            this.Lb_AccountNumber.TabIndex = 5;
            // 
            // Lb_FullName
            // 
            this.Lb_FullName.AutoSize = true;
            this.Lb_FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Lb_FullName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FullName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_FullName.Location = new System.Drawing.Point(77, 267);
            this.Lb_FullName.Name = "Lb_FullName";
            this.Lb_FullName.Size = new System.Drawing.Size(0, 24);
            this.Lb_FullName.TabIndex = 6;
            // 
            // Lb_Pincode
            // 
            this.Lb_Pincode.AutoSize = true;
            this.Lb_Pincode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Lb_Pincode.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Pincode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_Pincode.Location = new System.Drawing.Point(77, 423);
            this.Lb_Pincode.Name = "Lb_Pincode";
            this.Lb_Pincode.Size = new System.Drawing.Size(0, 24);
            this.Lb_Pincode.TabIndex = 7;
            // 
            // Lb_AccountBalance
            // 
            this.Lb_AccountBalance.AutoSize = true;
            this.Lb_AccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Lb_AccountBalance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AccountBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AccountBalance.Location = new System.Drawing.Point(77, 340);
            this.Lb_AccountBalance.Name = "Lb_AccountBalance";
            this.Lb_AccountBalance.Size = new System.Drawing.Size(0, 24);
            this.Lb_AccountBalance.TabIndex = 8;
            // 
            // FrmAccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 490);
            this.Controls.Add(this.Lb_AccountBalance);
            this.Controls.Add(this.Lb_Pincode);
            this.Controls.Add(this.Lb_FullName);
            this.Controls.Add(this.Lb_AccountNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtb_AccountNumber);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Pan_TitleBar);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAccountBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccountBalance";
            this.Load += new System.EventHandler(this.FrmAccountBalance_Load);
            this.Resize += new System.EventHandler(this.FrmAccountBalance_Resize);
            this.Pan_TitleBar.ResumeLayout(false);
            this.Pan_TitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel Pan_TitleBar;
        private System.Windows.Forms.Label Lb_Header;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txtb_AccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_AccountNumber;
        private System.Windows.Forms.Label Lb_FullName;
        private System.Windows.Forms.Label Lb_Pincode;
        private System.Windows.Forms.Label Lb_AccountBalance;
    }
}