using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaCadastro.Data
{
    internal class ConnectionMySQL
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        //Use if not using XAMPP
        //public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            Server = "localhost";
            DataBase = "sistemacadastro";
            User = "root";
            /* 
            //Use when not using XAMPP
            Password = "root";
            ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};pwd='{Password}'";
            */
            ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};";
            var conn = new MySqlConnection(ConnectionString);


            try
            {
                conn.Open();

            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message, "Erro ao conectar");
                throw;
            }
            return conn;
        }
    }
}
