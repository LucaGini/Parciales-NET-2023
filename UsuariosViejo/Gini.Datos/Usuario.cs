using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gini.Entidades;

namespace Gini.Datos
{
    public class Usuario:Base
    {
        public List<Gini.Entidades.Usuario> RecuperarTodos()
        {
            try
            {
                List<Gini.Entidades.Usuario> usuarios = new List<Gini.Entidades.Usuario>();
                SqlConnection connection = new SqlConnection();
                this.Connect();
                SqlCommand command = new SqlCommand("SELECT * FROM Usuario", connection);
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Gini.Entidades.Usuario usuario = new Gini.Entidades.Usuario();
                        usuario.Clave = (string)reader["Clave"];
                        usuario.Email = (string)reader["Email"];
                        usuario.NombreUsuario = (string)reader["NombreUsuario"];
                        usuario.TipoUsuario = (int)reader["TipoUsuario"];
                        usuario.UltimoIngreso = (DateTime)reader["UltimoIngreso"];
                        usuarios.Add(usuario);
                    }
                    return usuarios;
                }

            } finally
            {
                this.Disconnect();
            }
        }

        public void Agregar(Gini.Entidades.Usuario usuario)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                this.Connect();
                SqlCommand command = new SqlCommand("INSERT INTO Usuario (Clave, Email, NombreUsuario, TipoUsuario, UltimoIngreso) VALUES (@Clave, @Email, @NombreUsuario, @TipoUsuario, @UltimoIngreso)", connection);
                command.Parameters.AddWithValue("@Clave", usuario.Clave);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);
                command.Parameters.AddWithValue("@UltimoIngreso", usuario.UltimoIngreso);
                command.ExecuteNonQuery();
            } finally
            {
                this.Disconnect();
            }
        }

        public Gini.Entidades.Usuario RecuperarUno(string NombreUsuario)
        {
            try
            {
                //Solve this using LINQ
                Gini.Entidades.Usuario u = new Gini.Entidades.Usuario();  
                SqlConnection connection = new SqlConnection();
                this.Connect();
                List<Gini.Entidades.Usuario> usuarios = new List<Gini.Entidades.Usuario>();
                usuarios = this.RecuperarTodos();
                u = usuarios.FirstOrDefault(u => u.NombreUsuario.Equals(NombreUsuario));
                return u;
            }
            finally 
            {
                this.Disconnect();
            }
        }
    }
}
