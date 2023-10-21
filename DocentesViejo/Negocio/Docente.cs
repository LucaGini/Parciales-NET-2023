using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Gini.Negocio
{
    public class Docente
    {
        static public List<Entidades.Docente> GetAll()
        {
            try
            {
                Datos.Docente doc = new Datos.Docente();
                return doc.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void Add(Entidades.Docente doc)
        {
            try
            {
                Datos.Docente docente = new Datos.Docente();
                docente.Add(doc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public Entidades.Docente GetOneByCuil(string cuil)
        {
            try
            {
                Datos.Docente docente = new Datos.Docente();
                if (Validaciones.EsCuilValido(cuil))
                {
                    return docente.GetOneByCuil(cuil);
                }
                else
                {
                    throw new Exception("El CUIL ingresado no es válido.");
                }
            } catch (Exception ex)
            {
                  throw ex;
            }
        }
    }

    public class Validaciones
    {
        static public bool EsCuilValido(string cuil)
        {
            string patron = "(20|27|30)([0-9]{9})$";

            if (Regex.IsMatch(cuil, patron))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}