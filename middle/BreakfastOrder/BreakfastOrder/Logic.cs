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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace BreakfastOrder
{
    public partial class Logic : Form
    {
        string strMiddleConnect = "";
        public int level = 0;
        public int acontID = 0;
        public string acontName = "";
        public string acontPhone = "";
        private void Logic_Load(object sender, EventArgs e)
        {
            strMiddleConnect = new DBConnect().ToString();
        }
        public Logic()
        {
            InitializeComponent();
        }

        private void btnAcontLogic_Click(object sender, EventArgs e)
        {
            if (txtAcont.Text == "" && txtPswd.Text == "")
            {
                MessageBox.Show("填資料啦");
            }
            else
            {
                SqlConnection con = new SqlConnection(strMiddleConnect);
                con.Open();
                string strSQL = "proc_Logic";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@acont", SqlDbType.NVarChar).Value = txtAcont.Text;
                cmd.Parameters.Add("@pswd", SqlDbType.NVarChar).Value = txtPswd.Text;
                SqlParameter Level = cmd.Parameters.Add("@Level", SqlDbType.Int);
                Level.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Level：" + Level.Value);     //Level.Value回傳值
                level = (int)Level.Value;

                if (level > 0)
                {
                    con = new SqlConnection(strMiddleConnect);
                    con.Open();
                    strSQL = "proc_LogicName";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@acont", SqlDbType.NVarChar).Value = txtAcont.Text;
                    SqlParameter name = cmd.Parameters.Add("@Name", SqlDbType.NVarChar,30);
                    SqlParameter phone = cmd.Parameters.Add("@Phone", SqlDbType.NVarChar,30);
                    SqlParameter CustomerID = cmd.Parameters.Add("@CustomerID", SqlDbType.Int);
                    name.Direction = ParameterDirection.Output;
                    phone.Direction = ParameterDirection.Output;
                    CustomerID.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    acontName = name.Value.ToString();
                    acontPhone = phone.Value.ToString();
                    acontID = (int)CustomerID.Value;
                    Console.WriteLine("name & phone："+ acontID.ToString() + acontName + acontPhone);     //Level.Value回傳值
                    con.Close();
                    con.Dispose();
                }

                
                if (level == 2)
                {
                    //acontID = txtAcont.Text;
                    this.Close();
                    MessageBox.Show("登入成功");
                }
                else if (level == 1)
                {
                    //acontID = txtAcont.Text;
                    this.Close();
                    MessageBox.Show("登入成功");
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }
        }

        private void btnNoAcontLogic_Click(object sender, EventArgs e)
        {
            level = 0;
            M_OrderDetails m = new M_OrderDetails();
            this.Close();
            m.ShowDialog();
            //MessageBox.Show("無會員登入");
        }
    }
}
