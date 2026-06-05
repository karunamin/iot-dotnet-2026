using MySqlConnector;
using System.Data;

namespace WpfTest
{
    public class DatabaseHelper
    {
        private string connStr =
            "Server=localhost;" +
            "Database=bookrentalshop;" +
            "Uid=root;" +
            "Pwd=my123456;" +
            "Charset=utf8mb4;";

        // SELECT
        public DataTable Select(string sql)
        {
            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // INSERT, UPDATE, DELETE
        public int Execute(string sql)
        {
            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        // Parameter 사용
        public int Execute(string sql, params MySqlParameter[] parameters)
        {
            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand(sql, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteNonQuery();
        }

        // DB 연결 테스트
        public bool TestConnection()
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}