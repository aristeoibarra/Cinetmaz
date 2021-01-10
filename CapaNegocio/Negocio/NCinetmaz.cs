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

        public bool Eliminar(int cveCinetmaz)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarReservaCinetmaz(cveCinetmaz);
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

        public List<fnMostrarReservasBySala_Result> MostrarReservasBySala(int cveSala)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                return modeldb.fnMostrarReservasBySala(cveSala).OrderBy(x => x.Asiento).ToList();
            }
        }

        public int ObtenerUtlimaClaveCinetmaz(Cinetmaz dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                int query = (from m in modeldb.ma_cinetmaz
                                  where m.cvecliente_cinetmaz == dat.CveclienteCinetmaz && m.cvepelicula_cinetmaz == dat.CvepeliculaCinetmaz
                             select m.cve_cinetmaz).OrderByDescending(x => x).First();

                return query;
            }
        }

        public List<fnMostrarReservaByCveCinetmaz_Result> MostrarReservasByCveCinetmaz(int cveCinetmaz)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                return modeldb.fnMostrarReservaByCveCinetmaz(cveCinetmaz).ToList();
            }
        }

    }
}
