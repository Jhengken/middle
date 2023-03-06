namespace BreakfastOrder
{
    partial class Logic
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcontLogic = new System.Windows.Forms.Button();
            this.txtAcont = new System.Windows.Forms.TextBox();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.btnNoAcontLogic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員登入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "密碼";
            // 
            // btnAcontLogic
            // 
            this.btnAcontLogic.Location = new System.Drawing.Point(16, 186);
            this.btnAcontLogic.Name = "btnAcontLogic";
            this.btnAcontLogic.Size = new System.Drawing.Size(65, 31);
            this.btnAcontLogic.TabIndex = 3;
            this.btnAcontLogic.Text = "登入";
            this.btnAcontLogic.UseVisualStyleBackColor = true;
            this.btnAcontLogic.Click += new System.EventHandler(this.btnAcontLogic_Click);
            // 
            // txtAcont
            // 
            this.txtAcont.Location = new System.Drawing.Point(68, 86);
            this.txtAcont.Name = "txtAcont";
            this.txtAcont.Size = new System.Drawing.Size(100, 22);
            this.txtAcont.TabIndex = 1;
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(68, 130);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '別';
            this.txtPswd.Size = new System.Drawing.Size(100, 22);
            this.txtPswd.TabIndex = 2;
            // 
            // btnNoAcontLogic
            // 
            this.btnNoAcontLogic.Location = new System.Drawing.Point(96, 186);
            this.btnNoAcontLogic.Name = "btnNoAcontLogic";
            this.btnNoAcontLogic.Size = new System.Drawing.Size(85, 31);
            this.btnNoAcontLogic.TabIndex = 4;
            this.btnNoAcontLogic.Text = "無會員登入";
            this.btnNoAcontLogic.UseVisualStyleBackColor = true;
            this.btnNoAcontLogic.Click += new System.EventHandler(this.btnNoAcontLogic_Click);
            // 
            // Logic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 251);
            this.Controls.Add(this.btnNoAcontLogic);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.txtAcont);
            this.Controls.Add(this.btnAcontLogic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入";
            this.Load += new System.EventHandler(this.Logic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcontLogic;
        private System.Windows.Forms.TextBox txtAcont;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.Button btnNoAcontLogic;
    }
}

