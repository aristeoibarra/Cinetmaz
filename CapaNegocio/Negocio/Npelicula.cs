using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato.Model;

namespace CapaNegocio.Negocio
{
    public class Npelicula
    {
        public bool Agregar(Pelicula dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarPelicula(dat.NombrePelicula,dat.CvesalaPelicula);
                return true;
            }
        }

        public bool Modificar(Pelicula dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarPelicula(dat.CvePelicula,dat.NombrePelicula, dat.CvesalaPelicula);
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
    }
}
