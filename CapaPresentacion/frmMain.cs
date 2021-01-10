using CapaNegocio.Negocio;
using CapaPresentacion.Sesion;
using System;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmMain : Form
    {
        Nusuario nusuario = new Nusuario();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            toolStripTextBox1.Visible = false;
            toolStripTextBox3.Visible = false;
            SinSesion();

            //color background icons #FF5C73F2 
        }
       
        private void SinSesion()
        {
           panel2.Enabled = false;
            CerrarFormuarios();

            frmLogin frmL = new frmLogin();
            frmL.ShowDialog();

            if (ClsUsuario.existeSesion && ClsUsuario.tipoUsuario == "Admin")
            {
               // DataUsuario(frmL);

                panel2.Enabled = true;

                inicioToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                salasToolStripMenuItem.Visible = true;
                adminToolStripMenuItem.Visible = true;
                películasToolStripMenuItem.Visible = true;


                toolStripTextBox1.Visible = true;
                toolStripTextBox3.Visible = true;

                tstUser.Text = ClsUsuario.nombre;
                tstTipo.Text = ClsUsuario.tipoUsuario;
            }
            else if (ClsUsuario.existeSesion && ClsUsuario.tipoUsuario == "User")
            {
                inicioToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                salasToolStripMenuItem.Visible = false;
                adminToolStripMenuItem.Visible = false;
                películasToolStripMenuItem.Visible = false;


                toolStripTextBox1.Visible = true;
                toolStripTextBox3.Visible = true;

                panel2.Enabled = true;
                tstUser.Text = ClsUsuario.nombre;
                tstTipo.Text = ClsUsuario.tipoUsuario;
            }

        }

        private void DataUsuario(frmLogin frmL)
        {
            //panel2.Enabled = true;
            //cveUsuario = frmL.cveUsuario;
            //tstUser.Text = frmL.user;
            //tstTipo.Text = frmL.tipoUsuario;           
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
            if (!DetectarFormularioAbierto("frmClientes"))
            {
                Clientes.frmClientes frmC = new Clientes.frmClientes();
                frmC.MdiParent = this;
                frmC.Show();
                frmC.WindowState = FormWindowState.Maximized;
            }
        }


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
            if (!DetectarFormularioAbierto("frmUsuarios"))
            {
                Usuarios.frmUsuarios frmU = new Usuarios.frmUsuarios();
                frmU.MdiParent = this;
                frmU.Show();
                frmU.WindowState = FormWindowState.Maximized;
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
        }

       

      

       
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!ClsUsuario.existeSesion)
                SinSesion();
            else
                MessageBox.Show("Cierra la sesión primero");
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstTipo.Clear();
            tstUser.Clear();

            toolStripTextBox1.Visible = false;
            toolStripTextBox3.Visible = false;

            if (ClsUsuario.Salir())
            {
                SinSesion();               
            }
            else
            {
                MessageBox.Show(ClsUsuario.error);
            }
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
            if (!DetectarFormularioAbierto("frmPeliculas"))
            {
                Peliculas.frmPeliculas frmP = new Peliculas.frmPeliculas();
                frmP.MdiParent = this;
                frmP.Show();
                frmP.WindowState = FormWindowState.Maximized;
            }
        }

        private void generosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
            if (!DetectarFormularioAbierto("frmGeneros"))
            {
                Generos.frmGeneros frmG = new Generos.frmGeneros();
                frmG.MdiParent = this;
                frmG.Show();
                frmG.WindowState = FormWindowState.Maximized;
            }
        }

        private void salasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
            if (!DetectarFormularioAbierto("frmSalas"))
            {
                Salas.frmSalas frmS = new Salas.frmSalas();
                frmS.MdiParent = this;
                frmS.Show();
                frmS.WindowState = FormWindowState.Maximized;
            }
        }

        private void clasificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormuarios();
            if (!DetectarFormularioAbierto("frmClasificaciones"))
            {
                Clasificaciones.frmClasificaciones frmC = new Clasificaciones.frmClasificaciones { MdiParent = this };
                frmC.Show();
                frmC.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
