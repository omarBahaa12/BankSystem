namespace InterFaceSrceen.Users_Control
{
    partial class UCaccountBalancesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lb_SearchByName = new System.Windows.Forms.Label();
            this.Txtb_Search = new System.Windows.Forms.TextBox();
            this.Cmbox_Sorting = new System.Windows.Forms.ComboBox();
            this.DataG_AccountBalancesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_AccountBalancesList)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_SearchByName
            // 
            this.Lb_SearchByName.AutoSize = true;
            this.Lb_SearchByName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SearchByName.Location = new System.Drawing.Point(104, 46);
            this.Lb_SearchByName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_SearchByName.Name = "Lb_SearchByName";
            this.Lb_SearchByName.Size = new System.Drawing.Size(107, 21);
            this.Lb_SearchByName.TabIndex = 8;
            this.Lb_SearchByName.Text = "Enter Name";
            // 
            // Txtb_Search
            // 
            this.Txtb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Search.Location = new System.Drawing.Point(294, 44);
            this.Txtb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Search.Name = "Txtb_Search";
            this.Txtb_Search.Size = new System.Drawing.Size(236, 27);
            this.Txtb_Search.TabIndex = 7;
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
            this.Cmbox_Sorting.Location = new System.Drawing.Point(886, 44);
            this.Cmbox_Sorting.Margin = new System.Windows.Forms.Padding(4);
            this.Cmbox_Sorting.Name = "Cmbox_Sorting";
            this.Cmbox_Sorting.Size = new System.Drawing.Size(226, 28);
            this.Cmbox_Sorting.Sorted = true;
            this.Cmbox_Sorting.TabIndex = 6;
            this.Cmbox_Sorting.SelectedIndexChanged += new System.EventHandler(this.Cmbox_Sorting_SelectedIndexChanged);
            // 
            // DataG_AccountBalancesList
            // 
            this.DataG_AccountBalancesList.AllowUserToAddRows = false;
            this.DataG_AccountBalancesList.AllowUserToDeleteRows = false;
            this.DataG_AccountBalancesList.AllowUserToResizeColumns = false;
            this.DataG_AccountBalancesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.DataG_AccountBalancesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataG_AccountBalancesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataG_AccountBalancesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataG_AccountBalancesList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataG_AccountBalancesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_AccountBalancesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataG_AccountBalancesList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataG_AccountBalancesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataG_AccountBalancesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataG_AccountBalancesList.Location = new System.Drawing.Point(0, 137);
            this.DataG_AccountBalancesList.Margin = new System.Windows.Forms.Padding(4);
            this.DataG_AccountBalancesList.Name = "DataG_AccountBalancesList";
            this.DataG_AccountBalancesList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_AccountBalancesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataG_AccountBalancesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataG_AccountBalancesList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataG_AccountBalancesList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataG_AccountBalancesList.RowTemplate.Height = 24;
            this.DataG_AccountBalancesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataG_AccountBalancesList.Size = new System.Drawing.Size(1342, 669);
            this.DataG_AccountBalancesList.TabIndex = 9;
            // 
            // UCaccountBalancesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataG_AccountBalancesList);
            this.Controls.Add(this.Lb_SearchByName);
            this.Controls.Add(this.Txtb_Search);
            this.Controls.Add(this.Cmbox_Sorting);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCaccountBalancesList";
            this.Size = new System.Drawing.Size(1342, 806);
            ((System.ComponentModel.ISupportInitialize)(this.DataG_AccountBalancesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_SearchByName;
        private System.Windows.Forms.TextBox Txtb_Search;
        private System.Windows.Forms.ComboBox Cmbox_Sorting;
        private System.Windows.Forms.DataGridView DataG_AccountBalancesList;
    }
}
