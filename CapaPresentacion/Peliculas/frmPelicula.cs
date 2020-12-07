using System;
using System.Windows.Forms;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPelicula : Form
    {
        public frmPelicula()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {

        }
    }
}
