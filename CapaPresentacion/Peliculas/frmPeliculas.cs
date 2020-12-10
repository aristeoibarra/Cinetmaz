using System;
using System.Windows.Forms;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPeliculas : Utilidades.frmPadre
    {
        readonly Npelicula npelicula = new Npelicula();
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            Eventos();
            RefrescarLista();
            Interfaz();
        }

        private void Eventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
            cmdModificar.Click += new EventHandler(BtnModificar);
            cmdEliminar.Click += new EventHandler(BtnEliminar);
        }
        private void BtnNuevo(object sender, EventArgs e)
        {
            frmPelicula frmP = new frmPelicula();
            frmP.cmbSala.Text = null;
            frmP.ShowDialog();

            RefrescarLista();
            Interfaz();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            int id = OperacionesFormulario.ObtenertId(dgvLista);
            if (id > 0)
            {
                frmPelicula frmS = new frmPelicula();
                frmS.idPelicula = id;
                frmS.txtNombre.Text = OperacionesFormulario.ObtenerValorCelda(dgvLista, 1);
                frmS.cmbSala.SelectedValue = int.Parse(OperacionesFormulario.ObtenerValorCelda(dgvLista, 2));

                frmS.ShowDialog();
                RefrescarLista();
                Interfaz();
            }
            else
            {
                MessageBox.Show("Debe existir una fila seleccionada");
            }
        }

        private void BtnEliminar(object sender, EventArgs e)
        {
            int cvePelicula = Utilidades.OperacionesFormulario.ObtenertId(dgvLista);
            if (cvePelicula > 0)
            {
                if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (npelicula.Eliminar(cvePelicula))
                    {
                        RefrescarLista();
                        Interfaz();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe existir una fila seleccionada");
            }
        }

        private void Interfaz()
        {
            try
            {
                lblTitulo.Text = "Películas";
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema " + ex.Message);
            }
        }

        private void RefrescarLista()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = npelicula.MostrarTodos();
        }
    }
}
