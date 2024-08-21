namespace InterFaceSrceen.Users_Control
{
    partial class UCTransactionHistory
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
            this.Lb_SearchByAccountNumber = new System.Windows.Forms.Label();
            this.Txtb_Search = new System.Windows.Forms.TextBox();
            this.DataG_TransactionsHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_TransactionsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_SearchByAccountNumber
            // 
            this.Lb_SearchByAccountNumber.AutoSize = true;
            this.Lb_SearchByAccountNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SearchByAccountNumber.Location = new System.Drawing.Point(256, 50);
            this.Lb_SearchByAccountNumber.Name = "Lb_SearchByAccountNumber";
            this.Lb_SearchByAccountNumber.Size = new System.Drawing.Size(196, 21);
            this.Lb_SearchByAccountNumber.TabIndex = 6;
            this.Lb_SearchByAccountNumber.Text = "Enter Account Number";
            // 
            // Txtb_Search
            // 
            this.Txtb_Search.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Search.Location = new System.Drawing.Point(493, 48);
            this.Txtb_Search.Name = "Txtb_Search";
            this.Txtb_Search.Size = new System.Drawing.Size(190, 28);
            this.Txtb_Search.TabIndex = 5;
            this.Txtb_Search.TextChanged += new System.EventHandler(this.Txtb_Search_TextChanged);
            // 
            // DataG_TransactionsHistory
            // 
            this.DataG_TransactionsHistory.AllowUserToAddRows = false;
            this.DataG_TransactionsHistory.AllowUserToDeleteRows = false;
            this.DataG_TransactionsHistory.AllowUserToResizeColumns = false;
            this.DataG_TransactionsHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DataG_TransactionsHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataG_TransactionsHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataG_TransactionsHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataG_TransactionsHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_TransactionsHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataG_TransactionsHistory.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_TransactionsHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataG_TransactionsHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataG_TransactionsHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.DataG_TransactionsHistory.Location = new System.Drawing.Point(0, -11);
            this.DataG_TransactionsHistory.Name = "DataG_TransactionsHistory";
            this.DataG_TransactionsHistory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataG_TransactionsHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataG_TransactionsHistory.RowHeadersWidth = 51;
            this.DataG_TransactionsHistory.RowTemplate.Height = 24;
            this.DataG_TransactionsHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataG_TransactionsHistory.Size = new System.Drawing.Size(1156, 661);
            this.DataG_TransactionsHistory.TabIndex = 7;
            // 
            // UCTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataG_TransactionsHistory);
            this.Controls.Add(this.Lb_SearchByAccountNumber);
            this.Controls.Add(this.Txtb_Search);
            this.Name = "UCTransactionHistory";
            this.Size = new System.Drawing.Size(1156, 650);
            ((System.ComponentModel.ISupportInitialize)(this.DataG_TransactionsHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_SearchByAccountNumber;
        private System.Windows.Forms.TextBox Txtb_Search;
        private System.Windows.Forms.DataGridView DataG_TransactionsHistory;
    }
}
