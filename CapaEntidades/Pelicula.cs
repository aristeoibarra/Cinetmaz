﻿using System;

namespace CapaEntidades
{
    public class Pelicula
    {
        public int CvePelicula { get; set; }
        public string NombrePelicula { get; set; }
        public Nullable<System.TimeSpan> DuracionPelicula { get; set; }
        public int CvesalaPelicula { get; set; }
        public byte[] PortadaPelicula { get; set; }
        public int CvegeneroPelicula { get; set; }


        public string NombreGenero { get; set; }
        public string NombreSala { get; set; }
        public string TipoClasificacion { get; set; }
    }
}
