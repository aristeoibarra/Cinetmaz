using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    public partial class frmPadreTab : Form
    {
        public frmPadreTab()
        {
            InitializeComponent();
        }

        private void tpInactivos_Click(object sender, EventArgs e)
        {
            
        }

        void MostrarBotones(bool v1, bool v2)
        {
            // Botones tabActivos
            cmdNuevo.Visible = v1;
            cmdModificar.Visible = v1;
            cmdDeshabilitar.Visible = v1;
            cmdEliminar.Visible = v1;

            // Botones tabInactivos
            cmdHabilitar.Visible = v2;
            cmdEliminarInactivo.Visible = v2;
        }

        private void tabDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDatos.SelectedTab == tpActivos)
                MostrarBotones(true, false);
            else
                MostrarBotones(false, true);             
        }

        private void frmPadreTab_Load(object sender, EventArgs e)
        {
        }
    }
}
