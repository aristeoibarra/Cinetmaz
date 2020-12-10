using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CapaNegocio.Negocio;
using CapaEntidades;

namespace CapaPresentacion.Clasificaciones
{
    public partial class frmClasificacion : Form
    {
        Nclasificacion nclasificacion = new Nclasificacion();
        Clasificacion clasificacion = new Clasificacion();

        public int idClasificacion = 0;
        public frmClasificacion()
        {
            InitializeComponent();         
        }

        private void frmClasificacion_Load(object sender, EventArgs e)
        {
            txtTipo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idClasificacion <= 0)
                Agregar();
            else
                Modificar();
        }

        private void Modificar()
        {
            clasificacion.CveClasificacion = idClasificacion;
            clasificacion.TipoClasificacion = txtTipo.Text.Trim();
            clasificacion.EdadMinimaClasificacion = Convert.ToInt32(txtEdad.Text.Trim());
            clasificacion.DescripcionClasificacion = txtDescripcion.Text.Trim();

            if (nclasificacion.Modificar(clasificacion))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void Agregar()
        {
            clasificacion.TipoClasificacion = txtTipo.Text.Trim();
            clasificacion.EdadMinimaClasificacion = Convert.ToInt32(txtEdad.Text.Trim());
            clasificacion.DescripcionClasificacion = txtDescripcion.Text.Trim();

            if (nclasificacion.Agregar(clasificacion))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

      
    }
}
