using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gini.Entidades;

namespace Gini.Escritorio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<String> campos = new List<String>
            {
                txtClave.Text,
                txtEmail.Text,
                txtNombreUsuario.Text,
                txtTipoUsuario.Text,
            };

            if (Negocio.Validaciones.vacios(campos) && Negocio.Validaciones.EsMailValido(txtEmail.Text))
            {
                Gini.Entidades.Usuario usuario = new Gini.Entidades.Usuario
                {
                    NombreUsuario = txtNombreUsuario.Text,
                    Email = txtEmail.Text,
                    Clave = txtClave.Text,
                    TipoUsuario = int.Parse(txtTipoUsuario.Text),
                    UltimoIngreso = dtpUltimaFecha.Value,
                };
                try
                {
                    Negocio.Usuario.Agregar(usuario);
                    MessageBox.Show("Usuario agregado correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
