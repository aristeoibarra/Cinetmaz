using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Ncinetmaz
    {
        public bool Agregar(Cinetmaz dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarReservacion(dat.CveclienteCinetmaz,
                                             dat.CvepeliculaCinetmaz,
                                             dat.CveasientoCinetmaz);
                return true;
            }
        }

        public List<fnMostrarReservasByPelicula_Result> MostrarReservasByPelicula(int cvePelicula)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                return modeldb.fnMostrarReservasByPelicula(cvePelicula).OrderBy(x=>x.Asiento).ToList();
            }
        }
    }
}
