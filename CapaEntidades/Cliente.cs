using System;

namespace CapaEntidades
{
    public class Cliente
    {
        public int CveCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApepaternoCliente { get; set; }
        public string ApematernoCliente { get; set; }
        public int EdadCliente { get; set; }
        public int CveestadoCliente { get; set; }
        public int CveusuarioaltaCliente { get; set; }
        public DateTime FechaaltaCliente { get; set; }
        public int? CveusuariomodCliente { get; set; }
        public DateTime? FechamodCliente { get; set; }
    }
}
