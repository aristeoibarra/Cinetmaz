using System;
using System.Windows.Forms;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Salas
{
    public partial class frmSalas : Utilidades.frmPadre
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
            frmSala frmS = new frmSala();
            frmS.cmbClasificacion.Text = null;
            frmS.ShowDialog();
            
            RefrescarLista();
            Interfaz();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            int id = OperacionesFormulario.ObtenertId(dgvLista);
            if (id > 0)
            {
                frmSala frmS = new frmSala();
                frmS.idSala = id;
                frmS.txtNombre.Text = OperacionesFormulario.ObtenerValorCelda(dgvLista, 1);
                frmS.nudCapacidad.Value = int.Parse(OperacionesFormulario.ObtenerValorCelda(dgvLista, 2));
                frmS.cmbClasificacion.SelectedValue = int.Parse(OperacionesFormulario.ObtenerValorCelda(dgvLista, 3));

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
            int cveClasificacion = Utilidades.OperacionesFormulario.ObtenertId(dgvLista);
            if (cveClasificacion > 0)
            {
                if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nSala.Eliminar(cveClasificacion))
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
                lblTitulo.Text = "Salas";
                dgvLista.Columns[3].Visible = false;
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
            dgvLista.DataSource = nSala.MostrarTodos();
        }
    }
}
