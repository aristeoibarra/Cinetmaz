using System;

namespace CapaPresentacion.Clientes
{
    public partial class frmClientes : Utilidades.frmPadre
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cmbActivo.SelectedIndex = 0;
            cmdDeshabilitar.Visible = true;
            cmdHabilitar.Visible = true;
            lblTitulo.Text = "Clientes";
            AddEventos();
        }

        private void AddEventos()
        {
            cmdNuevo.Click += new EventHandler(BtnNuevo);
        }

        private void BtnNuevo(object sender, EventArgs e)
        {
            frmCliente frmC = new frmCliente();
            frmC.ShowDialog();
        }
    }
}
