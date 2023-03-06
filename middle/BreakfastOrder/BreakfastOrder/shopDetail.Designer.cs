namespace BreakfastOrder
{
    partial class shopDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopyAddress = new System.Windows.Forms.Button();
            this.btnCopyPhone = new System.Windows.Forms.Button();
            this.linklblAddress = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "店家位址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "電話：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "營業時間：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.Location = new System.Drawing.Point(102, 46);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 19);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "0912345677";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(102, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "周一至周六 5:30~11:30";
            // 
            // btnCopyAddress
            // 
            this.btnCopyAddress.Location = new System.Drawing.Point(304, 18);
            this.btnCopyAddress.Name = "btnCopyAddress";
            this.btnCopyAddress.Size = new System.Drawing.Size(44, 22);
            this.btnCopyAddress.TabIndex = 1;
            this.btnCopyAddress.Text = "Copy";
            this.btnCopyAddress.UseVisualStyleBackColor = true;
            this.btnCopyAddress.Click += new System.EventHandler(this.btnCopyAddress_Click);
            // 
            // btnCopyPhone
            // 
            this.btnCopyPhone.Location = new System.Drawing.Point(207, 44);
            this.btnCopyPhone.Name = "btnCopyPhone";
            this.btnCopyPhone.Size = new System.Drawing.Size(44, 22);
            this.btnCopyPhone.TabIndex = 2;
            this.btnCopyPhone.Text = "Copy";
            this.btnCopyPhone.UseVisualStyleBackColor = true;
            this.btnCopyPhone.Click += new System.EventHandler(this.btnCopyPhone_Click);
            // 
            // linklblAddress
            // 
            this.linklblAddress.AutoSize = true;
            this.linklblAddress.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.linklblAddress.LinkColor = System.Drawing.Color.DarkGoldenrod;
            this.linklblAddress.Location = new System.Drawing.Point(102, 18);
            this.linklblAddress.Name = "linklblAddress";
            this.linklblAddress.Size = new System.Drawing.Size(198, 19);
            this.linklblAddress.TabIndex = 3;
            this.linklblAddress.TabStop = true;
            this.linklblAddress.Text = "704台南市北區開元路380號";
            this.linklblAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAddress_LinkClicked);
            // 
            // shopDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 116);
            this.Controls.Add(this.linklblAddress);
            this.Controls.Add(this.btnCopyPhone);
            this.Controls.Add(this.btnCopyAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "shopDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "shopDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopyAddress;
        private System.Windows.Forms.Button btnCopyPhone;
        private System.Windows.Forms.LinkLabel linklblAddress;
    }
}