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
    public partial class M_EmployeesManeger : Form
    {
        string strMiddleConnect = "";
        string strSQL = "";
        DataTable dt;
        bool c = false;

        public M_EmployeesManeger()
        {
            InitializeComponent();
        }

        private void M_EmployeesManeger_Load(object sender, EventArgs e)
        {
            //Image eye = Image.FromFile($@"image\Eye.png");
            cbxRole.Items.Add("Boss"); 
            cbxRole.Items.Add("CEO");
            cbxRole.Items.Add("staff");
            cbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            btnEye.BackgroundImageLayout = ImageLayout.Zoom;
            btnEye.BackgroundImage = Image.FromFile($@"image\Eye.png");
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            strMiddleConnect = new DBConnect().ToString();
            showEmployees();
        }

        void txtClear()
        {
            txtName.Clear();
            dtpbirth.Value = DateTime.Now;
            dtpHire.Value = DateTime.Now;
            txtAddress.Clear();
            txtPhone.Clear();
            txtAcont.Clear();
            txtPswd.Clear();
        }

        void showEmployees()
        {
            if (c)
                dt.Rows.Clear();
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "select * from Employees";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dt = new DataTable();
                dt.Load(reader);
                dgvEmployees.DataSource = dt;
            }
            reader.Close();
            reader.Dispose();
            con.Close();
            con.Dispose();
            dgvEmployees.ClearSelection();
            txtClear();
            if (c)
                MessageBox.Show($"查詢到{dgvEmployees.RowCount-1}筆資料");
            c = true;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPswd.PasswordChar = txtPswd.PasswordChar == default(char) ? '岂' : default(char);
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            showEmployees();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpbirth.Value = (DateTime)(dgvEmployees.Rows[e.RowIndex].Cells[2].Value);
                dtpHire.Value = (DateTime)dgvEmployees.Rows[e.RowIndex].Cells[3].Value;
                txtAddress.Text = dgvEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dgvEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAcont.Text = dgvEmployees.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPswd.Text = dgvEmployees.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbxRole.Text = dgvEmployees.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btnAddEmyee_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "proc_AddEmployees";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar,20).Value = txtName.Text;
            cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = dtpbirth.Value;
            cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = dtpHire.Value;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar,100).Value = txtAddress.Text;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar,15).Value = txtPhone.Text;
            cmd.Parameters.Add("@Account", SqlDbType.NVarChar,30).Value = txtAcont.Text;
            cmd.Parameters.Add("@PassWord", SqlDbType.NVarChar,30).Value = txtPswd.Text;
            cmd.Parameters.Add("@Role", SqlDbType.NVarChar,20).Value = cbxRole.Text;
            SqlParameter I = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            I.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            Console.WriteLine((int)I.Value);     //傳回直放ExecuteNonQuery後面
            if ((int)I.Value == 0)
                MessageBox.Show("已有相同帳號或職位不能是Boss");
            else
                MessageBox.Show("成功加入");
            showEmployees();
        }

        private void btnModifiedEmyee_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "proc_ModifiedEmployees";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = (int)dgvEmployees.Rows[dgvEmployees.SelectedCells[0].RowIndex].Cells[0].Value;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 20).Value = txtName.Text;
            cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = dtpbirth.Value;
            cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = dtpHire.Value;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100).Value = txtAddress.Text;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = txtPhone.Text;
            cmd.Parameters.Add("@Account", SqlDbType.NVarChar, 30).Value = txtAcont.Text;
            cmd.Parameters.Add("@PassWord", SqlDbType.NVarChar, 30).Value = txtPswd.Text;
            cmd.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = cbxRole.Text;
            SqlParameter I = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            I.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            MessageBox.Show("成功修改");
            showEmployees();
        }

        private void btnDeleteEmyee_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMiddleConnect);
            con.Open();
            strSQL = "proc_DeleteEmployees";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = (int)dgvEmployees.Rows[dgvEmployees.SelectedCells[0].RowIndex].Cells[0].Value;
            cmd.ExecuteNonQuery(); 
            con.Close();
            con.Dispose();
            MessageBox.Show("成功刪除");
            showEmployees();
        }

        private void dgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != -1 && this.dgvEmployees.Columns[e.ColumnIndex].Name == "PassWord")   //把password變成*
            {
                if (e.Value != null)
                {
                    String st = new String('*', e.Value.ToString().Length);
                    e.Value = st;
                }
            }
        }
    }
}
