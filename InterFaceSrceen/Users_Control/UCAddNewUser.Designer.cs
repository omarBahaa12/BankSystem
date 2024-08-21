namespace InterFaceSrceen.Users_Control
{
    partial class UCAddNewUser
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Client List");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Add Client");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete Client");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Update Client");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Manage Client", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Manage User");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Transactions");
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.Lb_ShowUserID = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Lb_Permissions = new System.Windows.Forms.Label();
            this.Tview_Permission = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserID.Location = new System.Drawing.Point(324, 37);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(96, 24);
            this.Lb_UserID.TabIndex = 0;
            this.Lb_UserID.Text = "User ID : ";
            // 
            // Lb_ShowUserID
            // 
            this.Lb_ShowUserID.AutoSize = true;
            this.Lb_ShowUserID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowUserID.Location = new System.Drawing.Point(436, 37);
            this.Lb_ShowUserID.Name = "Lb_ShowUserID";
            this.Lb_ShowUserID.Size = new System.Drawing.Size(22, 24);
            this.Lb_ShowUserID.TabIndex = 1;
            this.Lb_ShowUserID.Text = "0";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.Location = new System.Drawing.Point(90, 141);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(110, 24);
            this.Lb_UserName.TabIndex = 2;
            this.Lb_UserName.Text = "User Name";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.Location = new System.Drawing.Point(90, 277);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(95, 24);
            this.Lb_Password.TabIndex = 3;
            this.Lb_Password.Text = "Password";
            // 
            // Lb_Permissions
            // 
            this.Lb_Permissions.AutoSize = true;
            this.Lb_Permissions.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Permissions.Location = new System.Drawing.Point(90, 406);
            this.Lb_Permissions.Name = "Lb_Permissions";
            this.Lb_Permissions.Size = new System.Drawing.Size(96, 24);
            this.Lb_Permissions.TabIndex = 4;
            this.Lb_Permissions.Text = "User ID : ";
            // 
            // Tview_Permission
            // 
            this.Tview_Permission.Location = new System.Drawing.Point(328, 365);
            this.Tview_Permission.Name = "Tview_Permission";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Client List";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Add Client";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Delete Client";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Update Client";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Manage Client";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Manage User";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Transactions";
            this.Tview_Permission.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.Tview_Permission.Size = new System.Drawing.Size(206, 141);
            this.Tview_Permission.TabIndex = 5;
            // 
            // UCAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tview_Permission);
            this.Controls.Add(this.Lb_Permissions);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Lb_ShowUserID);
            this.Controls.Add(this.Lb_UserID);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCAddNewUser";
            this.Size = new System.Drawing.Size(796, 571);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.Label Lb_ShowUserID;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.Label Lb_Permissions;
        private System.Windows.Forms.TreeView Tview_Permission;
    }
}
