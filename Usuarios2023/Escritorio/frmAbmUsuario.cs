using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gini.Negocio;
using Gini.Entidades;

namespace Escritorio
{
    public partial class frmAbmUsuario : Form
    {
        public frmAbmUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string clave = this.txtPassword.Text;
            string email = this.txtEmail.Text;
            string nombreUsuario = this.txtUsername.Text;
            int tipoUsuario = Convert.ToInt32(this.txtUserType.Text);

            if (Gini.Negocio.Validaciones.vacios(clave, nombreUsuario, email, tipoUsuario))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Gini.Entidades.Usuario usuario = new Gini.Entidades.Usuario(clave, email, nombreUsuario, tipoUsuario);
                Gini.Negocio.Usuario.Add(usuario);
                MessageBox.Show("Usuario agregado con éxito");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string clave = this.txtPassword.Text;
            string email = this.txtEmail.Text;
            string nombreUsuario = this.txtUsername.Text;
            int tipoUsuario = Convert.ToInt32(this.txtUserType.Text);

            if (Gini.Negocio.Validaciones.vacios(clave, nombreUsuario, email, tipoUsuario))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Gini.Entidades.Usuario usuario = Gini.Negocio.Usuario.GetOneByUsername(nombreUsuario);
                usuario.Clave = clave;
                usuario.Email = email;
                usuario.TipoUsuario = tipoUsuario;
                Gini.Negocio.Usuario.Update(usuario);
                MessageBox.Show("Usuario actualizado con éxito");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!(txtUsername.Text == ""))
            {
                string nombreUsuario = this.txtUsername.Text;
                Gini.Entidades.Usuario usuario = Gini.Negocio.Usuario.GetOneByUsername(nombreUsuario);
                Gini.Negocio.Usuario.Delete(usuario);
                MessageBox.Show("Usuario eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Debe completar el campo Nombre de Usuario");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!(txtFilterUsername.Text == ""))
            {
                string nombreUsuario = this.txtFilterUsername.Text;
                List<Gini.Entidades.Usuario> lista = Gini.Negocio.Usuario.GetAllByUserName(nombreUsuario);
                this.dgvUsuarios.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Debe completar el campo del filtro o usuario no encontrado.");
            }
        }

        private void frmAbmUsuario_Load(object sender, EventArgs e)
        {
            List<Gini.Entidades.Usuario> lista = Gini.Negocio.Usuario.GetAll();
            this.dgvUsuarios.DataSource = lista;
        }
    }
}
