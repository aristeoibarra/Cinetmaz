using CapaEntidades;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Salas
{
    public partial class frmSala : Form
    {
        readonly Nsala nSala = new Nsala();
        readonly Nclasificacion nclasificacion = new Nclasificacion();
        readonly Sala sala = new Sala();

        public int idSala = 0;

        public frmSala()
        {
            InitializeComponent();
        }

        private void frmSala_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            LlenarComboClasificacion();
            cmbClasificacion.Text = null;

            if (idSala > 0)
            {
                CargaDatos();
                nudCapacidad.Enabled = false;
            }
        }

        private void CargaDatos()
        {
            foreach (var item in nSala.MostrarByID(idSala))
            {
                txtNombre.Text = item.NombreSala;
                nudCapacidad.Value = item.CapacidadSala;
                cmbClasificacion.SelectedValue = item.CveclasificacionSala;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (OperacionesFormulario.ValidarTextBox(this))
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                if (idSala <= 0)
                    Agregar();
                else
                    Modificar();
            }
        }

        private void ObtenerDatos()
        {
            sala.CveSala = idSala;
            sala.NombreSala = txtNombre.Text.Trim();
            sala.CapacidadSala = Convert.ToInt32(nudCapacidad.Value);
            sala.CveclasificacionSala = Convert.ToInt32(cmbClasificacion.SelectedValue);
        }

        private void Agregar()
        {
            ObtenerDatos();

            if (nSala.Agregar(sala))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (nSala.Modificar(sala))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void LlenarComboClasificacion()
        {
            cmbClasificacion.DataSource = nclasificacion.MostrarTodos();
            cmbClasificacion.DisplayMember = "Tipo";
            cmbClasificacion.ValueMember = "Clave";
        }
    }
}
