namespace InterFaceSrceen.Users_Control
{
    partial class UCClientsList
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
            this.Pan_ClientList = new System.Windows.Forms.Panel();
            this.Lb_SearchByName = new System.Windows.Forms.Label();
            this.Txtb_Search = new System.Windows.Forms.TextBox();
            this.Cmbox_Sorting = new System.Windows.Forms.ComboBox();
            this.DataG_ClientList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pan_ClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_ClientList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_ClientList
            // 
            this.Pan_ClientList.AutoScroll = true;
            this.Pan_ClientList.Controls.Add(this.Lb_SearchByName);
            this.Pan_ClientList.Controls.Add(this.Txtb_Search);
            this.Pan_ClientList.Controls.Add(this.Cmbox_Sorting);
            this.Pan_ClientList.Controls.Add(this.DataG_ClientList);
            this.Pan_ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_ClientList.Location = new System.Drawing.Point(0, 0);
            this.Pan_ClientList.Name = "Pan_ClientList";
            this.Pan_ClientList.Size = new System.Drawing.Size(1393, 734);
            this.Pan_ClientList.TabIndex = 4;
            // 
            // Lb_SearchByName
            // 
            this.Lb_SearchByName.AutoSize = true;
            this.Lb_SearchByName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SearchByName.Location = new System.Drawing.Point(182, 55);
            this.Lb_SearchByName.Name = "Lb_SearchByName";
            this.Lb_SearchByName.Size = new System.Drawing.Size(107, 21);
            this.Lb_SearchByName.TabIndex = 4;
            this.Lb_SearchByName.Text = "Enter Name";
            // 
            // Txtb_Search
            // 
            this.Txtb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Search.Location = new System.Drawing.Point(334, 53);
            this.Txtb_Search.Name = "Txtb_Search";
            this.Txtb_Search.Size = new System.Drawing.Size(190, 27);
            this.Txtb_Search.TabIndex = 2;
            this.Txtb_Search.TextChanged += new System.EventHandler(this.Txtb_Search_TextChanged);
            // 
            // Cmbox_Sorting
            // 
            this.Cmbox_Sorting.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbox_Sorting.FormattingEnabled = true;
            this.Cmbox_Sorting.Items.AddRange(new object[] {
            "ID (Asc)",
            "ID(Desc)",
            "Name(Asc)",
            "Name(Desc)"});
            this.Cmbox_Sorting.Location = new System.Drawing.Point(1013, 53);
            this.Cmbox_Sorting.Name = "Cmbox_Sorting";
            this.Cmbox_Sorting.Size = new System.Drawing.Size(182, 28);
            this.Cmbox_Sorting.Sorted = true;
            this.Cmbox_Sorting.TabIndex = 1;
            this.Cmbox_Sorting.SelectedIndexChanged += new System.EventHandler(this.Cmbox_Sorting_SelectedIndexChanged);
            // 
            // DataG_ClientList
            // 
            this.DataG_ClientList.AllowUserToAddRows = false;
            this.DataG_ClientList.AllowUserToDeleteRows = false;
            this.DataG_ClientList.AllowUserToResizeColumns = false;
            this.DataG_ClientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataG_ClientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataG_ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataG_ClientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataG_ClientList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataG_ClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataG_ClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataG_ClientList.ColumnHeadersHeight = 30;
            this.DataG_ClientList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataG_ClientList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataG_ClientList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataG_ClientList.Location = new System.Drawing.Point(0, 81);
            this.DataG_ClientList.Name = "DataG_ClientList";
            this.DataG_ClientList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataG_ClientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataG_ClientList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataG_ClientList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataG_ClientList.RowTemplate.DefaultCellStyle.NullValue = null;
            this.DataG_ClientList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_ClientList.RowTemplate.Height = 25;
            this.DataG_ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataG_ClientList.Size = new System.Drawing.Size(1372, 800);
            this.DataG_ClientList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 84);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // UCClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan_ClientList);
            this.Name = "UCClientsList";
            this.Size = new System.Drawing.Size(1393, 734);
            this.Pan_ClientList.ResumeLayout(false);
            this.Pan_ClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_ClientList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_ClientList;
        private System.Windows.Forms.Label Lb_SearchByName;
        private System.Windows.Forms.TextBox Txtb_Search;
        private System.Windows.Forms.ComboBox Cmbox_Sorting;
        private System.Windows.Forms.DataGridView DataG_ClientList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}
