using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Word_Bank
{
    class Database
    {
        DataTable dTable;
        SqlDataAdapter sqlDA;

        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        string conStr;

        public Database()
        {
                conStr = "Data Source=DESKTOP-ORP0F3R;Initial Catalog=WordBank;Persist Security Info=True;User ID=sa;Password=Mertkann1";
                sqlCon = new SqlConnection(conStr);
                sqlCon.Open();
        }

        public int createNewItem(string sql)
        {
            sqlCmd = new SqlCommand(sql, sqlCon);
            return sqlCmd.ExecuteNonQuery();
        }

        public DataTable selectCmd(string sql)
        {
            dTable = new DataTable();
            sqlDA = new SqlDataAdapter(sql,conStr);
            
            sqlDA.Fill(dTable);
            
            sqlDA.Dispose();
            return dTable;
        }
    }
}
