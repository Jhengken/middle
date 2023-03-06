namespace BreakfastOrder
{
    partial class M_LogicManager
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMgAcont = new System.Windows.Forms.TextBox();
            this.txtMgPswd = new System.Windows.Forms.TextBox();
            this.btnMgLogic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "帳號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "管理員登入";
            // 
            // txtMgAcont
            // 
            this.txtMgAcont.Location = new System.Drawing.Point(77, 81);
            this.txtMgAcont.Name = "txtMgAcont";
            this.txtMgAcont.Size = new System.Drawing.Size(100, 22);
            this.txtMgAcont.TabIndex = 9;
            // 
            // txtMgPswd
            // 
            this.txtMgPswd.Location = new System.Drawing.Point(77, 124);
            this.txtMgPswd.Name = "txtMgPswd";
            this.txtMgPswd.PasswordChar = 'π';
            this.txtMgPswd.Size = new System.Drawing.Size(100, 22);
            this.txtMgPswd.TabIndex = 10;
            // 
            // btnMgLogic
            // 
            this.btnMgLogic.Location = new System.Drawing.Point(81, 176);
            this.btnMgLogic.Name = "btnMgLogic";
            this.btnMgLogic.Size = new System.Drawing.Size(53, 29);
            this.btnMgLogic.TabIndex = 11;
            this.btnMgLogic.Text = "登入";
            this.btnMgLogic.UseVisualStyleBackColor = true;
            this.btnMgLogic.Click += new System.EventHandler(this.btnMgLogic_Click);
            // 
            // M_LogicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 248);
            this.Controls.Add(this.btnMgLogic);
            this.Controls.Add(this.txtMgPswd);
            this.Controls.Add(this.txtMgAcont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "M_LogicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理員登入";
            this.Load += new System.EventHandler(this.M_LogicManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMgAcont;
        private System.Windows.Forms.TextBox txtMgPswd;
        private System.Windows.Forms.Button btnMgLogic;
    }
}