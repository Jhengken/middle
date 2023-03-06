using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastOrder
{
    public partial class Orders : Form
    {
        ShopCart FormShop = new ShopCart();
        string strMiddleConnect = "";
        public int L = 0;

        public Orders()
        {
            InitializeComponent();
        }


        private void Orders_Load(object sender, EventArgs e)
        {
            //Image ShopCart = Image.FromFile(@"image\ShopCart.png");
            btnManager.Visible = false;
            btnSignOut.Visible = false; 
            lblHello.Visible = false;
            btnShopCart.BackgroundImageLayout = ImageLayout.Zoom;
            btnShopCart.BackgroundImage = Image.FromFile(@"image\ShopCart.png");
            strMiddleConnect = new DBConnect().ToString();
            FormShop.ListViewClearAndDefault();
            ShowProduct();
        }
        void ListViewAllClear()   //清除所有ListView
        {
            listViewPopular.Clear();
            listViewSub.Clear();
            listViewEggCake.Clear();
            listViewSingle.Clear();
            listViewDrink.Clear();
        }

        void ListViewDefault()   //給預設值
        {
            imgListPopular.ColorDepth = ColorDepth.Depth32Bit;    //不要讓他失真
            imgListSub.ColorDepth = ColorDepth.Depth32Bit;
            imgListEggCake.ColorDepth = ColorDepth.Depth32Bit;
            imgListSingle.ColorDepth = ColorDepth.Depth32Bit;
            imgListDrink.ColorDepth = ColorDepth.Depth32Bit;

            imgListPopular.ImageSize = new Size(70, 70);    //Size
            imgListSub.ImageSize = new Size(70, 70);
            imgListEggCake.ImageSize = new Size(70, 70);
            imgListSingle.ImageSize = new Size(70, 70);
            imgListDrink.ImageSize = new Size(70, 70);

            listViewPopular.View = View.SmallIcon;    //SmallIcon
            listViewSub.View = View.SmallIcon;
            listViewEggCake.View = View.SmallIcon;
            listViewSingle.View = View.SmallIcon;
            listViewDrink.View = View.SmallIcon;

            listViewSub.LabelWrap = true;          //可換行，沒屁用
            listViewEggCake.LabelWrap = true; 
            listViewDrink.LabelWrap = true;
            listViewSingle.LabelWrap = true;
            listViewPopular.LabelWrap = true;
        }

        void ShowProduct()       //讀取給listView購物商品
        {
            ListViewAllClear();
            ListViewDefault();
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            string strSQL = "select * from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0; int p = 0; int Sub = 0; int Sin = 0; int d = 0; int e = 0;
            while (reader.Read())   //tag放 ProductID跟CategoryID
            {
                if ((bool)reader["popular"] == true)        //人氣商品給listViewPopular
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = p;
                    item.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                    item.Name = reader["ProductName"].ToString();
                    item.Text = $"{reader["ProductName"]}  {reader["UnitPrice"]}元";
                    item.Tag = reader["ProductID"];
                    listViewPopular.Items.Add(item);

                    Image ProductImage = Image.FromFile($@"image\Breakfast_Screen\{reader["CategoryName"]}\{reader["Picture"]}");
                    //imgListPopular.Tag = reader["Picture"];
                    imgListPopular.Images.Add(ProductImage);
                    p++;
                }

                //其他商品放各自的種類ListView
                Image ProductImage1 = Image.FromFile($@"image\Breakfast_Screen\{reader["CategoryName"]}\{reader["Picture"]}");
                ListViewItem item1 = new ListViewItem();
                switch (reader["CategoryID"])
                {
                    case 1:
                        item1.ImageIndex = Sub;
                        item1.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                        item1.Name = reader["ProductName"].ToString();
                        item1.Text = $"{reader["ProductName"]}  {reader["UnitPrice"]}元";
                        item1.Tag = reader["ProductID"];
                        listViewSub.Items.Add(item1);
                        //imgListSub.Tag = reader["Picture"];
                        imgListSub.Images.Add(ProductImage1);
                        Sub++;   i++;
                        break;
                    case 2:
                        item1.ImageIndex = e;
                        item1.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                        item1.Name = reader["ProductName"].ToString();
                        item1.Text = $"{reader["ProductName"]}  {reader["UnitPrice"]}元";
                        item1.Tag = reader["ProductID"];
                        listViewEggCake.Items.Add(item1);
                        //imgListEggCake.Tag = reader["Picture"];
                        imgListEggCake.Images.Add(ProductImage1);
                        e++;   i++;
                        break;
                    case 3:
                        item1.ImageIndex = Sin;
                        item1.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                        item1.Name = reader["ProductName"].ToString();
                        item1.Text = $"{reader["ProductName"]}  {reader["UnitPrice"]}元";
                        item1.Tag = reader["ProductID"];
                        listViewSingle.Items.Add(item1);
                        //imgListSingle.Tag = reader["Picture"];
                        imgListSingle.Images.Add(ProductImage1);
                        Sin++;   i++;
                        break;

                    default:
                        item1.ImageIndex = d;
                        item1.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                        item1.Name = reader["ProductName"].ToString();
                        item1.Text = $"{reader["ProductName"]}  {reader["UnitPrice"]}元";
                        item1.Tag = reader["ProductID"];
                        listViewDrink.Items.Add(item1);
                        //imgListDrink.Tag = reader["Picture"];
                        imgListDrink.Images.Add(ProductImage1);
                        d++;   i++;
                        break;
                }
            }
            listViewPopular.SmallImageList = imgListPopular;
            listViewSub.SmallImageList = imgListSub;
            listViewEggCake.SmallImageList = imgListEggCake;
            listViewSingle.SmallImageList = imgListSingle;
            listViewDrink.SmallImageList = imgListDrink;
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
        }

        private void btnShopCart_Click(object sender, EventArgs e)
        {
            FormShop.ShowDialog();
        }

        void logicBtnDisplay()
        {
            if (L == 2)
            {
                btnManager.Visible = true;
                btnLogic.Visible = false;
                lblHello.Visible = true;
                btnSignOut.Visible = false;
            }
            else if (L == 1)
            {
                btnManager.Visible = false;
                btnLogic.Visible = false;
                lblHello.Visible = true;
                btnSignOut.Visible = true;
            }
            else
            {
                btnManager.Visible = false;
                btnLogic.Visible = true;
                lblHello.Visible = false;
                btnSignOut.Visible = false;
            }
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            Logic FormLogic = new Logic();
            FormLogic.ShowDialog();
            L = FormLogic.level;
            FormShop.shopCartL = L;
            FormShop.shopCartName = FormLogic.acontName;
            FormShop.shopCartPhone = FormLogic.acontPhone;
            FormShop.shopCartAcontID = FormLogic.acontID;
            logicBtnDisplay();
        }

        private void listViewPopular_Click(object sender, EventArgs e)
        {
            Quantity FormQ = new Quantity();
            FormQ.idx = listViewPopular.SelectedItems[0];    //滑鼠點擊選取的item，案Ctrl可以選多個
            FormQ.intPrice = Price.SubPrice(FormQ.idx.Text);
            FormQ.ShowDialog();

            if (FormQ.DialogResult == DialogResult.OK)  //購物車給點擊的，顯示圖片 名稱 數量 總價
            {
                if (FormQ.intQuantuty > 0)
                {
                    FormShop.oShopList.add(FormQ.idx.Name, FormQ.intQuantuty, FormQ.totlePrice, (int)FormQ.idx.Tag, FormQ.idx.ImageList.Images[FormQ.idx.Index]);
                    //shopidx++;
                }
                else
                {
                    FormShop.oShopList.reduce((int)FormQ.idx.Tag, FormQ.idx.Name);
                }
            }
            else
            {

            }
        }

        private void listViewSub_Click(object sender, EventArgs e)
        {
            Quantity FormQ = new Quantity();
            FormQ.idx = listViewSub.SelectedItems[0];
            FormQ.intPrice = Price.SubPrice(FormQ.idx.Text);
            FormQ.ShowDialog();

            if (FormQ.DialogResult == DialogResult.OK)  //購物車給點擊的，顯示圖片 名稱 數量 總價
            {
                if (FormQ.intQuantuty > 0)
                {
                    FormShop.oShopList.add(FormQ.idx.Name, FormQ.intQuantuty, FormQ.totlePrice, (int)FormQ.idx.Tag, FormQ.idx.ImageList.Images[FormQ.idx.Index]);
                    //shopidx++;
                }
                else
                {
                    FormShop.oShopList.reduce((int)FormQ.idx.Tag, FormQ.idx.Name);
                }
            }
            else
            {

            }
        }

        private void listViewEggCake_Click(object sender, EventArgs e)
        {
            Quantity FormQ = new Quantity();
            FormQ.idx = listViewEggCake.SelectedItems[0];
            FormQ.intPrice = Price.SubPrice(FormQ.idx.Text);
            FormQ.ShowDialog();
            if (FormQ.DialogResult == DialogResult.OK)  //購物車給點擊的，顯示圖片 名稱 數量 總價
            {
                if (FormQ.intQuantuty > 0)
                {
                    FormShop.oShopList.add(FormQ.idx.Name, FormQ.intQuantuty, FormQ.totlePrice, (int)FormQ.idx.Tag, FormQ.idx.ImageList.Images[FormQ.idx.Index]);
                    //shopidx++;
                }
                else
                {
                    FormShop.oShopList.reduce((int)FormQ.idx.Tag, FormQ.idx.Name);
                }
            }
            else
            {

            }
        }

        private void listViewSingle_Click(object sender, EventArgs e)
        {
            Quantity FormQ = new Quantity();
            FormQ.idx = listViewSingle.SelectedItems[0];
            FormQ.intPrice = Price.SubPrice(FormQ.idx.Text);
            FormQ.ShowDialog();

            if (FormQ.DialogResult == DialogResult.OK)  //購物車給點擊的，顯示圖片 名稱 數量 總價
            {
                if (FormQ.intQuantuty > 0)
                {
                    FormShop.oShopList.add(FormQ.idx.Name, FormQ.intQuantuty, FormQ.totlePrice, (int)FormQ.idx.Tag, FormQ.idx.ImageList.Images[FormQ.idx.Index]);
                    //shopidx++;
                }
                else
                {
                    FormShop.oShopList.reduce((int)FormQ.idx.Tag, FormQ.idx.Name);
                }
            }
            else
            {

            }
        }

        private void listViewDrink_Click(object sender, EventArgs e)
        {
            Quantity FormQ = new Quantity();
            FormQ.idx = listViewDrink.SelectedItems[0];
            FormQ.intPrice = Price.SubPrice(FormQ.idx.Text);
            FormQ.ShowDialog();

            if (FormQ.DialogResult == DialogResult.OK)  //購物車給點擊的，顯示圖片 名稱 數量 總價
            {
                if (FormQ.intQuantuty > 0)
                {
                    FormShop.oShopList.add(FormQ.idx.Name, FormQ.intQuantuty, FormQ.totlePrice, (int)FormQ.idx.Tag, FormQ.idx.ImageList.Images[FormQ.idx.Index]);
                    //shopidx++;
                }
                else
                {
                    FormShop.oShopList.reduce((int)FormQ.idx.Tag, FormQ.idx.Name);
                }
            }
            else
            {

            }
        }

        private void shopDetail_Click(object sender, EventArgs e)
        {
            shopDetail FormshopDetail = new shopDetail();
            FormshopDetail.ShowDialog();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            M_LogicManager FormMlogic = new M_LogicManager();
            FormMlogic.ShowDialog();
            if (FormMlogic.DialogResult == DialogResult.OK)
            {
                M_OrderDetails FormMOD = new M_OrderDetails();
                FormMOD.EM_EmLevel = FormMlogic.L_EmLevel;
                FormMOD.ShowDialog();
            }
        }

        private void lblHello_Click(object sender, EventArgs e)
        {
            if (L == 2)
            {
                L = 0;
                FormShop.shopCartL = L;
                MessageBox.Show("登出成功");
                logicBtnDisplay();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            L = 0;
            FormShop.shopCartL = L;
            MessageBox.Show("登出成功");
            logicBtnDisplay();
        }


    }
}
