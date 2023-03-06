namespace BreakfastOrder
{
    partial class ShopCart
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
            this.listViewShop = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCustomerRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTakeDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxTakeTime = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewShop
            // 
            this.listViewShop.BackColor = System.Drawing.SystemColors.Window;
            this.listViewShop.HideSelection = false;
            this.listViewShop.Location = new System.Drawing.Point(40, 82);
            this.listViewShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewShop.Name = "listViewShop";
            this.listViewShop.Size = new System.Drawing.Size(300, 363);
            this.listViewShop.TabIndex = 0;
            this.listViewShop.UseCompatibleStateImageBehavior = false;
            this.listViewShop.Click += new System.EventHandler(this.listViewShop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(232, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的購物車";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(373, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "訂購人資訊";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(8, 19);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(169, 25);
            this.txtCustomerName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(377, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(184, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomerPhone);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(377, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(184, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "電話";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(8, 19);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(169, 25);
            this.txtCustomerPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(373, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "訂單備註";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCustomerRemark);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(377, 278);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(184, 52);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "留給餐廳的訊息";
            // 
            // txtCustomerRemark
            // 
            this.txtCustomerRemark.Location = new System.Drawing.Point(8, 19);
            this.txtCustomerRemark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerRemark.Name = "txtCustomerRemark";
            this.txtCustomerRemark.Size = new System.Drawing.Size(169, 25);
            this.txtCustomerRemark.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(373, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "取餐時間";
            // 
            // dtpTakeDate
            // 
            this.dtpTakeDate.Location = new System.Drawing.Point(377, 382);
            this.dtpTakeDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTakeDate.MinDate = new System.DateTime(2022, 12, 12, 0, 0, 0, 0);
            this.dtpTakeDate.Name = "dtpTakeDate";
            this.dtpTakeDate.Size = new System.Drawing.Size(177, 25);
            this.dtpTakeDate.TabIndex = 5;
            this.dtpTakeDate.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // cBoxTakeTime
            // 
            this.cBoxTakeTime.FormattingEnabled = true;
            this.cBoxTakeTime.Location = new System.Drawing.Point(377, 421);
            this.cBoxTakeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxTakeTime.Name = "cBoxTakeTime";
            this.cBoxTakeTime.Size = new System.Drawing.Size(177, 23);
            this.cBoxTakeTime.TabIndex = 6;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(247, 479);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(115, 36);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "送出訂單";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // ShopCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 546);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.cBoxTakeTime);
            this.Controls.Add(this.dtpTakeDate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewShop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShopCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.ShopCart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCustomerRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTakeDate;
        private System.Windows.Forms.ComboBox cBoxTakeTime;
        private System.Windows.Forms.Button btnComplete;
    }
}