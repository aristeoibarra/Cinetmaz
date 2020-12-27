using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Clientes
{
    public partial class frmClientes : frmPadreTab
    {
        readonly Ncliente nCliente = new Ncliente();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Eventos();
            RefrescarListas();
        }

        private void Eventos()
        {
            //tabActivos
            cmdNuevo.Click += new EventHandler(BtnNuevo);
            cmdModificar.Click += new EventHandler(BtnModificar);
            cmdDeshabilitar.Click += new EventHandler(BtnDeshabilitar);
            cmdEliminar.Click += new EventHandler(BtnEliminar);

            // TabInactivos
            cmdHabilitar.Click += new EventHandler(BtnHabilitar);
            cmdEliminarInactivo.Click += new EventHandler(BtnEliminarInactivo);
        }

        #region tabActivos
        private void BtnNuevo(object sender, EventArgs e)
        {
            frmCliente frmC = new frmCliente();
            frmC.ShowDialog();
            RefrescarListas();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            if (dgvListaActivos.Rows.Count != 0)
            {
                int cveCliente = OperacionesFormulario.ObtenertId(dgvListaActivos);
                if (cveCliente > 0)
                {
                    frmCliente frmC = new frmCliente();
                    frmC.idCliente = cveCliente;
                    frmC.ShowDialog();
                    RefrescarListas();
                }
                else
                {
                    MessageBox.Show("Debe existir una fila seleccionada");
                }
            }
        }

        private void BtnDeshabilitar(object sender, EventArgs e)
        {
            if (dgvListaActivos.Rows.Count != 0)
            {
                int cveCliente = OperacionesFormulario.ObtenertId(dgvListaActivos);
                if (cveCliente > 0)
                {
                    if (nCliente.CambiarEstatus(cveCliente, 2))
                    {
                        RefrescarListas();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                else
                {
                    MessageBox.Show("Debe existir una fila seleccionada");
                }
            }
        }

        private void BtnEliminar(object sender, EventArgs e)
        {
            if (dgvListaActivos.Rows.Count != 0)
            {
                int cveCliente = OperacionesFormulario.ObtenertId(dgvListaActivos);
                if (cveCliente > 0)
                {
                    if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (nCliente.Eliminar(cveCliente))
                        {
                            RefrescarListas();
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
        #endregion

        #region tabInactivos
        private void BtnHabilitar(object sender, EventArgs e)
        {
            if (dgvListaInactivos.Rows.Count != 0)
            {
                int cveCliente = OperacionesFormulario.ObtenertId(dgvListaInactivos);
                if (cveCliente > 0)
                {
                    if (nCliente.CambiarEstatus(cveCliente, 1))
                    {
                        RefrescarListas();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                else
                {
                    MessageBox.Show("Debe existir una fila seleccionada");
                }
            }
        }

        private void BtnEliminarInactivo(object sender, EventArgs e)
        {
            if (dgvListaInactivos.Rows.Count != 0)
            {
                int cveCliente = OperacionesFormulario.ObtenertId(dgvListaInactivos);
                if (cveCliente > 0)
                {
                    if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (nCliente.Eliminar(cveCliente))
                        {
                            RefrescarListas();
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
        #endregion

        private void Interfaz()
        {
            try
            {
                lblTitulo.Text = "Clientes";
                dgvListaActivos.Columns[dgvListaActivos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvListaInactivos.Columns[dgvListaActivos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema " + ex.Message);
            }
        }

        private void RefrescarListaActivos()
        {
            dgvListaActivos.DataSource = null;
            dgvListaActivos.DataSource = nCliente.MostrarTodosByEstatus(1);
        }

        private void RefrescarListaInactivos()
        {
            dgvListaInactivos.DataSource = null;
            dgvListaInactivos.DataSource = nCliente.MostrarTodosByEstatus(2);
        }

        private void RefrescarListas()
        {
            RefrescarListaActivos();
            RefrescarListaInactivos();
            Interfaz();
        }
    }
}
