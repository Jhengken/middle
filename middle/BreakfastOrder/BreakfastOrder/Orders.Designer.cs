namespace BreakfastOrder
{
    partial class Orders
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpgPopular = new System.Windows.Forms.TabPage();
            this.listViewPopular = new System.Windows.Forms.ListView();
            this.tabpgSub = new System.Windows.Forms.TabPage();
            this.listViewSub = new System.Windows.Forms.ListView();
            this.tabpgEggCake = new System.Windows.Forms.TabPage();
            this.listViewEggCake = new System.Windows.Forms.ListView();
            this.tabpgSingle = new System.Windows.Forms.TabPage();
            this.listViewSingle = new System.Windows.Forms.ListView();
            this.tabpgDrink = new System.Windows.Forms.TabPage();
            this.listViewDrink = new System.Windows.Forms.ListView();
            this.btnLogic = new System.Windows.Forms.Button();
            this.btnShopCart = new System.Windows.Forms.Button();
            this.btnshopDetail = new System.Windows.Forms.Button();
            this.imgListPopular = new System.Windows.Forms.ImageList(this.components);
            this.imgListSub = new System.Windows.Forms.ImageList(this.components);
            this.imgListEggCake = new System.Windows.Forms.ImageList(this.components);
            this.imgListSingle = new System.Windows.Forms.ImageList(this.components);
            this.imgListDrink = new System.Windows.Forms.ImageList(this.components);
            this.btnManager = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabpgPopular.SuspendLayout();
            this.tabpgSub.SuspendLayout();
            this.tabpgEggCake.SuspendLayout();
            this.tabpgSingle.SuspendLayout();
            this.tabpgDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpgPopular);
            this.tabControl1.Controls.Add(this.tabpgSub);
            this.tabControl1.Controls.Add(this.tabpgEggCake);
            this.tabControl1.Controls.Add(this.tabpgSingle);
            this.tabControl1.Controls.Add(this.tabpgDrink);
            this.tabControl1.Location = new System.Drawing.Point(-2, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpgPopular
            // 
            this.tabpgPopular.Controls.Add(this.listViewPopular);
            this.tabpgPopular.Location = new System.Drawing.Point(4, 22);
            this.tabpgPopular.Name = "tabpgPopular";
            this.tabpgPopular.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgPopular.Size = new System.Drawing.Size(259, 335);
            this.tabpgPopular.TabIndex = 0;
            this.tabpgPopular.Text = "人氣精選";
            this.tabpgPopular.UseVisualStyleBackColor = true;
            // 
            // listViewPopular
            // 
            this.listViewPopular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPopular.HideSelection = false;
            this.listViewPopular.Location = new System.Drawing.Point(3, 3);
            this.listViewPopular.Name = "listViewPopular";
            this.listViewPopular.Size = new System.Drawing.Size(253, 329);
            this.listViewPopular.TabIndex = 2;
            this.listViewPopular.UseCompatibleStateImageBehavior = false;
            this.listViewPopular.Click += new System.EventHandler(this.listViewPopular_Click);
            // 
            // tabpgSub
            // 
            this.tabpgSub.Controls.Add(this.listViewSub);
            this.tabpgSub.Location = new System.Drawing.Point(4, 22);
            this.tabpgSub.Name = "tabpgSub";
            this.tabpgSub.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgSub.Size = new System.Drawing.Size(259, 335);
            this.tabpgSub.TabIndex = 1;
            this.tabpgSub.Text = "潛艇堡";
            this.tabpgSub.UseVisualStyleBackColor = true;
            // 
            // listViewSub
            // 
            this.listViewSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSub.HideSelection = false;
            this.listViewSub.Location = new System.Drawing.Point(3, 3);
            this.listViewSub.Name = "listViewSub";
            this.listViewSub.Size = new System.Drawing.Size(253, 329);
            this.listViewSub.TabIndex = 2;
            this.listViewSub.UseCompatibleStateImageBehavior = false;
            this.listViewSub.Click += new System.EventHandler(this.listViewSub_Click);
            // 
            // tabpgEggCake
            // 
            this.tabpgEggCake.Controls.Add(this.listViewEggCake);
            this.tabpgEggCake.Location = new System.Drawing.Point(4, 22);
            this.tabpgEggCake.Name = "tabpgEggCake";
            this.tabpgEggCake.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgEggCake.Size = new System.Drawing.Size(259, 335);
            this.tabpgEggCake.TabIndex = 2;
            this.tabpgEggCake.Text = "蛋餅";
            this.tabpgEggCake.UseVisualStyleBackColor = true;
            // 
            // listViewEggCake
            // 
            this.listViewEggCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEggCake.HideSelection = false;
            this.listViewEggCake.Location = new System.Drawing.Point(3, 3);
            this.listViewEggCake.Name = "listViewEggCake";
            this.listViewEggCake.Size = new System.Drawing.Size(253, 329);
            this.listViewEggCake.TabIndex = 2;
            this.listViewEggCake.UseCompatibleStateImageBehavior = false;
            this.listViewEggCake.Click += new System.EventHandler(this.listViewEggCake_Click);
            // 
            // tabpgSingle
            // 
            this.tabpgSingle.Controls.Add(this.listViewSingle);
            this.tabpgSingle.Location = new System.Drawing.Point(4, 22);
            this.tabpgSingle.Name = "tabpgSingle";
            this.tabpgSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgSingle.Size = new System.Drawing.Size(259, 335);
            this.tabpgSingle.TabIndex = 3;
            this.tabpgSingle.Text = "單點";
            this.tabpgSingle.UseVisualStyleBackColor = true;
            // 
            // listViewSingle
            // 
            this.listViewSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSingle.HideSelection = false;
            this.listViewSingle.Location = new System.Drawing.Point(3, 3);
            this.listViewSingle.Name = "listViewSingle";
            this.listViewSingle.Size = new System.Drawing.Size(253, 329);
            this.listViewSingle.TabIndex = 2;
            this.listViewSingle.UseCompatibleStateImageBehavior = false;
            this.listViewSingle.Click += new System.EventHandler(this.listViewSingle_Click);
            // 
            // tabpgDrink
            // 
            this.tabpgDrink.Controls.Add(this.listViewDrink);
            this.tabpgDrink.Location = new System.Drawing.Point(4, 22);
            this.tabpgDrink.Name = "tabpgDrink";
            this.tabpgDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDrink.Size = new System.Drawing.Size(259, 335);
            this.tabpgDrink.TabIndex = 4;
            this.tabpgDrink.Text = "飲品";
            this.tabpgDrink.UseVisualStyleBackColor = true;
            // 
            // listViewDrink
            // 
            this.listViewDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDrink.HideSelection = false;
            this.listViewDrink.Location = new System.Drawing.Point(3, 3);
            this.listViewDrink.Name = "listViewDrink";
            this.listViewDrink.Size = new System.Drawing.Size(253, 329);
            this.listViewDrink.TabIndex = 2;
            this.listViewDrink.UseCompatibleStateImageBehavior = false;
            this.listViewDrink.Click += new System.EventHandler(this.listViewDrink_Click);
            // 
            // btnLogic
            // 
            this.btnLogic.Location = new System.Drawing.Point(194, 14);
            this.btnLogic.Name = "btnLogic";
            this.btnLogic.Size = new System.Drawing.Size(51, 26);
            this.btnLogic.TabIndex = 1;
            this.btnLogic.Text = "登入";
            this.btnLogic.UseVisualStyleBackColor = true;
            this.btnLogic.Click += new System.EventHandler(this.btnLogic_Click);
            // 
            // btnShopCart
            // 
            this.btnShopCart.Location = new System.Drawing.Point(143, 14);
            this.btnShopCart.Name = "btnShopCart";
            this.btnShopCart.Size = new System.Drawing.Size(44, 26);
            this.btnShopCart.TabIndex = 1;
            this.btnShopCart.UseVisualStyleBackColor = true;
            this.btnShopCart.Click += new System.EventHandler(this.btnShopCart_Click);
            // 
            // btnshopDetail
            // 
            this.btnshopDetail.Location = new System.Drawing.Point(17, 15);
            this.btnshopDetail.Name = "btnshopDetail";
            this.btnshopDetail.Size = new System.Drawing.Size(64, 26);
            this.btnshopDetail.TabIndex = 1;
            this.btnshopDetail.Text = "店家資訊";
            this.btnshopDetail.UseVisualStyleBackColor = true;
            this.btnshopDetail.Click += new System.EventHandler(this.shopDetail_Click);
            // 
            // imgListPopular
            // 
            this.imgListPopular.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListPopular.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListPopular.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListSub
            // 
            this.imgListSub.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListSub.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListSub.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListEggCake
            // 
            this.imgListEggCake.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListEggCake.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListEggCake.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListSingle
            // 
            this.imgListSingle.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListSingle.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListSingle.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListDrink
            // 
            this.imgListDrink.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListDrink.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListDrink.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(194, 14);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(51, 26);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "管理";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.lblHello.Location = new System.Drawing.Point(93, 19);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(37, 16);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Hello";
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(194, 14);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(51, 25);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "登出";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 414);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnShopCart);
            this.Controls.Add(this.btnshopDetail);
            this.Controls.Add(this.btnLogic);
            this.Controls.Add(this.tabControl1);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpgPopular.ResumeLayout(false);
            this.tabpgSub.ResumeLayout(false);
            this.tabpgEggCake.ResumeLayout(false);
            this.tabpgSingle.ResumeLayout(false);
            this.tabpgDrink.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpgPopular;
        private System.Windows.Forms.TabPage tabpgSub;
        private System.Windows.Forms.Button btnLogic;
        private System.Windows.Forms.Button btnShopCart;
        private System.Windows.Forms.TabPage tabpgEggCake;
        private System.Windows.Forms.TabPage tabpgSingle;
        private System.Windows.Forms.TabPage tabpgDrink;
        private System.Windows.Forms.Button btnshopDetail;
        private System.Windows.Forms.ListView listViewPopular;
        private System.Windows.Forms.ListView listViewSub;
        private System.Windows.Forms.ListView listViewEggCake;
        private System.Windows.Forms.ListView listViewSingle;
        private System.Windows.Forms.ListView listViewDrink;
        private System.Windows.Forms.ImageList imgListPopular;
        private System.Windows.Forms.ImageList imgListSub;
        private System.Windows.Forms.ImageList imgListEggCake;
        private System.Windows.Forms.ImageList imgListSingle;
        private System.Windows.Forms.ImageList imgListDrink;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnSignOut;
    }
}