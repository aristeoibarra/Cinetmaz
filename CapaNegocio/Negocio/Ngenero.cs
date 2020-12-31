using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Ngenero
    {
        public bool Agregar(Genero dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarGenero(dat.NombreGenero);
                return true;
            }
        }

        public bool Modificar(Genero dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarGenero(dat.CveGenero, dat.NombreGenero);
                return true;
            }
        }

        public bool Eliminar(int cveGenero)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarGenero(cveGenero);
                return true;
            }
        }

        public List<vwMostrarTodosGenero> MostrarTodos()
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                return modeldb.vwMostrarTodosGenero.ToList();
            }
        }

        public List<Genero> MostrarByID(int id)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                var query = from g in modeldb.vwMostrarTodosGenero
                            where g.Clave == id
                            select new Genero
                            {
                                NombreGenero = g.Nombre
                            };
                return query.ToList();
            }
        }
    }
}
