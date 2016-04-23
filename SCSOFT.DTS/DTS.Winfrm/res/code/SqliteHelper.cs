using System.Data;
using System.Data.SQLite;

namespace DTS.Winfrm.res.code
{
    public class SqliteHelper
     {
        private static SQLiteConnection GetConnection()
        {
            string connStr = System.Configuration.ConfigurationSettings.AppSettings["sqlite"].ToString();
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            return conn;
        }

        public static int ExecuteSql(string sql)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                return cmd.ExecuteNonQuery();
            }
        }

        public static int ExecuteScalar(string sql)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                object o = cmd.ExecuteScalar();
                return int.Parse(o.ToString());
            }
        }
        public static SQLiteDataReader ExecuteReader(string sql)
        {
            SQLiteConnection conn = GetConnection();
            var cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return myReader;
        }
        public static DataSet ExecDataSet(string sql)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }
    }
}
