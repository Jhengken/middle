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
        string strMiddleConnect = "";   //不要new試試看
        string strSQL = "";
        bool c = false;
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
            strMiddleConnect = new DBConnect().ToString();  //拿連接字串
            if (EM_EmLevel == 2)
                btnEM.Visible = true;
            else
                btnEM.Visible = false;
            ShowdgvTop30();
        }

        void txtClear()
        {
            txtSerOrderID.Clear();
            txtSerCusmrName.Clear();
            txtQuantity.Clear();
            lblPrice.Text = "0";
            lblProductName.Text = "無";
            lblName.Text= "無";
            lblOrderID.Text = "0";
            dgvOrderDetail.ClearSelection();
        }

        void ShowdgvTop30()
        {
            if (c)
                dt.Rows.Clear();
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "proc_QueryTop30";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)       //HasRows傳回table，適合DGV用
            {
                dt = new DataTable();
                dt.Load(reader);      //把資料載入datatable，要給DataGripView用Datatable這個中介
                dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                dgvOrderDetail.DataSource = dt;
                c = true;
            }
            reader.Close();
            reader.Dispose();
            con.Close();
            con.Dispose();
            dgvOrderDetail.ClearSelection();  //讓dgv一開始不要有被點選的狀態
            txtClear();
            if(c)
                MessageBox.Show("目前顯示前30筆未完成的詳細資料");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                if (txtSerCusmrName.Text == "" && txtSerOrderID.Text == "")       //都空的搜尋前3
                {
                    ShowdgvTop30();
                }
                else if (txtSerCusmrName.Text != "" && txtSerOrderID.Text == "")  //ID空的，搜尋Name
                {
                    dt.Rows.Clear();
                    SqlConnection con = new SqlConnection(strMiddleConnect);
                    con.Open();
                    strSQL = "proc_QueryCustomerName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtSerCusmrName.Text;
                    SqlParameter B = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                    B.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();     //放在Direction後面，給參數跟接傳回值都先準備好
                    Console.WriteLine((int)B.Value);             //傳回直放ExecuteNonQuery後面

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
                else if (txtSerCusmrName.Text == "" && txtSerOrderID.Text != "")  //Name空的，搜尋ID
                {
                    if (Int32.TryParse(txtSerOrderID.Text, out int i))         //判斷txtOrderID是不是輸入數字
                    {
                        dt.Rows.Clear();
                        SqlConnection con = new SqlConnection(strMiddleConnect);
                        con.Open();
                        strSQL = "proc_QueryOrderID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@OrderID", SqlDbType.NVarChar).Value = txtSerOrderID.Text;
                        SqlParameter B = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);  //@後面並不特定要RETURN_VALUE
                        B.Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();             //放在Direction後面
                        Console.WriteLine((int)B.Value);   //傳回直放ExecuteNonQuery後面
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

        private void btnModified_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtQuantity.Text, out int Q) && Q>0)
            {
                strSQL = "proc_ModifiedOrders";
                SqlConnection con = new SqlConnection(strMiddleConnect);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = lblOrderID.Text;
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 20).Value = lblProductName.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = txtQuantity.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("訂單修改成功");
                ShowdgvTop30();
            }
            else
                MessageBox.Show($"請輸入數字，且數量大於0");
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("11::" + dgvOrderDetail.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.RowIndex>=0)
            {
                lblOrderID.Text = dgvOrderDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblName.Text = dgvOrderDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblProductName.Text = dgvOrderDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantity.Text = dgvOrderDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblPrice.Text = dgvOrderDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            strSQL = "proc_CompleteOrders";
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = lblOrderID.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            MessageBox.Show("此筆訂單完成");
            ShowdgvTop30();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Sure FormS = new Sure();
            FormS.ShowDialog();
            if (FormS.DialogResult == DialogResult.OK)
            {
                strSQL = "proc_delete_OrderDetails";
                SqlConnection con = new SqlConnection(strMiddleConnect);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = lblOrderID.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("訂單已刪除");
                ShowdgvTop30();
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            Sure FormS = new Sure();
            FormS.ShowDialog();
            if (FormS.DialogResult == DialogResult.OK)
            {
                strSQL = "proc_deleteRow_OrderDetails";
                SqlConnection con = new SqlConnection(strMiddleConnect);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = lblOrderID.Text;
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar,30).Value = lblProductName.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("訂單項目已刪除");
                ShowdgvTop30();
            }
        }

        private void btnEM_Click(object sender, EventArgs e)
        {
            M_EmployeesManeger FormEM = new M_EmployeesManeger();
            FormEM.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct FormAddProduct = new AddProduct();
            FormAddProduct.ShowDialog();
        }
    }
}
