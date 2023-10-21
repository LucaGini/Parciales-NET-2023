namespace Gini.Entidades
{
    public class Usuario
    {
        string _clave;
        string _email;
        string _nombreUsuario;
        int _tipoUsuario;
        DateTime _ultimoIngreso;
        readonly int _diasUltimoIngreso;

        public string Clave { get { return _clave; } set { _clave = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public int TipoUsuario { get { return _tipoUsuario; } set { _tipoUsuario = value; } }
        public DateTime UltimoIngreso { get { return _ultimoIngreso; } set { _ultimoIngreso = value; } }
        public int DiasUltimoIngreso { get { return (DateTime.Now - _ultimoIngreso).Days; } }

        public Usuario() { }

        public Usuario(string clave, string email, string nombreUsuario, int tipoUsuario, DateTime ultimoIngreso)
        {
            this._clave = clave;
            this._email = email;
            this._nombreUsuario = nombreUsuario;
            this._tipoUsuario = tipoUsuario;
            this._ultimoIngreso = ultimoIngreso;
        }
    }
}