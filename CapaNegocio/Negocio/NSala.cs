using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Nsala
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

        public List<Sala> MostrarByID(int id)
        {
            using (var modeldb = new CinetmazEntities())
            {
                var query = from s in modeldb.vwMostrarTodosSala
                            where s.Clave == id
                            select new Sala
                            {
                                NombreSala = s.Nombre,
                                CapacidadSala = s.Capacidad,
                                CveclasificacionSala = s.cveclasificacion_sala,
                                TipoClasificacion = s.Clasificacion
                            };
                return query.ToList();
            }
        }

        public List<fnObtenerCapacidadSala_Result> ObtenerCapacidad(int cveSalaPelicula)
        {
            using (var modeldb = new CinetmazEntities())
            {
                var query = from s in modeldb.fnObtenerCapacidadSala(cveSalaPelicula)
                            select s;

                return query.ToList();
            }
        }
    }
}
