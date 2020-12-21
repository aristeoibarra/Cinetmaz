using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int CveUsuario { get; set; }
        public string NombreUsuario  { get; set; }
        public string UserUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public DateTime FechacreacionUsuario { get; set; }
        public int CveestadoUsuario { get; set; }
    }
}
