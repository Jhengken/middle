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

    public partial class AddProduct : Form
    {
        string strMiddleConnect = "";
        string strSQL = "";
        string fileExtension = "";
        bool c = false;
        DataTable dt;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cbxCategoryName.Items.Add("Sub");
            cbxCategoryName.Items.Add("EggCake");
            cbxCategoryName.Items.Add("Single");
            cbxCategoryName.Items.Add("Drink");
            cbxCategoryName.Text = cbxCategoryName.Items[0].ToString();
            fileExtension = "";
            cbxCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            ptbxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            showProduct();
        }

        void txtClear()
        {
            cbxCategoryName.Text = cbxCategoryName.Items[0].ToString();
            txtProductName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtPictureName.Clear();
            chbxPopular.Checked = false;
            ptbxProduct.Image = null;
            fileExtension = "";
        }

        void showProduct()
        {
            strMiddleConnect = new DBConnect().ToString();
            if (c)
                dt.Rows.Clear();
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "select * from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)       //HasRows傳回table，適合DGV用
            {
                dt = new DataTable();
                dt.Load(reader);      //把資料載入datatable，要給DataGripView用Datatable這個中介
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                dgvProducts.DataSource = dt;
                c = true;
            }
            reader.Close();
            reader.Dispose();
            con.Close();
            con.Dispose();
            dgvProducts.ClearSelection();  //讓dgv一開始不要有被點選的狀態
            txtClear();
            if (c)
                MessageBox.Show("顯示所有商品");
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型|*.jpg;*.jpeg;*.png";
            DialogResult R = f.ShowDialog();
            if (R == DialogResult.OK)       //如果點選那個form的選擇
            {
                ptbxProduct.Image = Image.FromFile(f.FileName);
                fileExtension = System.IO.Path.GetExtension(f.SafeFileName);
            }
        }

        private void btnModifiedProduct_Click(object sender, EventArgs e)
        {
            if (cbxCategoryName.Text != "" && txtPictureName.Text != "" && txtPrice.Text != "" && txtDescription.Text != "" && txtPictureName.Text != "")
            {
                if (fileExtension != "")
                {
                    if (Int32.TryParse(txtPrice.Text, out int price))
                    {
                        strMiddleConnect = new DBConnect().ToString();
                        SqlConnection con = new SqlConnection(strMiddleConnect);
                        con.Open();
                        strSQL = "proc_ModifiedProduct";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = txtProductName.Text;
                        cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 50).Value = cbxCategoryName.Text;
                        int CategoryID = 1;
                        switch (cbxCategoryName.Text)  //@CategoryID值
                        {
                            case "Sub":
                                CategoryID = 1;
                                break;
                            case "EggCake":
                                CategoryID = 2;
                                break;
                            case "Single":
                                CategoryID = 3;
                                break;
                            case "Drink":
                                CategoryID = 4;
                                break;
                        }
                        cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = txtDescription.Text;
                        cmd.Parameters.Add("@UnitPrice", SqlDbType.Int).Value = price;
                        cmd.Parameters.Add("@Picture", SqlDbType.NVarChar, 100).Value = txtPictureName.Text + fileExtension;
                        cmd.Parameters.Add("@Popular", SqlDbType.Bit).Value = chbxPopular.Checked;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        showProduct();
                        MessageBox.Show("商品已修改");
                    }
                    else
                        MessageBox.Show("價格輸入數字");
                }
                else
                    MessageBox.Show("還沒選取圖片");
            }
            else
                MessageBox.Show("請填寫完整");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cbxCategoryName.Text != "" && txtPictureName.Text != "" && txtPrice.Text != "" && txtDescription.Text != "" && txtPictureName.Text != "")
            {
                if (fileExtension != "")
                {
                    if (Int32.TryParse(txtPrice.Text, out int price))
                    {
                        strMiddleConnect = new DBConnect().ToString();
                        SqlConnection con = new SqlConnection(strMiddleConnect);
                        con.Open();
                        strSQL = "proc_AddProduct";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = txtProductName.Text;
                        cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 50).Value = cbxCategoryName.Text;
                        int CategoryID = 1;
                        switch (cbxCategoryName.Text)  //@CategoryID值
                        {
                            case "Sub":
                                CategoryID = 1;
                                break;
                            case "EggCake":
                                CategoryID = 2;
                                break;
                            case "Single":
                                CategoryID = 3;
                                break;
                            case "Drink":
                                CategoryID = 4;
                                break;
                        }
                        cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = txtDescription.Text;
                        cmd.Parameters.Add("@UnitPrice", SqlDbType.Int).Value = txtPrice.Text;
                        cmd.Parameters.Add("@Picture", SqlDbType.NVarChar, 100).Value = txtPictureName.Text + fileExtension;
                        cmd.Parameters.Add("@Popular", SqlDbType.Bit).Value = chbxPopular.Checked;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        ptbxProduct.Image.Save($@"image\Breakfast_Screen\{cbxCategoryName.Text}\{txtPictureName.Text + fileExtension}");
                        MessageBox.Show("商品已新增");
                        showProduct();
                    }
                    else
                        MessageBox.Show("價格輸入數字");
                }
                else
                    MessageBox.Show("還沒選取圖片");
            }
            else
                MessageBox.Show("請填寫完整");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductName.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxCategoryName.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPictureName.Text = dgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();
                chbxPopular.Checked = (bool)dgvProducts.Rows[e.RowIndex].Cells[7].Value;
                ptbxProduct.Image = Image.FromFile($@"image\Breakfast_Screen\{cbxCategoryName.Text}\{txtPictureName.Text}");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            strSQL = "proc_DeleteProduct";
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = (int)dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[0].Value;
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            MessageBox.Show("訂單項目已刪除");
            showProduct();
        }
    }
}
