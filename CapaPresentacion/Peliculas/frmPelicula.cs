using System;
using System.Windows.Forms;
using CapaNegocio.Negocio;
using CapaEntidades;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPelicula : Form
    {
        Npelicula npelicula = new Npelicula();
        NSala nSala = new NSala();
        Pelicula pelicula = new Pelicula();

        public int idPelicula = 0;

        public frmPelicula()
        {
            InitializeComponent();
            LlenarComboSala();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idPelicula <= 0)
                Agregar();
            else
                Modificar();
        }

        private void Modificar()
        {
            pelicula.CvePelicula = idPelicula;
            pelicula.NombrePelicula = txtNombre.Text.Trim();
            pelicula.CvesalaPelicula = Convert.ToInt32(cmbSala.SelectedValue);

            if (npelicula.Modificar(pelicula))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void Agregar()
        {
            pelicula.NombrePelicula = txtNombre.Text.Trim();
            pelicula.CvesalaPelicula = Convert.ToInt32(cmbSala.SelectedValue);

            if (npelicula.Agregar(pelicula))
            {
                MessageBox.Show("Registro agregado con exito");
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
