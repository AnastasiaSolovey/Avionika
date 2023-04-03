using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Avionika_Si
{
    public class BD
    {
        public static string host = "localhost"; // Имя хоста
        public static string database = "oborot_si"; // Имя базы данных
        public static string user = "root"; // Имя пользователя
        public static string password = ""; // Пароль пользователя
        public static string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
        public MySqlConnection ConnDB = new MySqlConnection(Connect);
        public void openConnection()
        {
            if (ConnDB.State == System.Data.ConnectionState.Closed)
                ConnDB.Open();

        }


        public void CloseConnection()
        {
            if (ConnDB.State == System.Data.ConnectionState.Open)
                ConnDB.Close();
        }
        public MySqlConnection getConnection()
        {
            return ConnDB;
        }
    }
}
