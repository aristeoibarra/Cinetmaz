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
    public partial class frmReservacion : Form
    {
        public frmReservacion()
        {
            InitializeComponent();
        }

        private void frmReservacion_Load(object sender, EventArgs e)
        {
            //63, 118, 140
            txtNombre.Focus();
            GenerarAsiento(15);
           
            Utilidades.OperacionesFormulario.CentraX(splitContainer1.Panel2, groupBox1);
            Utilidades.OperacionesFormulario.CentraX(groupBox1, pnlBtnAsientos);
            Utilidades.OperacionesFormulario.CentraX(splitContainer1.Panel2, groupBox2);
            Utilidades.OperacionesFormulario.CentraX(splitContainer1.Panel2, groupBox3);
            Utilidades.OperacionesFormulario.CentraX(splitContainer1.Panel2, groupBox5);


            Utilidades.OperacionesFormulario.CentraX(groupBox3, dgvLista);

            Utilidades.OperacionesFormulario.CentraX(splitContainer2.Panel1, groupBox4);
            Utilidades.OperacionesFormulario.CentraX(splitContainer2.Panel2, groupBox6);
            
        }

        void GenerarAsiento(int cantAsientos)
        {
            Button[] btnAsiento = new Button[cantAsientos];
            int cont = 0, valorTop = 1, valorLeft = 0;

            for (int i = 0; i < btnAsiento.Length; i++)
            {
                if (cont != 5)
                {
                    DetallesBtnAsiento(btnAsiento, i, valorTop, valorLeft++, pnlBtnAsientos);
                    cont++;
                }
                else
                {
                    valorTop += 100;
                    valorLeft = 0;
                    cont = 0;
                    i--;
                }
            }
        }

        private void DetallesBtnAsiento(Button[] btnAsiento, int i, int valorTop, int valorLeft, Panel pnlAsientos)
        {
            btnAsiento[i] = new Button
            {
                Size = new Size(96, 96),
                Text = $"{i + 1}",
                Top = valorTop,
                Left = valorLeft * 100,
                Image = Properties.Resources.silla_de_cine,
                BackColor = Color.FromArgb(0, 192, 0),
                ImageAlign = ContentAlignment.TopCenter,
                TextAlign = ContentAlignment.BottomCenter,
                Font = new Font("Arial", 14.25743F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White
            };

            pnlAsientos.Controls.Add(btnAsiento[i]);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

