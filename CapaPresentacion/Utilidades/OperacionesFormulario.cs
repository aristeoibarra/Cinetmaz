using System;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    class OperacionesFormulario
    {
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
            string valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();
            return valor;
        }

        public static bool ValidarTextBox(Form formulario)
        {
            bool vacio = false;

            foreach (Control oControls in formulario.Controls)
            {
                if (oControls is TextBox & oControls.Text == string.Empty
                    || oControls is ComboBox & oControls.Text == string.Empty) // Verificamos que no este vacio.
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

        public static void CentraX(Control padre, Control hijo)
        {
            int x = padre.Width / 2 - hijo.Width / 2;
            hijo.Location = new System.Drawing.Point(x, hijo.Location.Y);
        }

        public static byte[] ConviertePicBoxImageToByte(PictureBox pbImage)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.Drawing.Bitmap bmap = new System.Drawing.Bitmap(pbImage.Image);//liena agregad apa evitar el pedo de exepcion de gdi
            bmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
