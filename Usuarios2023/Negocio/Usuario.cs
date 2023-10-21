using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;


namespace Gini.Negocio
{
    public class Usuario
    {
        static public List<Entidades.Usuario> GetAll()
        {
            try
            {
                Datos.Usuario datos = new Datos.Usuario();
                return datos.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void Add(Entidades.Usuario usuario)
        {
            try
            {
                Datos.Usuario datos = new Datos.Usuario();
                datos.Add(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void Update(Entidades.Usuario usuario)
        {
            try
            {
                Datos.Usuario datos = new Datos.Usuario();
                datos.Update(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void Delete(Entidades.Usuario usuario)
        {
            try
            {
                Datos.Usuario datos = new Datos.Usuario();
                datos.Delete(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public List<Entidades.Usuario> GetAllByUserName(string nombreUsuario)
        {
            try
            {
                Datos.Usuario datos = new Datos.Usuario();
                return datos.GetAllByUserName(nombreUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public Entidades.Usuario GetOneByUsername(string NombreUsuario)
        {
            try
            {
                Datos.Usuario datos = new Datos.Usuario();
                return datos.GetOneByUsername(NombreUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class Validaciones
    {
        static public bool ValidarClave(string clave)
        {
            if (clave.Length < 4)
                return false;
            else
                return true;
        }

        static public bool ValidarNombreUsuario(string nombreUsuario)
        {
            if (nombreUsuario.Length < 8)
                return false;
            else
                return true;
        }

        static public bool vacios(string clave, string nombreUsuario, string email, int tipoUsuario)
        {
            if (clave == "" || nombreUsuario == "" || email == "" || tipoUsuario == 0)
                return false;
            else
                return true;
        }
    }
}