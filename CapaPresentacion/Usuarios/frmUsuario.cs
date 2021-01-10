using CapaEntidades;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Windows.Forms;


namespace CapaPresentacion.Usuarios
{
    public partial class frmUsuario : Form
    {
        readonly Nusuario nUsuario = new Nusuario();
        readonly Usuario usuario = new Usuario();

        public int idUsuario = 0;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            if (idUsuario > 0)
            {
                if (idUsuario == 1)
                {
                    cmbTipo.Enabled = false;
                    cmbTipo.Text = "Admin";
                }
                else
                {
                    cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                }          
                   
                CargaDatos();
            }
        }

        private void CargaDatos()
        {
            foreach (var item in nUsuario.MostrarByID(idUsuario))
            {
                txtNombre.Text = item.NombreUsuario;
                txtUsuario.Text = item.UserUsuario;
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
                if (idUsuario <= 0)
                    Agregar();
                else
                    Modificar();
            }
        }

        private void ObtenerDatos()
        {
            usuario.CveUsuario = idUsuario;
            usuario.NombreUsuario = txtNombre.Text.Trim();
            usuario.UserUsuario = txtUsuario.Text.Trim();
            usuario.PasswordUsuario = OperacionesFormulario.GetSHA1(txtPass.Text.Trim());
            usuario.TipoUsuario = cmbTipo.Text.Trim();
        }

        private void Agregar()
        {
            ObtenerDatos();

            if (nUsuario.Agregar(usuario))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (nUsuario.Modificar(usuario))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked)
            {
                if (txtPass.PasswordChar == '*')
                {
                    txtPass.PasswordChar = '\0';
                }
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        #region Validaciones TextBoxs
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            OperacionesFormulario.SoloLetras(sender, e);
        }
        #endregion
    }
}
