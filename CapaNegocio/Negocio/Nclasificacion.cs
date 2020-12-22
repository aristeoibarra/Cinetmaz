using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Nclasificacion
    {
        public bool Agregar(Clasificacion dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarClasificacion(dat.TipoClasificacion,
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
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                return modeldb.vwMostrarTodosClasificacion.ToList();
            }
        }

        public List<Clasificacion> MostrarByID(int id)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                var query = from c in modeldb.vwMostrarTodosClasificacion
                            where c.Clave == id
                            select new Clasificacion
                            {
                                TipoClasificacion = c.Tipo,
                                EdadMinima = c.Edad_Minima,
                                DescripcionClasificacion = c.Descripcion
                            };
                return query.ToList();
            }
        }

        #region Prueba DataTable
        /*
        public DataTable LlenarByID(int id)
        {          
            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo");
            dt.Columns.Add("EdadMinima");
            dt.Columns.Add("Descripcion");

            foreach (var item in ListaByID(id))
            {
                DataRow row = dt.NewRow();
                row["Tipo"] = item.TipoClasificacion;
                row["EdadMinima"] = item.EdadMinimaClasificacion;
                row["Descripcion"] = item.DescripcionClasificacion;
                dt.Rows.Add(row);
            }
            return dt;
        }  */
        #endregion
    }
}
