using System;
using System.Windows.Forms;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Clasificaciones
{
    public partial class frmClasificaciones : frmPadre
    {
        readonly Nclasificacion nClasificacion = new Nclasificacion();

        public frmClasificaciones()
        {
            InitializeComponent();
        }

        private void frmClasificaciones_Load(object sender, EventArgs e)
        {          
            Eventos();
            RefrescarLista();
            Interfaz();
        }


        #region Eventos Botones
        private void BtnNuevo(object sender, EventArgs e)
        {
            frmClasificacion frmC = new frmClasificacion();
            frmC.ShowDialog();
            RefrescarLista();
            Interfaz();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            int id = OperacionesFormulario.ObtenertId(dgvLista);
            if (id > 0)
            {
                frmClasificacion frmC = new frmClasificacion();
                frmC.idClasificacion = id;
                frmC.txtTipo.Text = OperacionesFormulario.ObtenerValorCelda(dgvLista, 1);
                frmC.txtEdad.Text = OperacionesFormulario.ObtenerValorCelda(dgvLista, 2);
                frmC.txtDescripcion.Text = OperacionesFormulario.ObtenerValorCelda(dgvLista, 3);

                frmC.ShowDialog();
                RefrescarLista();
                Interfaz();
            }
            else
            {
                MessageBox.Show("Debe existir una fila seleccionada");
            }
        } 
        #endregion

        private void Eventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
            cmdModificar.Click += new EventHandler(BtnModificar);
            cmdEliminar.Click += new EventHandler(BtnEliminar);
        }

        private void BtnEliminar(object sender, EventArgs e)
        {
            int cveClasificacion = Utilidades.OperacionesFormulario.ObtenertId(dgvLista);
            if (cveClasificacion > 0)
            {
                if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nClasificacion.Eliminar(cveClasificacion))
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
                lblTitulo.Text = "Clasificaciones";
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
            dgvLista.DataSource = nClasificacion.MostrarTodos();
        }
    }
}
