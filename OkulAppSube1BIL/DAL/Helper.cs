using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr;

        public Helper()
        {
            cstr = ConfigurationManager.ConnectionStrings["cstr"]?.ConnectionString ?? throw new InvalidOperationException("Bağlantı dizesi 'cstr' bulunamadı.");
        }
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (SqlConnection cn = new SqlConnection(cstr))
            {
                using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /*public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }*/
    }
    /*public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


    */
}
