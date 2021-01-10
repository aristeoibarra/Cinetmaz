using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Negocio;

namespace CapaPresentacion.Salas
{
    public partial class frmReservas : Form
    {
        Npelicula  nPelicula = new Npelicula();
        Ncinetmaz nCinetmaz = new Ncinetmaz();

        public int idSala = 0;
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            LlenarCmbSala();
            cmbSala.Text = null;
        }

        void LlenarCmbSala()
        {
            cmbSala.DataSource = nPelicula.MostrarBySala(idSala);
            cmbSala.DisplayMember = "Nombre";
            cmbSala.ValueMember = "Clave";
        }

      

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void LlenarData()
        {

            int cvePelicula = int.Parse(cmbSala.SelectedValue.ToString());
            dgvLista.DataSource = nCinetmaz.MostrarReservasByPelicula(cvePelicula);
        }
        private void cmbSala_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarData();
            Interfaz();
        }

        private void Interfaz()
        {
            try
            {
                dgvLista.Columns[0].Visible = false;
                dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema " + ex.Message);
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                if (MessageBox.Show("Estas seguro de eliminar el registro seleccionado", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int cveRegistro = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());

                    if (nCinetmaz.Eliminar(cveRegistro))
                    {
                        MessageBox.Show("Se elimino con exito");
                        LlenarData();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error ");
                    }
                }
            }
        }
    }
}
