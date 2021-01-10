using CapaNegocio.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Sesion
{
    public partial class frmLogin : Form
    {
        Nusuario nusuario = new Nusuario();

        public frmLogin()
        {
            InitializeComponent();
        }
        //public int cveUsuario = 0;
        //public bool existeSesion = false;
        //public string user = "";
        //public string tipoUsuario = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password =Utilidades.OperacionesFormulario.GetSHA1(txtPassword.Text.Trim());
            //VALIDACIONES
            if (usuario.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Usuario y password son obligatorios");
                return;
            }
            if(Utilidades.ClsUsuario.Login(usuario, password))
            {
                this.Close();              
            }
            else
            {
                MessageBox.Show(Utilidades.ClsUsuario.error);
            }
        }

        //public  bool salir()
        //{
        //    bool exito = false;
        //    try
        //    {
        //        cveUsuario = 0;
        //        tipoUsuario = "";
        //        user = "";
        //        txtUsuario.Clear();
        //        txtPassword.Clear();
        //        existeSesion = false;

        //        exito = true;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR SISTEMA " + ex.Message);
        //    }

        //    return exito;
        //}
    }
}
