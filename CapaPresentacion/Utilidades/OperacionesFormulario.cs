using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
