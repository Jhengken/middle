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
    public partial class M_OrderDetails : Form
    {
        public int EM_EmLevel = 0;
        string strMiddleConnect = "";
        string strSQL = "";
        DataTable dt;
        public M_OrderDetails()
        {
            InitializeComponent();
        }

        private void M_OrderDetails_Load(object sender, EventArgs e)
        {
            //進去會先顯示前幾筆訂單
            //DGV有OrderID CustomerName ProductName OrderDate TakeDate Quantity Price
            //     detail  customers    products    Orders    Orders   detail   detail
            //刪除訂單直接刪除OrderID
            ToolTip t = new ToolTip();
            t.SetToolTip(btnSearch, "直接點及搜尋前三筆詳細訂單");
            t.AutoPopDelay = 5000;
            t.ToolTipTitle = "無特定搜尋";
            strMiddleConnect = new DBConnect().ToString();
            if (EM_EmLevel == 2)
                btnEM.Visible = true;
            else
                btnEM.Visible = false;
            ShowdgvTop3();
        }

        void txtClear()
        {
            txtOrderID.Clear();
            txtCusmrName.Clear();
            txtQuantity.Clear();
            lblPrice.Text = "0";
            lblProductName.Text = "無";
            dgvOrderDetail.ClearSelection();
        }
        void ShowdgvTop3()   //要想做雙向繫節(Databinding)用精靈，目前這方式只能讀取不能修改
        {

            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "proc_QueryTop3";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)       //HasRows傳回table，適合DGV用
            {
                dt = new DataTable();
                dt.Load(reader);      //把資料載入datatable，要給DataGripView用Datatable這個中介
                dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                dgvOrderDetail.DataSource = dt;
            }
            reader.Close();
            con.Close();
            dgvOrderDetail.ClearSelection();
            txtClear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                if (txtCusmrName.Text == "" && txtOrderID.Text == "")       //都空的搜尋前3
                {
                    ShowdgvTop3();
                    MessageBox.Show("目前顯示前三筆的詳細資料");
                }
                else if (txtCusmrName.Text != "" && txtOrderID.Text == "")  //ID空的，搜尋Name
                {
                    SqlConnection con = new SqlConnection(strMiddleConnect);
                    con.Open();
                    strSQL = "proc_QueryCustomerName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtCusmrName.Text;
                    SqlParameter B = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                    B.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();     //放在Direction後面
                    Console.WriteLine((int)B.Value);
                
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)       //HasRows傳回table，適合DGV用
                    {
                        dt = new DataTable();
                        dt.Load(reader);      //把資料載入datatable，要給DataGripView用Datatable這個中介
                        dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                        dgvOrderDetail.DataSource = dt;
                    }
                    reader.Close();
                    con.Close();
                    if ((int)B.Value > 0)
                    {
                        txtClear();
                        MessageBox.Show($"目前顯示{B.Value}筆的資料");
                    }
                    else
                        MessageBox.Show("查詢不到資料");
                }
                else if (txtCusmrName.Text == "" && txtOrderID.Text != "")  //Name空的，搜尋ID
                {
                    if (Int32.TryParse(txtOrderID.Text, out int i))         //判斷txtOrderID是不是輸入數字
                    {
                        SqlConnection con = new SqlConnection(strMiddleConnect);
                        con.Open();
                        strSQL = "proc_QueryCustomerID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = txtOrderID.Text;
                        SqlParameter B = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                        B.Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();     //放在Direction後面
                        Console.WriteLine((int)B.Value);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)       //HasRows傳回table，適合DGV用
                        {
                            dt = new DataTable();
                            dt.Load(reader);      //把資料載入datatable，要給DataGripView用Datatable這個中介
                            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                            dgvOrderDetail.DataSource = dt;
                        }
                        reader.Close();
                        con.Close();
                        if ((int)B.Value > 0)
                        {
                            txtClear();
                            MessageBox.Show($"目前顯示{B.Value}筆的資料");
                        }
                        else
                            MessageBox.Show("查詢不到資料");
                    }
                    else
                        MessageBox.Show("訂單號碼要輸入數字");
                }
                else 
                    MessageBox.Show("只能填寫一個或不填寫");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
            //dt.Rows.Clear();
        }
    }
}
