using System;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    /// <summary>
    /// Funciones y eventos comunes del formulario
    /// </summary>
    class OperacionesFormulario
    {

        /// <summary>
        /// Obtiene el id de un gridview que contenga en la primer celda el id de registro
        /// </summary>
        /// <param name="dgv">gridview para obtener el id</param>
        /// <returns>Regresa el entero del id</returns>
        public static int ObtenertId(DataGridView dgv)
        {
            try
            {
                int id = 0;

                id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());

                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static string ObtenerValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        public static bool ValidarTextBox(Form formulario)
        {
            bool vacio = false;

            foreach (Control oControls in formulario.Controls)
            {
                if (oControls is TextBox & oControls.Text == String.Empty ||
                    oControls is ComboBox & oControls.Text == String.Empty ||
                    oControls is NumericUpDown & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            return vacio;
        }
        
        public static void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            { e.Handled = true; return; }
        }

        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            { e.Handled = true; return; }
        }

    }
}
