using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

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
            frmClasificacion frmC = new frmClasificacion();
            frmC.ShowDialog();
            RefrescarLista();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                int id = OperacionesFormulario.ObtenertId(dgvLista);
                if (id > 0)
                {
                    //DataTable dt = nClasificacion.LlenarByID(id);

                    frmClasificacion frmC = new frmClasificacion();
                    frmC.idClasificacion = id;

                    //DataRow row = dt.Rows[0];
                    //frmC.txtTipo.Text = row[0].ToString();
                    //frmC.txtEdad.Text = row[1].ToString();
                    //frmC.txtDescripcion.Text = row[2].ToString();

                    frmC.ShowDialog();
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
                        if (nClasificacion.Eliminar(cveClasificacion))
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
        #endregion

        private void RefrescarLista()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = nClasificacion.MostrarTodos();
            Interfaz();
            ChageRowText();
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

        private void ChageRowText()
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {         
               string edadMin = dgvLista.Rows[row.Index].Cells["Edad_Minima"].Value.ToString();

                if (edadMin == "0")
                {
                    dgvLista.Rows[row.Index].Cells["Edad_Minima"].Value = "[ALL AGE]";
                }
            }
        }
    }
}
