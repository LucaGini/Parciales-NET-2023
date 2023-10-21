using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gini.Entidades
{
    public class Usuario
    {
        string _clave;
        string _email;
        string _nombreUsuario;
        int _tipoUsuario;
        DateTime _ultimoIngreso;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        public int TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }
        public DateTime UltimoIngreso
        {
            get { return _ultimoIngreso; }
            set { _ultimoIngreso = value; }
        }

        public Usuario()
        {
            this._clave = "";
            this._email = "";
            this._nombreUsuario = "";
            this._tipoUsuario = 0;
            this._ultimoIngreso = DateTime.Now;
        }

        public Usuario(string clave, string email, string nombreUsuario, int tipoUsuario)
        {
            this._clave = clave;
            this._email = email;
            this._nombreUsuario = nombreUsuario;
            this._tipoUsuario = tipoUsuario;
            this._ultimoIngreso = DateTime.Now;
        }
    }
}