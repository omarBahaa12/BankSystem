namespace UserInterfaceLogin
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Pan_Desgin = new System.Windows.Forms.FlowLayoutPanel();
            this.Picbox_Cib = new System.Windows.Forms.PictureBox();
            this.Pan_TitlePar = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Txtbox_UserName = new System.Windows.Forms.TextBox();
            this.Mtxtbox_Password = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pan_Desgin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Cib)).BeginInit();
            this.Pan_TitlePar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pan_Desgin
            // 
            this.Pan_Desgin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_Desgin.Controls.Add(this.Picbox_Cib);
            this.Pan_Desgin.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Desgin.Location = new System.Drawing.Point(0, 0);
            this.Pan_Desgin.Name = "Pan_Desgin";
            this.Pan_Desgin.Size = new System.Drawing.Size(342, 528);
            this.Pan_Desgin.TabIndex = 1;
            // 
            // Picbox_Cib
            // 
            this.Picbox_Cib.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Picbox_Cib.Image = global::UserInterfaceLogin.Properties.Resources.Cibbank;
            this.Picbox_Cib.Location = new System.Drawing.Point(3, 3);
            this.Picbox_Cib.Name = "Picbox_Cib";
            this.Picbox_Cib.Size = new System.Drawing.Size(339, 486);
            this.Picbox_Cib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Picbox_Cib.TabIndex = 0;
            this.Picbox_Cib.TabStop = false;
            this.Picbox_Cib.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Pan_TitlePar
            // 
            this.Pan_TitlePar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Pan_TitlePar.Controls.Add(this.Btn_Exit);
            this.Pan_TitlePar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_TitlePar.Location = new System.Drawing.Point(342, 0);
            this.Pan_TitlePar.Name = "Pan_TitlePar";
            this.Pan_TitlePar.Size = new System.Drawing.Size(468, 45);
            this.Pan_TitlePar.TabIndex = 2;
            this.Pan_TitlePar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.ImageIndex = 3;
            this.Btn_Exit.ImageList = this.imageList1;
            this.Btn_Exit.Location = new System.Drawing.Point(409, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(59, 45);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.TabStop = false;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "circle-xmark.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "padlock.png");
            this.imageList1.Images.SetKeyName(3, "power.png");
            this.imageList1.Images.SetKeyName(4, "visual.png");
            // 
            // Txtbox_UserName
            // 
            this.Txtbox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_UserName.Location = new System.Drawing.Point(572, 138);
            this.Txtbox_UserName.Name = "Txtbox_UserName";
            this.Txtbox_UserName.Size = new System.Drawing.Size(148, 28);
            this.Txtbox_UserName.TabIndex = 0;
            this.Txtbox_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.Txtbox_UserName_Validating);
            // 
            // Mtxtbox_Password
            // 
            this.Mtxtbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtbox_Password.Location = new System.Drawing.Point(572, 277);
            this.Mtxtbox_Password.Mask = "0000";
            this.Mtxtbox_Password.Name = "Mtxtbox_Password";
            this.Mtxtbox_Password.Size = new System.Drawing.Size(150, 28);
            this.Mtxtbox_Password.TabIndex = 1;
            this.Mtxtbox_Password.UseSystemPasswordChar = true;
            this.Mtxtbox_Password.Validating += new System.ComponentModel.CancelEventHandler(this.Mtxtbox_Password_Validating);
            // 
            // Btn_Login
            // 
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(593, 371);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(93, 39);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.FlatAppearance.BorderSize = 0;
            this.Btn_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShowPassword.ImageIndex = 4;
            this.Btn_ShowPassword.ImageList = this.imageList1;
            this.Btn_ShowPassword.Location = new System.Drawing.Point(739, 277);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(46, 28);
            this.Btn_ShowPassword.TabIndex = 5;
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            this.Btn_ShowPassword.MouseEnter += new System.EventHandler(this.Btn_ShowPassword_MouseEnter);
            this.Btn_ShowPassword.MouseLeave += new System.EventHandler(this.Btn_ShowPassword_MouseLeave);
            // 
            // Lb_Password
            // 
            this.Lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Password.ImageIndex = 2;
            this.Lb_Password.ImageList = this.imageList1;
            this.Lb_Password.Location = new System.Drawing.Point(381, 277);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(173, 30);
            this.Lb_Password.TabIndex = 4;
            this.Lb_Password.Text = "Password : ";
            this.Lb_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.ForeColor = System.Drawing.Color.Black;
            this.Lb_UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_UserName.ImageIndex = 1;
            this.Lb_UserName.ImageList = this.imageList1;
            this.Lb_UserName.Location = new System.Drawing.Point(377, 136);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(177, 39);
            this.Lb_UserName.TabIndex = 3;
            this.Lb_UserName.Text = "User Name :";
            this.Lb_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(810, 528);
            this.Controls.Add(this.Btn_ShowPassword);
            this.Controls.Add(this.Pan_TitlePar);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Mtxtbox_Password);
            this.Controls.Add(this.Txtbox_UserName);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Pan_Desgin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);
            this.Pan_Desgin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Cib)).EndInit();
            this.Pan_TitlePar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Pan_Desgin;
        private System.Windows.Forms.PictureBox Picbox_Cib;
        private System.Windows.Forms.Panel Pan_TitlePar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox Txtbox_UserName;
        private System.Windows.Forms.MaskedTextBox Mtxtbox_Password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_ShowPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}

