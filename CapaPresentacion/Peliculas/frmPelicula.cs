using CapaEntidades;
using CapaNegocio.Negocio;
using System;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPelicula : Form
    {
        readonly Npelicula npelicula = new Npelicula();
        readonly NSala nSala = new NSala();

        readonly Pelicula pelicula = new Pelicula();

        public int idPelicula = 0;

        public frmPelicula()
        {
            InitializeComponent();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            LlenarComboSala();
            cmbSala.Text = null;           

            if (idPelicula > 0)
            {
                CargaDatos();
            }
        }

        private void CargaDatos()
        {
            foreach (var item in npelicula.MostrarByID(idPelicula))
            {
                txtNombre.Text = item.NombrePelicula;
                cmbSala.SelectedValue = item.CvesalaPelicula;
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
                if (idPelicula <= 0)
                    Agregar();
                else
                    Modificar();
            }          
        }

        private void ObtenerDatos()
        {
            pelicula.CvePelicula = idPelicula;
            pelicula.NombrePelicula = txtNombre.Text.Trim();
            pelicula.CvesalaPelicula = Convert.ToInt32(cmbSala.SelectedValue);
        }

        private void Agregar()
        {
            ObtenerDatos();

            if (npelicula.Agregar(pelicula))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (npelicula.Modificar(pelicula))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void LlenarComboSala()
        {
            cmbSala.DataSource = nSala.MostrarTodos();
            cmbSala.DisplayMember = "Nombre";
            cmbSala.ValueMember = "Clave";
        }
    }
}
