using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace evendar.DB
{
    internal class DataBase
    {
        public static string connetionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Evendar;Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(connetionString);

        public static DataTable ExecuteQuery(string query, params SqlParameter[] arr)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();
            return dt;
        }

        public static void Execute(string query, params SqlParameter[] arr)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static bool checkUsername(string username)
        {
            return ExecuteQuery("checkUsername", new SqlParameter("@username", username)).Rows[0][0].ToString() != null;
        }

        public static string getUsername(string email)
        {
            return ExecuteQuery("getUsername", new SqlParameter("@email", email)).Rows[0][0].ToString();
        }

        public static string getEmail(string username)
        {
            return ExecuteQuery("getEmail", new SqlParameter("@username", username)).Rows[0][0].ToString();
        }

        public static bool checkEmail(string email)
        {
            return ExecuteQuery("checkEmail", new SqlParameter("@email", email)).Rows[0][0].ToString() != null;
        }

        public static string login(string username, string password)
        {
            return ExecuteQuery("login", new SqlParameter("@username", username), new SqlParameter("@password", password)).Rows[0][0].ToString();
        }


        public static void register(string username, string password, string name, string email)
        {
            Execute("createAccount", new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@email", email),
                new SqlParameter("@name", name));
        }
        public static void changePass(string username, string password)
        {
            Execute("changePassword", new SqlParameter("@username", username), new SqlParameter("@password", password));
        }

        public static void changeEmail(string username, string newEmail)
        {
            Execute("changeEmail", new SqlParameter("@username", username), new SqlParameter("@email", newEmail));
        }

    }
}
