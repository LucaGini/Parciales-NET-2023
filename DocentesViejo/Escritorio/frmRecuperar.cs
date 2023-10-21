using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string cuil = txtCuil.Text;

            Gini.Entidades.Docente docente = new Gini.Entidades.Docente();

            try
            {
                docente = Gini.Negocio.Docente.GetOneByCuil(cuil);
                if (docente == null)
                {
                    throw new Exception("No se encontró ningún docente con ese CUIL");
                }
                else
                {
                    lblId.Text = $"ID: {docente.Id}";
                    lblNombre.Text = $"Nombre: {docente.ApellidoNombre}";
                    lblCuil.Text = $"CUIL: {docente.Cuil}";
                    lblEmail.Text = $"Email: {docente.Email}";
                    lblSalario.Text = $"Salario: {docente.Salario}";
                    lblFechaIngreso.Text = $"Fecha de ingreso: {docente.FechaIngreso}";
                    lblAntiguedad.Text = $"Antiguedad: {docente.Antiguedad}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
