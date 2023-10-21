using System;
using System.Data;
using System.Data.SqlClient;


namespace Gini.Datos
{
    public class Base
    {
        public static string xxxConnection
        {
            get
            {
                return "Data Source=PC-LUCA;Initial Catalog=Net.DB.Usuario;Integrated Security=True";
            }
        }
        public SqlConnection Connect()
        {
            SqlConnection connection = new SqlConnection(xxxConnection);
            connection.Open();
            return connection;
        }
        public void Disconnect()
        {
            SqlConnection connection = new SqlConnection(xxxConnection);
            connection.Close();
        }
    }
}