using System;
using System.Windows.Forms;
using CapaNegocio.Negocio;
using CapaEntidades;

namespace CapaPresentacion.Salas
{
    public partial class frmSala : Form
    {
        NSala nSala = new NSala();
        Nclasificacion nclasificacion = new Nclasificacion();
        Sala sala = new Sala();
        
        public int idSala = 0;

        public frmSala()
        {
            InitializeComponent();
            LlenarComboClasificacion();
        }

        private void frmSala_Load(object sender, EventArgs e)
        {                 
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idSala <= 0)
                Agregar();
            else
                Modificar();
        }

        private void Modificar()
        {
            sala.CveSala = idSala;
            sala.NombreSala = txtNombre.Text.Trim();
            sala.CapacidadSala =Convert.ToInt32(nudCapacidad.Value);
            sala.CveclasificacionSala = Convert.ToInt32(cmbClasificacion.SelectedValue);

            if (nSala.Modificar(sala))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void Agregar()
        {           
            sala.NombreSala = txtNombre.Text.Trim();
            sala.CapacidadSala = Convert.ToInt32(nudCapacidad.Value);
            sala.CveclasificacionSala = Convert.ToInt32(cmbClasificacion.SelectedValue);

            if (nSala.Agregar(sala))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        void LlenarComboClasificacion()
        {
            cmbClasificacion.DataSource = nclasificacion.MostrarTodos();
            cmbClasificacion.DisplayMember = "Tipo";
            cmbClasificacion.ValueMember = "Clave";
        }

        

      
    }
}
