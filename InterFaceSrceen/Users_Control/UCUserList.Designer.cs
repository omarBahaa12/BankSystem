namespace InterFaceSrceen.Users_Control
{
    partial class UCUserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataG_UserList = new System.Windows.Forms.DataGridView();
            this.Lb_FilterBy = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Cmbox_Filterby = new System.Windows.Forms.ComboBox();
            this.Txtb_UserName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_UserList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataG_UserList
            // 
            this.DataG_UserList.AllowUserToAddRows = false;
            this.DataG_UserList.AllowUserToDeleteRows = false;
            this.DataG_UserList.AllowUserToResizeColumns = false;
            this.DataG_UserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataG_UserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataG_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataG_UserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataG_UserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataG_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataG_UserList.ColumnHeadersHeight = 35;
            this.DataG_UserList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_UserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataG_UserList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataG_UserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            this.DataG_UserList.Location = new System.Drawing.Point(0, 180);
            this.DataG_UserList.Name = "DataG_UserList";
            this.DataG_UserList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_UserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataG_UserList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DataG_UserList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataG_UserList.RowTemplate.Height = 24;
            this.DataG_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataG_UserList.Size = new System.Drawing.Size(1145, 508);
            this.DataG_UserList.TabIndex = 0;
            // 
            // Lb_FilterBy
            // 
            this.Lb_FilterBy.AutoSize = true;
            this.Lb_FilterBy.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FilterBy.Location = new System.Drawing.Point(698, 76);
            this.Lb_FilterBy.Name = "Lb_FilterBy";
            this.Lb_FilterBy.Size = new System.Drawing.Size(85, 20);
            this.Lb_FilterBy.TabIndex = 1;
            this.Lb_FilterBy.Text = "Filter By";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.Location = new System.Drawing.Point(172, 74);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(107, 20);
            this.Lb_UserName.TabIndex = 2;
            this.Lb_UserName.Text = "User Name";
            // 
            // Cmbox_Filterby
            // 
            this.Cmbox_Filterby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmbox_Filterby.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbox_Filterby.FormattingEnabled = true;
            this.Cmbox_Filterby.Items.AddRange(new object[] {
            "ID (Asc)",
            "ID (Desc)",
            "User Name (Asc)",
            "User Name (Desc)"});
            this.Cmbox_Filterby.Location = new System.Drawing.Point(802, 74);
            this.Cmbox_Filterby.Name = "Cmbox_Filterby";
            this.Cmbox_Filterby.Size = new System.Drawing.Size(187, 28);
            this.Cmbox_Filterby.TabIndex = 3;
            this.Cmbox_Filterby.SelectedIndexChanged += new System.EventHandler(this.Cmbox_Filterby_SelectedIndexChanged);
            // 
            // Txtb_UserName
            // 
            this.Txtb_UserName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_UserName.Location = new System.Drawing.Point(301, 69);
            this.Txtb_UserName.Name = "Txtb_UserName";
            this.Txtb_UserName.Size = new System.Drawing.Size(174, 27);
            this.Txtb_UserName.TabIndex = 4;
            this.Txtb_UserName.TextChanged += new System.EventHandler(this.Txtb_UserName_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 56);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // UCUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txtb_UserName);
            this.Controls.Add(this.Cmbox_Filterby);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Lb_FilterBy);
            this.Controls.Add(this.DataG_UserList);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCUserList";
            this.Size = new System.Drawing.Size(1145, 688);
            ((System.ComponentModel.ISupportInitialize)(this.DataG_UserList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataG_UserList;
        private System.Windows.Forms.Label Lb_FilterBy;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.ComboBox Cmbox_Filterby;
        private System.Windows.Forms.TextBox Txtb_UserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}
