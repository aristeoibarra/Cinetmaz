using CapaEntidades;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;


namespace CapaPresentacion.Generos
{
    public partial class frmGenero : Form
    {
        readonly Ngenero nGenero = new Ngenero();
        readonly Genero genero = new Genero();

        public int idGenero = 0;

        public frmGenero()
        {
            InitializeComponent();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            if (idGenero > 0)
            {
                CargaDatos();
            }
        }

        private void CargaDatos()
        {
            foreach (var item in nGenero.MostrarByID(idGenero))
            {
                txtNombre.Text = item.NombreGenero;
            }          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (OperacionesFormulario.ValidarTextBox(this))
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                if (idGenero <= 0)
                    Agregar();
                else
                    Modificar();
            }
        }

        private void ObtenerDatos()
        {
            genero.CveGenero = idGenero;
            genero.NombreGenero = txtNombre.Text.Trim();            
        }

        private void Agregar()
        {
            ObtenerDatos();

            if (nGenero.Agregar(genero))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (nGenero.Modificar(genero))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        #region Validaciones TextBoxs
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            OperacionesFormulario.SoloLetras(sender, e);
        }
        #endregion
    }
}
