using System;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPeliculas : Utilidades.frmPadre
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Películas";
            AddEventos();
        }

        private void AddEventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
        }

        private void BtnNuevo(object sender, EventArgs e)
        {
            frmPelicula frmP = new frmPelicula();
            frmP.ShowDialog();
        }
    }
}
