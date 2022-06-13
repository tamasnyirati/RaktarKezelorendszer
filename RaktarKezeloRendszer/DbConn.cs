using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RaktarKezeloRendszer
{

    //I created this class for farther development. This isn't working yet.
    class DbConn
    {
        public string connStr;
        public SqlConnection sqlConn;

        public DbConn(SqlConnection sqlConn)
        {
            this.connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30";
            this.sqlConn = new SqlConnection(connStr);
        }

        public void dBCsatlakozas(string sqlQuery)
        {
            sqlConn.Open();
        }

        public void sqlUpdate(string sqlQuery)
        {
            sqlConn = new SqlConnection(sqlQuery);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
            cmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        
    }
}
