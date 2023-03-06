using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastOrder
{
     public  class DBConnect
     {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public DBConnect()
        {
            scsb.DataSource = @".";   //伺服器名稱
            scsb.InitialCatalog = "Middle";   //資料庫名稱
            scsb.IntegratedSecurity = true;  //Windows驗證
        }
        public override string ToString()
        {
            return scsb.ToString();
        }
     }
}
