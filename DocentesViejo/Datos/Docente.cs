using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Gini.Datos
{
    public class Docente:Base
    {
        public List<Entidades.Docente> GetAll()
        {
            try
            {
                this.Connect();
                SqlCommand cmdGetAll = new SqlCommand("SELECT * FROM Docente", Conn);
                List<Entidades.Docente> listaDocentes = new List<Entidades.Docente>();
                SqlDataReader drDocentes = cmdGetAll.ExecuteReader();
                using (drDocentes)
                {
                    while (drDocentes.Read())
                    {
                        Entidades.Docente docente = new Entidades.Docente();
                        docente.Id = (int)(drDocentes["Id"]);
                        docente.ApellidoNombre = (string)drDocentes["ApellidoNombre"];
                        docente.Cuil = (string)drDocentes["Cuil"];
                        docente.Email = (string)drDocentes["Email"];
                        docente.FechaIngreso = (DateTime)(drDocentes["FechaIngreso"]);
                        docente.Salario = (decimal)(drDocentes["Salario"]);
                        listaDocentes.Add(docente);
                    }
                }
                return listaDocentes;
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

        public void Add(Entidades.Docente doc)
        {
            try
            {
                this.Connect();
                SqlCommand cmdAdd = new SqlCommand("INSERT INTO Docente (ApellidoNombre, Cuil, Email, FechaIngreso, Id, Salario) VALUES (@ApellidoNombre, @Cuil, @Email, @FechaIngreso, @Id, @Salario)", Conn);
                cmdAdd.Parameters.AddWithValue("@ApellidoNombre", doc.ApellidoNombre);
                cmdAdd.Parameters.AddWithValue("@Cuil", doc.Cuil);
                cmdAdd.Parameters.AddWithValue("@Email", doc.Email);
                cmdAdd.Parameters.AddWithValue("@FechaIngreso", doc.FechaIngreso);
                cmdAdd.Parameters.AddWithValue("@Id", doc.Id);
                cmdAdd.Parameters.AddWithValue("@Salario", doc.Salario);
                cmdAdd.ExecuteNonQuery();
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

        public Entidades.Docente GetOneByCuil(string cuil)
        {
                this.Connect();
                List<Entidades.Docente> listaDocentes = GetAll();
                Entidades.Docente docente = new Entidades.Docente();
                docente = listaDocentes.FirstOrDefault(d => d.Cuil == cuil); //LINQ
                return docente;
        }
    }
}