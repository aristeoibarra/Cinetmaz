using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Salas
{
    public partial class frmSalas : frmPadre
    {
        readonly NSala nSala = new NSala();

        public frmSalas()
        {
            InitializeComponent();
        }

        private void frmSalas_Load(object sender, EventArgs e)
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
            frmSala frmS = new frmSala();
            frmS.ShowDialog();
            RefrescarLista();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                int cveClasificacion = OperacionesFormulario.ObtenertId(dgvLista);
                if (cveClasificacion > 0)
                {
                    frmSala frmS = new frmSala();
                    frmS.idSala = cveClasificacion;

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
                int cveClasificacion = OperacionesFormulario.ObtenertId(dgvLista);
                if (cveClasificacion > 0)
                {
                    if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (nSala.Eliminar(cveClasificacion))
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
            dgvLista.DataSource = nSala.MostrarTodos();
            Interfaz();
        }

        private void Interfaz()
        {
            try
            {
                lblTitulo.Text = "Salas";
                dgvLista.Columns[3].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema " + ex.Message);
            }
        }
    }
}
