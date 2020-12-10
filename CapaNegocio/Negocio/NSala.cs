using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato.Model;

namespace CapaNegocio.Negocio
{
    public class NSala
    {
        public bool Agregar(Sala dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarSala(dat.NombreSala,
                                      dat.CapacidadSala,
                                      dat.CveclasificacionSala);
                return true;
            }
        }

        public bool Modificar(Sala dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarSala(dat.CveSala,
                                        dat.NombreSala,
                                        dat.CapacidadSala,
                                        dat.CveclasificacionSala);
                return true;
            }
        }

        public bool Eliminar(int cveSala)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarSala(cveSala);
                return true;
            }
        }

        public List<vwMostrarTodosSala> MostrarTodos()
        {
            using (var modeldb = new CinetmazEntities())
            {
                return modeldb.vwMostrarTodosSala.ToList();
            }
        }
    }
}
