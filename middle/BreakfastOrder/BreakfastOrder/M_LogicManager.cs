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
    public partial class M_LogicManager : Form
    {
        string strMiddleConnect = "";
        public int L_EmLevel = 0;
        public M_LogicManager()
        {
            InitializeComponent();
        }

        private void M_LogicManager_Load(object sender, EventArgs e)
        {
            strMiddleConnect = new DBConnect().ToString();

        }

        private void btnMgLogic_Click(object sender, EventArgs e)
        {
            if (txtMgAcont.Text == "" && txtMgPswd.Text == "")
            {
                MessageBox.Show("填資料啦");
            }
            else
            {
                SqlConnection con = new SqlConnection(strMiddleConnect);
                con.Open();
                string strSQL = "proc_MgLogic";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MgAcont", SqlDbType.NVarChar).Value = txtMgAcont.Text;
                cmd.Parameters.Add("@MgPswd", SqlDbType.NVarChar).Value = txtMgPswd.Text;
                SqlParameter B = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);   //測試別的@
                B.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();                      //放在Direction後面
                L_EmLevel = (int)B.Value;
                Console.WriteLine(L_EmLevel);
                con.Close();
                con.Dispose();
                if ((int)B.Value > 0)
                {
                    MessageBox.Show("歡迎 管理員");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("帳密錯誤 重新輸入");
                }

            }
        }

    }
}
