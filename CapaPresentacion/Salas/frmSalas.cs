using System;

namespace CapaPresentacion.Salas
{
    public partial class frmSalas : Utilidades.frmPadre
    {
        public frmSalas()
        {
            InitializeComponent();
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Salas";
            AddEventos();
        }

        private void AddEventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
        }

        private void BtnNuevo(object sender, EventArgs e)
        {
            frmSala frmS = new frmSala();
            frmS.ShowDialog();
        }
    }
}
