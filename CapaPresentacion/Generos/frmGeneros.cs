using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Generos
{
    public partial class frmGeneros : frmPadre
    {
        readonly Ngenero nGenero = new Ngenero();

        public frmGeneros()
        {
            InitializeComponent();
        }

        private void frmGeneros_Load(object sender, EventArgs e)
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
            frmGenero frmG = new frmGenero();
            frmG.ShowDialog();
            RefrescarLista();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                int cveGenero = OperacionesFormulario.ObtenertId(dgvLista);
                if (cveGenero > 0)
                {
                    frmGenero frmG = new frmGenero();
                    frmG.idGenero = cveGenero;

                    frmG.ShowDialog();
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
            try
            {
                if (dgvLista.Rows.Count != 0)
                {
                    int cveGenero = OperacionesFormulario.ObtenertId(dgvLista);
                    if (cveGenero > 0)
                    {
                        if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (nGenero.Eliminar(cveGenero))
                            {
                                RefrescarLista();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe existir una fila seleccionada");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL ELIMINAR", "GENERO ACTIVO");
            }
        }
        #endregion

        private void RefrescarLista()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = nGenero.MostrarTodos();
            Interfaz();
        }

        private void Interfaz()
        {
            try
            {
                lblTitulo.Text = "Generos";
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema " + ex.Message);
            }
        }
    }
}
