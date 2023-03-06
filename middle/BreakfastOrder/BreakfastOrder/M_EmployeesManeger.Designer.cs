namespace BreakfastOrder
{
    partial class M_EmployeesManeger
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
            this.btnEye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAcont = new System.Windows.Forms.TextBox();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.dtpbirth = new System.Windows.Forms.DateTimePicker();
            this.dtpHire = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmyee = new System.Windows.Forms.Button();
            this.btnModifiedEmyee = new System.Windows.Forms.Button();
            this.btnDeleteEmyee = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEye
            // 
            this.btnEye.Location = new System.Drawing.Point(193, 280);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(25, 25);
            this.btnEye.TabIndex = 1;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(83, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 25);
            this.txtName.TabIndex = 3;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(236, 55);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.Size = new System.Drawing.Size(514, 332);
            this.dgvEmployees.TabIndex = 9;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            this.dgvEmployees.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmployees_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(458, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "員工資料";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(44, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(20, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "入職日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(44, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(44, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(44, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "帳號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(44, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "密碼";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(83, 123);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 67);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(83, 209);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 25);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAcont
            // 
            this.txtAcont.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAcont.Location = new System.Drawing.Point(83, 244);
            this.txtAcont.Name = "txtAcont";
            this.txtAcont.Size = new System.Drawing.Size(100, 25);
            this.txtAcont.TabIndex = 3;
            // 
            // txtPswd
            // 
            this.txtPswd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPswd.Location = new System.Drawing.Point(83, 280);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '岂';
            this.txtPswd.Size = new System.Drawing.Size(100, 25);
            this.txtPswd.TabIndex = 3;
            // 
            // dtpbirth
            // 
            this.dtpbirth.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpbirth.Location = new System.Drawing.Point(83, 55);
            this.dtpbirth.Name = "dtpbirth";
            this.dtpbirth.Size = new System.Drawing.Size(135, 22);
            this.dtpbirth.TabIndex = 14;
            this.dtpbirth.Value = new System.DateTime(2022, 12, 17, 0, 0, 0, 0);
            // 
            // dtpHire
            // 
            this.dtpHire.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpHire.Location = new System.Drawing.Point(82, 89);
            this.dtpHire.Name = "dtpHire";
            this.dtpHire.Size = new System.Drawing.Size(136, 22);
            this.dtpHire.TabIndex = 14;
            // 
            // btnAddEmyee
            // 
            this.btnAddEmyee.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddEmyee.Location = new System.Drawing.Point(22, 357);
            this.btnAddEmyee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmyee.Name = "btnAddEmyee";
            this.btnAddEmyee.Size = new System.Drawing.Size(55, 30);
            this.btnAddEmyee.TabIndex = 15;
            this.btnAddEmyee.Text = "新增";
            this.btnAddEmyee.UseVisualStyleBackColor = true;
            this.btnAddEmyee.Click += new System.EventHandler(this.btnAddEmyee_Click);
            // 
            // btnModifiedEmyee
            // 
            this.btnModifiedEmyee.Location = new System.Drawing.Point(93, 357);
            this.btnModifiedEmyee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifiedEmyee.Name = "btnModifiedEmyee";
            this.btnModifiedEmyee.Size = new System.Drawing.Size(55, 30);
            this.btnModifiedEmyee.TabIndex = 15;
            this.btnModifiedEmyee.Text = "修改";
            this.btnModifiedEmyee.UseVisualStyleBackColor = true;
            this.btnModifiedEmyee.Click += new System.EventHandler(this.btnModifiedEmyee_Click);
            // 
            // btnDeleteEmyee
            // 
            this.btnDeleteEmyee.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteEmyee.Location = new System.Drawing.Point(163, 357);
            this.btnDeleteEmyee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteEmyee.Name = "btnDeleteEmyee";
            this.btnDeleteEmyee.Size = new System.Drawing.Size(55, 30);
            this.btnDeleteEmyee.TabIndex = 15;
            this.btnDeleteEmyee.Text = "刪除";
            this.btnDeleteEmyee.UseVisualStyleBackColor = true;
            this.btnDeleteEmyee.Click += new System.EventHandler(this.btnDeleteEmyee_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("微軟正黑體", 8F);
            this.btnRenew.Location = new System.Drawing.Point(159, 19);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(59, 23);
            this.btnRenew.TabIndex = 15;
            this.btnRenew.Text = "更新清除";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(44, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "職位";
            // 
            // cbxRole
            // 
            this.cbxRole.CausesValidation = false;
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(82, 318);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(101, 26);
            this.cbxRole.TabIndex = 16;
            // 
            // M_EmployeesManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 406);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnDeleteEmyee);
            this.Controls.Add(this.btnModifiedEmyee);
            this.Controls.Add(this.btnAddEmyee);
            this.Controls.Add(this.dtpHire);
            this.Controls.Add(this.dtpbirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.txtAcont);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEye);
            this.Name = "M_EmployeesManeger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesManeger";
            this.Load += new System.EventHandler(this.M_EmployeesManeger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAcont;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.DateTimePicker dtpbirth;
        private System.Windows.Forms.DateTimePicker dtpHire;
        private System.Windows.Forms.Button btnAddEmyee;
        private System.Windows.Forms.Button btnModifiedEmyee;
        private System.Windows.Forms.Button btnDeleteEmyee;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxRole;
    }
}