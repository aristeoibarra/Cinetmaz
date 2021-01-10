using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Usuarios
{
    public partial class frmUsuarios : frmPadreTab
    {
        readonly Nusuario nUsuario = new Nusuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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
            frmUsuario frmU = new frmUsuario();
            frmU.ShowDialog();
            RefrescarListas();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            if (dgvListaActivos.Rows.Count != 0)
            {
                int cveUsuario = OperacionesFormulario.ObtenertId(dgvListaActivos);
                if (cveUsuario > 0)
                {
                    frmUsuario frmU = new frmUsuario();
                    frmU.idUsuario = cveUsuario;
                    frmU.ShowDialog();
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
                int cveUsuario = Utilidades.OperacionesFormulario.ObtenertId(dgvListaActivos);
                if (cveUsuario > 0)
                {
                    if (nUsuario.CambiarEstado(cveUsuario, 2))
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
            try
            {
                if (dgvListaActivos.Rows.Count != 0)
                {
                    int cveUsuario = OperacionesFormulario.ObtenertId(dgvListaActivos);
                    if (cveUsuario > 0)
                    {
                        if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (nUsuario.Eliminar(cveUsuario))
                            {
                                RefrescarListas();
                            }
                            else
                            {
                                MessageBox.Show("Este usuario no se puede eliminar");
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
                MessageBox.Show("ERROR AL ELIMINAR", "USUARIO ACTIVO");
            }
        }
        #endregion

        #region tabInactivos
        private void BtnHabilitar(object sender, EventArgs e)
        {
            if (dgvListaInactivos.Rows.Count != 0)
            {
                int cveUsuario = OperacionesFormulario.ObtenertId(dgvListaInactivos);
                if (cveUsuario > 0)
                {
                    if (nUsuario.CambiarEstado(cveUsuario, 1))
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
            try
            {
                if (dgvListaInactivos.Rows.Count != 0)
                {
                    int cveUsuario = OperacionesFormulario.ObtenertId(dgvListaInactivos);
                    if (cveUsuario > 0)
                    {
                        if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (nUsuario.Eliminar(cveUsuario))
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
            catch (Exception)
            {
                MessageBox.Show("ERROR AL ELIMINAR", "USUARIO ACTIVO");
            }
        }
        #endregion

        private void Interfaz()
        {
            try
            {
                lblTitulo.Text = "Usuarios";
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
            dgvListaActivos.DataSource = nUsuario.MostrarTodosByEstatus(1);
        }

        private void RefrescarListaInactivos()
        {
            dgvListaInactivos.DataSource = null;
            dgvListaInactivos.DataSource = nUsuario.MostrarTodosByEstatus(2);
        }

        private void RefrescarListas()
        {
            RefrescarListaActivos();
            RefrescarListaInactivos();
            Interfaz();
        }
    }
}
