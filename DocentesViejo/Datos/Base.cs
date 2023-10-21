using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Base
    {
        SqlConnection _conn;
        public SqlConnection Conn { get { return _conn; } set { _conn = value; } }
        public void Connect()
        {
            Conn = new SqlConnection("server=PC-LUCA;Integrated Security=true;Database=Docente;");
            Conn.Open();
        }
        public void Disconnect()
        {
            Conn.Close();
            Conn = null;
        }
    }
}
