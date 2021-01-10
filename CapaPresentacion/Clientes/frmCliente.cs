using CapaEntidades;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Clientes
{
    public partial class frmCliente : Form
    {
        readonly Ncliente nCliente = new Ncliente();
        readonly Cliente cliente = new Cliente();

        public int idCliente = 0;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            if (idCliente > 0)
            {
                CargaDatos();
            }
        }

        private void CargaDatos()
        {
            foreach (var item in nCliente.MostrarByID(idCliente))
            {
                txtNombre.Text = item.NombreCliente;
                txtApaterno.Text = item.ApepaternoCliente;
                txtAmaterno.Text = item.ApepaternoCliente;
                txtEdad.Text = item.EdadCliente.ToString();
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
                if (idCliente <= 0)
                    Agregar();
                else
                    Modificar();
            }
        }

        private void ObtenerDatos()
        {
            cliente.CveCliente = idCliente;
            cliente.NombreCliente = txtNombre.Text.Trim();
            cliente.ApepaternoCliente = txtApaterno.Text.Trim();
            cliente.ApematernoCliente = txtAmaterno.Text.Trim();
            cliente.EdadCliente = Convert.ToInt32(txtEdad.Text.Trim());
            cliente.CveusuarioaltaCliente = ClsUsuario.idUsuario;
            cliente.CveusuariomodCliente = ClsUsuario.idUsuario;
        }

        private void Agregar()
        {
            ObtenerDatos();

            if (nCliente.Agregar(cliente))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (nCliente.Modificar(cliente))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        #region Validaciones TextBoxs
        private void txtBoxSoloLetras(object sender, KeyPressEventArgs e)
        {
            OperacionesFormulario.SoloLetras(sender, e);
        }

        private void txtBoxSoloNumeros(object sender, KeyPressEventArgs e)
        {
            OperacionesFormulario.SoloNumeros(sender, e);
        }
        #endregion
    }
}
