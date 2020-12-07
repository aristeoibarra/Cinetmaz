using System;

namespace CapaPresentacion.Clasificaciones
{
    public partial class frmClasificaciones : Utilidades.frmPadre
    {
        public frmClasificaciones()
        {
            InitializeComponent();
        }

        private void frmClasificaciones_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Clasificaciones";
            AddEventos();
        }

        private void AddEventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
        }

        private void BtnNuevo(object sender, EventArgs e)
        {
            frmClasificacion frmC = new frmClasificacion();
            frmC.ShowDialog();
        }
    }
}
