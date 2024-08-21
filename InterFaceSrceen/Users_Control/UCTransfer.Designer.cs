namespace InterFaceSrceen.Users_Control
{
    partial class UCTransfer
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
            this.Lb_AccountNumberTransferFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Transfer = new System.Windows.Forms.Button();
            this.Txtb_TransferFrom = new System.Windows.Forms.TextBox();
            this.Txtb_TransferTo = new System.Windows.Forms.TextBox();
            this.Lb_AmountofTransfer = new System.Windows.Forms.Label();
            this.Mtxtb_AmountofTransfer = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lb_AccountNumberTransferFrom
            // 
            this.Lb_AccountNumberTransferFrom.AutoSize = true;
            this.Lb_AccountNumberTransferFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_AccountNumberTransferFrom.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AccountNumberTransferFrom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AccountNumberTransferFrom.Location = new System.Drawing.Point(117, 121);
            this.Lb_AccountNumberTransferFrom.Name = "Lb_AccountNumberTransferFrom";
            this.Lb_AccountNumberTransferFrom.Size = new System.Drawing.Size(292, 24);
            this.Lb_AccountNumberTransferFrom.TabIndex = 0;
            this.Lb_AccountNumberTransferFrom.Text = "Account Number Transfer from";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(117, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number Transfer to";
            // 
            // Btn_Transfer
            // 
            this.Btn_Transfer.FlatAppearance.BorderSize = 0;
            this.Btn_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transfer.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Transfer.Location = new System.Drawing.Point(334, 454);
            this.Btn_Transfer.Name = "Btn_Transfer";
            this.Btn_Transfer.Size = new System.Drawing.Size(173, 61);
            this.Btn_Transfer.TabIndex = 2;
            this.Btn_Transfer.Text = "Transfer";
            this.Btn_Transfer.UseVisualStyleBackColor = true;
            this.Btn_Transfer.Click += new System.EventHandler(this.Btn_Transfer_Click);
            // 
            // Txtb_TransferFrom
            // 
            this.Txtb_TransferFrom.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_TransferFrom.Location = new System.Drawing.Point(456, 120);
            this.Txtb_TransferFrom.Name = "Txtb_TransferFrom";
            this.Txtb_TransferFrom.Size = new System.Drawing.Size(139, 27);
            this.Txtb_TransferFrom.TabIndex = 3;
            // 
            // Txtb_TransferTo
            // 
            this.Txtb_TransferTo.Location = new System.Drawing.Point(456, 242);
            this.Txtb_TransferTo.Name = "Txtb_TransferTo";
            this.Txtb_TransferTo.Size = new System.Drawing.Size(139, 25);
            this.Txtb_TransferTo.TabIndex = 4;
            // 
            // Lb_AmountofTransfer
            // 
            this.Lb_AmountofTransfer.AutoSize = true;
            this.Lb_AmountofTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_AmountofTransfer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AmountofTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AmountofTransfer.Location = new System.Drawing.Point(117, 371);
            this.Lb_AmountofTransfer.Name = "Lb_AmountofTransfer";
            this.Lb_AmountofTransfer.Size = new System.Drawing.Size(187, 24);
            this.Lb_AmountofTransfer.TabIndex = 5;
            this.Lb_AmountofTransfer.Text = "Amount of Transfer";
            // 
            // Mtxtb_AmountofTransfer
            // 
            this.Mtxtb_AmountofTransfer.Location = new System.Drawing.Point(456, 364);
            this.Mtxtb_AmountofTransfer.Mask = "00000";
            this.Mtxtb_AmountofTransfer.Name = "Mtxtb_AmountofTransfer";
            this.Mtxtb_AmountofTransfer.Size = new System.Drawing.Size(139, 25);
            this.Mtxtb_AmountofTransfer.TabIndex = 6;
            this.Mtxtb_AmountofTransfer.ValidatingType = typeof(int);
            // 
            // UCTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.Controls.Add(this.Mtxtb_AmountofTransfer);
            this.Controls.Add(this.Lb_AmountofTransfer);
            this.Controls.Add(this.Txtb_TransferTo);
            this.Controls.Add(this.Txtb_TransferFrom);
            this.Controls.Add(this.Btn_Transfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_AccountNumberTransferFrom);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCTransfer";
            this.Size = new System.Drawing.Size(677, 591);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_AccountNumberTransferFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Transfer;
        private System.Windows.Forms.TextBox Txtb_TransferFrom;
        private System.Windows.Forms.TextBox Txtb_TransferTo;
        private System.Windows.Forms.Label Lb_AmountofTransfer;
        private System.Windows.Forms.MaskedTextBox Mtxtb_AmountofTransfer;
    }
}
