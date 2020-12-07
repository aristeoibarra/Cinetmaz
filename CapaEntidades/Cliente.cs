using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Cliente
    {
        public int CveCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApepaternoCliente { get; set; }
        public string ApematernoCliente { get; set; }
        public int EdadCliente { get; set; }
        public int EstatusCliente { get; set; }
        public int CveusuarioaltaCliente { get; set; }
        public DateTime FechaaltaCliente { get; set; }
        public int? CveusuariomodCliente { get; set; }
        public DateTime? FechamodCliente { get; set; }
    }
}
