using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gini.Datos
{
    public class Usuario:Conexion
    {
        public List<Entidades.Usuario> GetAll()
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios", Conn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
                using (dr)
                { 
                    while (dr.Read())
                    {
                       Entidades.Usuario usuario = new Entidades.Usuario();
                       usuario.Clave = (string)dr["Clave"];
                       usuario.Email = (string)dr["Email"];
                       usuario.NombreUsuario = (string)dr["NombreUsuario"];
                       usuario.TipoUsuario = (int)dr["TipoUsuario"];
                       usuario.UltimoIngreso = (DateTime)dr["UltimoIngreso"];   
                        
                       usuarios.Add(usuario);
                        usuario = null;
                    }

                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Add(Entidades.Usuario usuario)
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Clave, Email, NombreUsuario, TipoUsuario, UltimoIngreso) VALUES (@Clave, @Email, @NombreUsuario, @TipoUsuario, @UltimoIngreso)", Conn);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);
                cmd.Parameters.AddWithValue("@UltimoIngreso", usuario.UltimoIngreso);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Update(Entidades.Usuario usuario)
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Clave=@Clave, Email=@Email, NombreUsuario=@NombreUsuario, TipoUsuario=@TipoUsuario, UltimoIngreso=@UltimoIngreso WHERE NombreUsuario=@NombreUsuario", Conn);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);
                cmd.Parameters.AddWithValue("@UltimoIngreso", usuario.UltimoIngreso);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Delete(Entidades.Usuario usuario)
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE NombreUsuario=@NombreUsuario", Conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public List<Entidades.Usuario> GetAllByUserName(string NombreUsuario)
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE NombreUsuario LIKE @NombreUsuario", Conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
                using (dr)
                {
                    while (dr.Read())
                    {
                        Entidades.Usuario usuario = new Entidades.Usuario();
                        usuario.Clave = (string)dr["Clave"];
                        usuario.Email = (string)dr["Email"];
                        usuario.NombreUsuario = (string)dr["NombreUsuario"];
                        usuario.TipoUsuario = (int)dr["TipoUsuario"];
                        usuario.UltimoIngreso = (DateTime)dr["UltimoIngreso"];
                        usuarios.Add(usuario);
                        usuario = null;
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public Entidades.Usuario GetOneByUsername(string NombreUsuario)
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE NombreUsuario=@NombreUsuario", Conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                SqlDataReader dr = cmd.ExecuteReader();
                Entidades.Usuario usuario = new Entidades.Usuario();
                using (dr)
                {
                    if (dr.Read())
                    {
                        usuario.Clave = (string)dr["Clave"];
                        usuario.Email = (string)dr["Email"];
                        usuario.NombreUsuario = (string)dr["NombreUsuario"];
                        usuario.TipoUsuario = (int)dr["TipoUsuario"];
                        usuario.UltimoIngreso = (DateTime)dr["UltimoIngreso"];
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Disconnect();
            }
        }
    }
}
