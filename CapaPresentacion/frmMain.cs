using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //color background icons #FF5C73F2 
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            if (!DetectarFormularioAbierto("frmPeliculas"))
            {
                Peliculas.frmPeliculas frmP = new Peliculas.frmPeliculas();
                frmP.MdiParent = this;
                frmP.Show();
                frmP.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnSalas_Click(object sender, EventArgs e)
        {
            if (!DetectarFormularioAbierto("frmSalas"))
            {
                Salas.frmSalas frmS = new Salas.frmSalas();
                frmS.MdiParent = this;
                frmS.Show();
                frmS.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClasificaciones_Click(object sender, EventArgs e)
        {
            if (!DetectarFormularioAbierto("frmClasificaciones"))
            {
                Clasificaciones.frmClasificaciones frmC = new Clasificaciones.frmClasificaciones();
                frmC.MdiParent = this;
                frmC.Show();
                frmC.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!DetectarFormularioAbierto("frmClientes"))
            {
                Clientes.frmClientes frmC = new Clientes.frmClientes();
                frmC.MdiParent = this;
                frmC.Show();
                frmC.WindowState = FormWindowState.Maximized;
            }
        }

        #region METODOS PRIVADOS
        private bool DetectarFormularioAbierto(string formulario)
        {
            bool abierto = false;

            if (Application.OpenForms[formulario] != null)
            {
                abierto = true;
                Application.OpenForms[formulario].Activate();
                Application.OpenForms[formulario].WindowState = FormWindowState.Maximized;
            }
            return abierto;
        }

        private void CerrarFormuarios()
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();
            }
        }


        #endregion

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (!DetectarFormularioAbierto("frmUsuarios"))
            {
                Usuarios.frmUsuarios frmU = new Usuarios.frmUsuarios();
                frmU.MdiParent = this;
                frmU.Show();
                frmU.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
