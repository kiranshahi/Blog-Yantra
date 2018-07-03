using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public static class DBConnection
    {
        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(GetConString.GetConnectionString("DefaultConnection"));
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
    }
}
