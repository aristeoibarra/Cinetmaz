using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Npelicula
    {
        public bool Agregar(Pelicula dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarPelicula(dat.NombrePelicula, dat.CvesalaPelicula);
                return true;
            }
        }

        public bool Modificar(Pelicula dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarPelicula(dat.CvePelicula, dat.NombrePelicula, dat.CvesalaPelicula);
                return true;
            }
        }

        public bool Eliminar(int cvePelicula)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarPelicula(cvePelicula);
                return true;
            }
        }

        public List<vwMostrarTodosPelicula> MostrarTodos()
        {
            using (var modeldb = new CinetmazEntities())
            {
                return modeldb.vwMostrarTodosPelicula.ToList();
            }
        }

        public List<Pelicula> MostrarByID(int id)
        {
            using (var modeldb = new CinetmazEntities())
            {
                var query = from p in modeldb.vwMostrarTodosPelicula
                            where p.Clave == id
                            select new Pelicula
                            {
                                NombrePelicula = p.Nombre,
                                CvesalaPelicula = p.cvesala_pelicula
                            };
                return query.ToList();
            }
        }
    }
}
