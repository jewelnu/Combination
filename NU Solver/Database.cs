using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace NU_Solver
{
    class Database
    {
        //static SqlConnection cn = new SqlConnection();
        public static SqlConnection GetConnectionObj()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
               // cn.ConnectionString = @"Data Source=192.168.3.45;User id=solver;Password=`1qazxsw23edc;";
                //cn.ConnectionString = @"Data Source=sazzad-ap;User id=solver;Password=`1qazxsw23edc;";
                //@"Server=BILLAL-PC\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;

                //cn.ConnectionString = @"uid=sa;pwd=shariful123;Initial Catalog=Solve;Data Source=SHARIF";
                cn.ConnectionString = @"Server=BILLAL-PC\SQLEXPRESS;Initial Catalog=nuslvdb;Integrated Security=True;";
                //cn.ConnectionString = @"Server=192.168.031;Initial Catalog=nuslvdb;Integrated Security=True;";
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Database connection failed!\nContact network administrator.\n"+e.StackTrace.ToString());
            }
            return null;
        }
        public static List<string> all_subjects = new List<string>();
        public static void init()
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT dbo.file_list.pap_code FROM dbo.file_list", con);
                //cmd.CommandText = "SELECT DISTINCT dbo.file_list.pap_code FROM dbo.file_list";
                SqlDataReader reader = cmd.ExecuteReader();
                all_subjects.Clear();
                while (reader.Read())
                {
                    //MessageBox.Show(reader["status"].ToString());
                    all_subjects.Add(reader["pap_code"].ToString());
                }
                reader.Dispose();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Database error occured when fatching Papercodes.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
            all_subjects.Add("fdsf");
        }
        public static bool isNotValid(string papercode)
        {
            
            for (int i = 0; i < all_subjects.Count; i++)
            {
                if (papercode == all_subjects[i])
                    return false;
            }
            return true;
        }

        
    }
}
