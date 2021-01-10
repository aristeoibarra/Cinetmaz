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

namespace CapaPresentacion.Reservación
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        public int cveCinetmaz = 0;
        Ncinetmaz nCinetmaz = new Ncinetmaz();
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            
        }
    }
}
