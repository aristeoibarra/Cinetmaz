using CapaEntidades;
using CapaNegocio.Negocio;
using CapaPresentacion.Utilidades;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.Peliculas
{
    public partial class frmPelicula : Form
    {
        readonly Npelicula nPelicula = new Npelicula();
        readonly Nsala nSala = new Nsala();
        readonly Ngenero nGenero = new Ngenero();

        readonly Pelicula pelicula = new Pelicula();

        public int idPelicula = 0;

        public frmPelicula()
        {
            InitializeComponent();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {           
            txtNombre.Focus();
            LlenarComboSala();
            LlenarComboGenero();

            cmbSala.Text = null;
            cmbGenero.Text = null;
            lbClasificacion.Text = "";

            if (idPelicula > 0)
            {
                CargaDatos();
            }
            
        }

        private void CargaDatos()
        {
            foreach (var item in nPelicula.MostrarByID(idPelicula))
            {
                txtNombre.Text = item.NombrePelicula;
                txtDuracion.Text = item.DuracionPelicula.ToString().Substring(1);
                cmbGenero.SelectedValue = item.CvegeneroPelicula;
                cmbSala.SelectedValue = item.CvesalaPelicula;
                lbClasificacion.Text = item.TipoClasificacion;

                if(item.PortadaPelicula != null)
                {
                    MemoryStream stream = new MemoryStream(item.PortadaPelicula);
                    Bitmap image = new Bitmap(stream);
                    picimagen.Image = image;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {          
            if (OperacionesFormulario.ValidarTextBox(this))
            {
                MessageBox.Show("Campos vacios");
                return;
            }

            if(picimagen.Image == null)
            {
                MessageBox.Show("Agregue una imagen");
            }
            else
            {
                if (idPelicula <= 0)
                    Agregar();
                else
                    Modificar();
            }
        }

        private void ObtenerDatos()
        {
            pelicula.CvePelicula = idPelicula;
            pelicula.NombrePelicula = txtNombre.Text.Trim();
            try
            {
                pelicula.DuracionPelicula = TimeSpan.Parse(txtDuracion.Text.Trim());
            }
            catch (Exception)
            {
                pelicula.DuracionPelicula = TimeSpan.Parse("0");
            }
            pelicula.CvegeneroPelicula = Convert.ToInt32(cmbGenero.SelectedValue);
            pelicula.CvesalaPelicula = Convert.ToInt32(cmbSala.SelectedValue);
            pelicula.PortadaPelicula = OperacionesFormulario.ConviertePicBoxImageToByte(picimagen);
        }

        private void Agregar()
        {
            ObtenerDatos();

            if(pelicula.DuracionPelicula != TimeSpan.Parse("0"))
            {
                if (nPelicula.Agregar(pelicula))
                {
                    MessageBox.Show("Registro agregado con exito");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Intervalo de hora Incorrecto");
                txtDuracion.Clear();
            }
            
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (pelicula.DuracionPelicula != TimeSpan.Parse("0"))
            {
                if (nPelicula.Modificar(pelicula))
                {
                    MessageBox.Show("Registro modificado con exito");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Intervalo de hora Incorrecto");
                txtDuracion.Clear();
            }
        }

        private void LlenarComboSala()
        {
            cmbSala.DataSource = nSala.MostrarTodos();
            cmbSala.DisplayMember = "Nombre";
            cmbSala.ValueMember = "Clave";
        }

        private void LlenarComboGenero()
        {
            cmbGenero.DataSource = nGenero.MostrarTodos();
            cmbGenero.DisplayMember = "Nombre";
            cmbGenero.ValueMember = "Clave";
        }

       
        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSala_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSala_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbSala.SelectedValue != null)
            {
                int idSala = int.Parse(cmbSala.SelectedValue.ToString());

                foreach (var item in nSala.MostrarByID(idSala))
                {
                    lbClasificacion.Text = item.TipoClasificacion;
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png|Archivos gif (*.gif)|*.gif",
                FilterIndex = 1,
                RestoreDirectory = true,
                             
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            picimagen.Image = Image.FromStream(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del Sistema: " + ex.Message);
                }
            }
        }
    }
}
