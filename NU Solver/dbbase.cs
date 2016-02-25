using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace NU_Solver
{
    class dbbase
    {
        static string myConnString = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
       //string myConnectionString=@"Server=BILLAL-PC\SQLEXPRESS;Initial Catalog=nuslvdb;Integrated Security=True;";
       // Connection constr = new Connection();

        SqlConnection cn = new SqlConnection(myConnString);
        
        SqlCommand cmd = new SqlCommand();
        DataTable myTable = new DataTable();

        private void SetComnd(string myState)
        {
            // cn.ConnectionString = "Server=CompileMe;Database=MyDatabase;Integrated Security=True";
            cmd.Connection = cn;
            cmd.CommandText = myState;

        }
        private void connect()
        { cn.Open(); }
        private void Disconnect()
        { cn.Dispose(); }

        public DataTable RunQuery(string select)
        {
            SetComnd(select);
            myTable.Load(cmd.ExecuteReader());
            return myTable;
        }
        public bool login(string user, string pass)
        {
            connect();
            //string sqlcmd = "select * from UserInfo where user_id='" + user + "' and password='" + pass + "'";
            string sqlcmd = "select * from solvers where solver_name='" + user + "' and passkey='" + pass + "'";
            //MessageBox.Show(sqlcmd.ToString());
            DataTable mytbl = RunQuery(sqlcmd);
            
            if (mytbl.Rows.Count > 0) return true;
            else return false;
        }
    }
}
