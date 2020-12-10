using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato.Model;

namespace CapaNegocio.Negocio
{
    public class Nclasificacion
    {
        public bool Agregar(Clasificacion dat)
        {
            using(CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarClasificacion(  dat.TipoClasificacion,
                                                 dat.EdadMinimaClasificacion,
                                                 dat.DescripcionClasificacion);
                return true;
            }
        }

        public bool Modificar(Clasificacion dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarClasificacion(dat.CveClasificacion,
                                                 dat.TipoClasificacion,
                                                 dat.EdadMinimaClasificacion,
                                                 dat.DescripcionClasificacion);
                return true;
            }
        }

        public bool Eliminar(int cveClasificacion)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarClasificacion(cveClasificacion);
                return true;
            }
        }

        public List<vwMostrarTodosClasificacion> MostrarTodos()
        {
            using (var modeldb = new CinetmazEntities())
            {
                return modeldb.vwMostrarTodosClasificacion.ToList();
            }
        }

    }
}
