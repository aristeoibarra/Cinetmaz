using CapaEntidades;
using CapaNegocio.Negocio;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.Reservación
{
    public partial class frmReservacion : Form
    {
        // variables para operaciones cliente
        public int idCliente = 0, edadCliente = 0;

        // variables para operaciones sala
        public int idSala = 0;

        //Variables para operaciones Asiento
        public int idAsiento = 0, numeroAsiento = 0;

        // clases Negocio
        readonly Ncliente nCliente = new Ncliente();
        readonly Npelicula nPelicula = new Npelicula();
        readonly Nsala nSala = new Nsala();
        readonly Nasiento nAsiento = new Nasiento();
        readonly Ncinetmaz nCinetmaz = new Ncinetmaz();

        //Entidadees
        readonly Cinetmaz cinetmaz = new Cinetmaz();

        public frmReservacion()
        {
            InitializeComponent();
        }

        private void frmReservacion_Load(object sender, EventArgs e)
        {
            if (idCliente > 0)
            {
                CargaDatos();
                LlenarComboPelicula();
                cmbPelicula.Text = null;
            }
        }

        private void CargaDatos()
        {
            foreach (var item in nCliente.MostrarByID(idCliente))
            {
                lblNombre.Text = item.NombreCliente;
                lblApaterno.Text = item.ApepaternoCliente;
                lblAMaterno.Text = item.ApematernoCliente;
                lblEdad.Text = item.EdadCliente.ToString();

                edadCliente = item.EdadCliente;
            }
        }

        private void LlenarComboPelicula()
        {
            cmbPelicula.DataSource = nPelicula.MostrarByEdad(edadCliente);
            cmbPelicula.DisplayMember = "Nombre";
            cmbPelicula.ValueMember = "Clave";
        }

        void GenerarAsiento(int cantAsientos)
        {
            Array[] asiento = new Array[cantAsientos];

            int cont = 0, valorTop = 1, valorLeft = 0;

            for (int i = 0; i < asiento.Length; i++)
            {
                if (cont != 5)
                {
                    DetallesBtnAsiento(i, valorTop, valorLeft++, pnlBtnAsientos);
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

        private void DetallesBtnAsiento(int i, int valorTop, int valorLeft, Panel pnlAsientos)
        {
            Button btnAsiento = new Button()
            {
                Size = new Size(92, 92),
                Name = Convert.ToString(i + 1),
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

            btnAsiento.Click += new EventHandler(BtnAsiento);
            pnlAsientos.Controls.Add(btnAsiento);
        }

        private void BtnAsiento(object sender, EventArgs e)
        {
            foreach (var boton in pnlBtnAsientos.Controls)
            {
                if (boton is Button r)
                {
                    if (r.Name == ((Button)sender).Name)
                    {
                        numeroAsiento = int.Parse(r.Name);
                        SeleccionarAsiento((Button)sender, numeroAsiento, 1);
                        return;
                    }
                }
            }
        }

        private int At = 0;
        private void SeleccionarAsiento(Button boton, int numeroAsiento, int totalAsiento)
        {
            Color Verde = Color.FromArgb(0, 192, 0);

            if (At < totalAsiento)
            {
                if (boton.BackColor == Verde)
                {
                    boton.BackColor = Color.Orange;
                    ObtenerCveAsiento(idSala, numeroAsiento);
                    At += 1;
                }
            }
            else if (At >= totalAsiento && boton.BackColor == Color.Orange)
            {
                boton.BackColor = Verde;
                idAsiento = 0;
                At -= 1;
            }
        }

        private void cmbPelicula_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedValue != null)
            {
                int idPelicula = int.Parse(cmbPelicula.SelectedValue.ToString());

                foreach (var item in nPelicula.MostrarByID(idPelicula))
                {
                    lblDuracion.Text = item.DuracionPelicula.ToString().Substring(1);
                    lblGenero.Text = item.NombreGenero;
                    lblSala.Text = item.NombreSala;
                    lblClasificacion.Text = item.TipoClasificacion;

                    if (item.PortadaPelicula != null)
                    {
                        MemoryStream stream = new MemoryStream(item.PortadaPelicula);
                        Bitmap image = new Bitmap(stream);
                        PicPortada.Image = image;
                    }

                    pnlBtnAsientos.Controls.Clear();
                    ObtenerCapacidadSala(item.CvesalaPelicula);
                    CargaDatosReservas(idPelicula);
                    CargarAsientosOcupados(idPelicula);
                }
            }

        }

        private void Reservacion()
        {
            ObtenerDatos();

            if (nCinetmaz.Agregar(cinetmaz))
            {
                MessageBox.Show("Reservación agregada con exito");
            }
        }

        private void ObtenerDatos()
        {
            cinetmaz.CveclienteCinetmaz = idCliente;
            cinetmaz.CvepeliculaCinetmaz = Convert.ToInt32(cmbPelicula.SelectedValue);
            cinetmaz.CveasientoCinetmaz = idAsiento;
        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            if (cmbPelicula.Text == string.Empty || idAsiento <= 0)
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                Reservacion();
            }
        }

        private void ObtenerCapacidadSala(int CvesalaPelicula)
        {
            foreach (var item in nSala.ObtenerCapacidad(CvesalaPelicula))
            {
                idSala = item.cve_sala;
                GenerarAsiento(item.capacidad_sala);
            }
        }

        private void ObtenerCveAsiento(int cveSala, int numeroAsiento)
        {
            idAsiento = nAsiento.ObtenerCveAsiento(cveSala, numeroAsiento);
        }

        private void CargaDatosReservas(int idPelicula)
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = nCinetmaz.MostrarReservasByPelicula(idPelicula);
            
            if(dgvLista.Rows.Count != 0)
            {
                dgvLista.Rows[0].Selected = false;
            }

            dgvLista.Columns[dgvLista.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void CargarAsientosOcupados(int idPelicula)
        {
            var asientosOcupados = nCinetmaz.MostrarReservasByPelicula(idPelicula);

            foreach (var item in asientosOcupados)
            {
                foreach (object boton in pnlBtnAsientos.Controls)
                {
                    if (boton is Button b)
                    {
                        if (item.Asiento.ToString() == b.Name)
                        {                          
                            b.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}

