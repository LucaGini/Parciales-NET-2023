using System;
using System.Collections.Generic;
using Gini.Entidades;
using Gini.Datos;


namespace Gini.Negocio
{
    public class Usuario
    {
        public static List<Gini.Entidades.Usuario> RecuperarTodos()
        {
            Gini.Datos.Usuario ds;
            try
            {
                ds = new Gini.Datos.Usuario();
                return ds.RecuperarTodos();
            }finally
            {
                ds = null;
            }
        }

        public static void Agregar(Gini.Entidades.Usuario usuario)
        {
            Gini.Datos.Usuario ds;
            try
            {
                ds = new Gini.Datos.Usuario();
                ds.Agregar(usuario);
            }finally
            {
                ds = null;
            }
        }
        
        public static Gini.Entidades.Usuario RecuperarUno(string NombreUsuario)
        {
            Gini.Datos.Usuario ds;
            try
            {
                if (string.IsNullOrEmpty(NombreUsuario))
                {
                    throw new Exception("El nombre de usuario no puede ser nulo o vacio.");
                }
                else
                {
                    ds = new Gini.Datos.Usuario();
                    return ds.RecuperarUno(NombreUsuario);
                }
            }finally
            {
                ds = null;
            }
        }
    }
}

