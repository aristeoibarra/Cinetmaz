﻿using CapaEntidades;
using CapaNegocio.Negocio;
using System;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;


namespace CapaPresentacion.Clasificaciones
{
    public partial class frmClasificacion : Form
    {
        readonly Nclasificacion nclasificacion = new Nclasificacion();
        readonly Clasificacion clasificacion = new Clasificacion();

        public int idClasificacion = 0;

        public frmClasificacion()
        {
            InitializeComponent();
        }

        private void frmClasificacion_Load(object sender, EventArgs e)
        {
            txtTipo.Focus();

            if (idClasificacion > 0)
            {
                CargaDatos();
            }
        }

        private void CargaDatos()
        {
            foreach (var item in nclasificacion.MostrarByID(idClasificacion))
            {
                txtTipo.Text = item.TipoClasificacion;
                txtEdad.Text = item.EdadMinima;
                txtDescripcion.Text = item.DescripcionClasificacion;
            }

            if (txtEdad.Text == "0")
            {
                chkPublicoGeneral.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (OperacionesFormulario.ValidarTextBox(this))
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                if (idClasificacion <= 0) 
                    Agregar();
                else
                    Modificar();
            }      
        }

        private void ObtenerDatos()
        {
            clasificacion.CveClasificacion = idClasificacion;
            clasificacion.TipoClasificacion = txtTipo.Text.Trim();
            clasificacion.DescripcionClasificacion = txtDescripcion.Text.Trim();
            clasificacion.EdadMinimaClasificacion = Convert.ToInt32(txtEdad.Text.Trim());
        }

        private void Agregar()
        {
            ObtenerDatos();

            if (nclasificacion.Agregar(clasificacion))
            {
                MessageBox.Show("Registro agregado con exito");
                this.Close();
            }
        }

        private void Modificar()
        {
            ObtenerDatos();

            if (nclasificacion.Modificar(clasificacion))
            {
                MessageBox.Show("Registro modificado con exito");
                this.Close();
            }
        }

        private void chkPublicoGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPublicoGeneral.Checked)
            {
                txtEdad.Enabled = false;
                txtEdad.Text = "0";
            }
            else
            {
                txtEdad.Enabled = true;
            }
        }
        
        #region Validaciones TextBoxs

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            OperacionesFormulario.SoloNumeros(sender, e);
        } 
        #endregion
    }
}
