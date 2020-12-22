using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPeliculas : frmPadre
    {
        readonly Npelicula nPelicula = new Npelicula();

        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            Eventos();
            RefrescarLista();
        }

        private void Eventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
            cmdModificar.Click += new EventHandler(BtnModificar);
            cmdEliminar.Click += new EventHandler(BtnEliminar);
        }

        #region Eventos Botones
        private void BtnNuevo(object sender, EventArgs e)
        {
            frmPelicula frmP = new frmPelicula();
            frmP.ShowDialog();
            RefrescarLista();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                int cvePelicula = OperacionesFormulario.ObtenertId(dgvLista);
                if (cvePelicula > 0)
                {
                    frmPelicula frmS = new frmPelicula();
                    frmS.idPelicula = cvePelicula;

                    frmS.ShowDialog();
                    RefrescarLista();
                }
                else
                {
                    MessageBox.Show("Debe existir una fila seleccionada");
                }
            }
        }

        private void BtnEliminar(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                int cvePelicula = OperacionesFormulario.ObtenertId(dgvLista);
                if (cvePelicula > 0)
                {
                    if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (nPelicula.Eliminar(cvePelicula))
                        {
                            RefrescarLista();
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
        }
        #endregion

        private void RefrescarLista()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = nPelicula.MostrarTodos();
            Interfaz();
        }

        private void Interfaz()
        {
            try
            {
                lblTitulo.Text = "Películas";
                dgvLista.Columns[2].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema " + ex.Message);
            }
        }
    }
}
