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
    public partial class ShopCart : Form
    {
        public int shopCartL = 0;
        public ListViewItem item;
        public shopList oShopList = new shopList();   //物件沒有實體化
        public string shopCartName = "";
        public string shopCartPhone = "";
        public int shopCartAcontID = 0;
        string strMiddleConnect = "";

        public ShopCart()
        {
            InitializeComponent();
        }
        private void ShopCart_Load(object sender, EventArgs e)
        {
            strMiddleConnect = new DBConnect().ToString();
            showShopCart();
            dtpTakeDate.MinDate = DateTime.Now;
            cBoxTakeTime.Items.Clear();
            string m = "30";//顯示cbox
            for (int h = 5 ; 11 >= h;)     
                if (m == "30")
                {
                    cBoxTakeTime.Items.Add($"{h}:{m}".PadLeft(5,'0'));
                    m = "00"; h++;
                }
                else
                {
                    cBoxTakeTime.Items.Add($"{h}:{m}".PadLeft(5, '0'));
                    m = "30";
                }
            cBoxTakeTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTakeTime.Text = cBoxTakeTime.Items[0].ToString();

            if (shopCartL > 0)
            {
                txtCustomerName.Text = shopCartName;
                txtCustomerPhone.Text = shopCartPhone;
            }
            else
            {
                txtCustomerName.Text = "";
                txtCustomerPhone.Text = "";
            }
        }

        void showShopCart()
        {
            ListViewClearAndDefault();
            for (int i = 0; oShopList.shopName.Count > i; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                item.Name = oShopList.shopName[i];
                item.Text = $"{oShopList.shopName[i]} 數量:{oShopList.shopQuantity[i]}  {oShopList.shopPrice[i]}元";
                item.Tag = oShopList.shopPID[i];
                listViewShop.Items.Add(item);
            }
            listViewShop.SmallImageList = oShopList.shopImg;
        }

        public void ListViewClearAndDefault()
        {
            listViewShop.Clear();
            listViewShop.View = View.SmallIcon;
            listViewShop.LabelWrap = true;
        }

        private void listViewShop_Click(object sender, EventArgs e)
        {
            Quantity FormQ = new Quantity();
            FormQ.idx = listViewShop.SelectedItems[0];
            int q = Price.SubQuantity(FormQ.idx.Text);
            if (q == 1)        //字串裡數量跟價格
            {
                FormQ.intQuantuty = q;
                FormQ.intPrice = Price.SubPrice(FormQ.idx.Text);
            }
            else
            {
                FormQ.intQuantuty = q / q;
                FormQ.intPrice = Price.SubPrice(FormQ.idx.Text) / q;
            }
            FormQ.ShowDialog();
            if (FormQ.DialogResult == DialogResult.OK)
            {
                if (FormQ.intQuantuty > 0)
                {
                    oShopList.add(FormQ.idx.Name, FormQ.intQuantuty, FormQ.totlePrice, (int)FormQ.idx.Tag, FormQ.idx.ImageList.Images[FormQ.idx.Index]);
                }
                else
                {
                    oShopList.reduce((int)FormQ.idx.Tag, FormQ.idx.Name);
                }
                showShopCart();
            }
            else
            {

            }
        }

        private void btnComplete_Click(object sender, EventArgs e) //抓目前shoplist數量 跟 PID  抓資料進SQL
        {
            string time = dtpTakeDate.Value.ToString("yyyy:MM:dd:") + cBoxTakeTime.Text;  //轉換takeTime
            string[] sTime = time.Split(':');
            int[] iTime = new int[5];
            for (int i = 0; i < sTime.Length; i++)
            {
                if (Int32.TryParse(sTime[i], out iTime[i])) { Console.WriteLine(iTime[i]); }
                else { MessageBox.Show("轉換iTime失敗"); break; }
            }
            DateTime takeTime = new DateTime(iTime[0], iTime[1], iTime[2], iTime[3], iTime[4], 0);
            //Console.WriteLine(takeTime);
            SqlConnection con = new SqlConnection(strMiddleConnect);
            string strSQL = "proc_InsertOrders";

            if (shopCartL > 0)         //會員以上執行這個
            {
                if (oShopList.shopPID.Count > 0)
                {
                    con = new SqlConnection(strMiddleConnect);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = shopCartAcontID;
                    cmd.Parameters.Add("@TakeDate", SqlDbType.DateTime).Value = takeTime;
                    SqlParameter OrderID = cmd.Parameters.Add("@OrderID", SqlDbType.Int);
                    OrderID.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine((int)OrderID.Value);

                    strSQL = "proc_Insert_OrderDetails";
                    cmd = new SqlCommand(strSQL, con);
                    for (int i = 0; i < oShopList.shopPID.Count; i++)
                    {
                        con = new SqlConnection(strMiddleConnect);
                        con.Open();
                        cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = (int)OrderID.Value;
                        cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = oShopList.shopPID[i];
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = oShopList.shopQuantity[i];
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    con.Dispose();
                    oShopList.Clear();
                    showShopCart();
                    MessageBox.Show("訂單成功送出");
                }
                else
                {
                    MessageBox.Show("購物車沒東西");
                }
            }
            else         //無會員執行這個
            {
                if (txtCustomerName.Text == "" && txtCustomerPhone.Text == "") { MessageBox.Show("填寫姓名跟電話"); }
                else
                {
                    if (oShopList.shopPID.Count > 0)
                    {
                        strSQL = "proc_InsertOrdersNull";
                        con = new SqlConnection(strMiddleConnect);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TakeDate", SqlDbType.DateTime).Value = takeTime;
                        SqlParameter OrderID = cmd.Parameters.Add("@OrderID", SqlDbType.Int);
                        OrderID.Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine((int)OrderID.Value);

                        strSQL = "proc_Insert_OrderDetails";
                        cmd = new SqlCommand(strSQL, con);
                        for (int i = 0; i < oShopList.shopPID.Count; i++)
                        {
                            con = new SqlConnection(strMiddleConnect);
                            con.Open();
                            cmd = new SqlCommand(strSQL, con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = (int)OrderID.Value;
                            cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = oShopList.shopPID[i];
                            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = oShopList.shopQuantity[i];
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        con.Dispose();
                        oShopList.Clear();
                        showShopCart();
                        MessageBox.Show("儲存成功");
                    }
                    else
                    {
                        MessageBox.Show("購物車沒東西");
                    }
                }
            }
        }
    }
}
