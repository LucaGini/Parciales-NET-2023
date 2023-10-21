using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini.Entidades
{
    public class Docente
    {
        int _antiguedad;
        string _apellidoNombre;
        string _cuil;
        string _email;
        DateTime _fechaIngreso;
        int _id;
        decimal _salario;

        public string ApellidoNombre { get { return _apellidoNombre; } set { _apellidoNombre = value; } }
        public string Cuil { get { return _cuil; } set { _cuil = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public DateTime FechaIngreso { get { return _fechaIngreso; } set { _fechaIngreso = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public decimal Salario { get { return _salario; } set { _salario = value; } }
        public int Antiguedad
        {
            get
            {
                return DateTime.Now.Year - FechaIngreso.Year;
            }
        }

        public Docente()
        {
            this.ApellidoNombre = string.Empty;
            this.Cuil = string.Empty;
            this.Email = string.Empty;
            this.FechaIngreso = DateTime.Now;
            this.Id = 0;
            this.Salario = 0;
        }

        public Docente (string apellidoNombre, string cuil, string email, DateTime fechaIngreso, int id, decimal salario)
        {
            this.ApellidoNombre = apellidoNombre;
            this.Cuil = cuil;
            this.Email = email;
            this.FechaIngreso = fechaIngreso;
            this.Id = id;
            this.Salario = salario;
        }
    }
}