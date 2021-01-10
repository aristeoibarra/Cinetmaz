using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Ncliente
    {
        public bool Agregar(Cliente dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarCliente(dat.NombreCliente,
                                         dat.ApepaternoCliente,
                                         dat.ApematernoCliente,
                                         dat.EdadCliente,
                                         dat.CveusuarioaltaCliente);
                return true;
            }
        }

        public bool Modificar(Cliente dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarCliente(dat.CveCliente,
                                           dat.NombreCliente,
                                           dat.ApepaternoCliente,
                                           dat.ApematernoCliente,
                                           dat.EdadCliente,
                                           dat.CveusuariomodCliente);
                return true;
            }
        }

        public bool Eliminar(int cveCliente)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarCliente(cveCliente);
                return true;
            }
        }

        public bool CambiarEstatus(int cveCliente, int cveEstado)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spCambiarEstadoCliente(cveCliente, cveEstado);
                return true;
            }
        }

        public List<fnMostrarTodosClienteByEstatus_Result> MostrarTodosByEstatus(int cveEstado)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                // 1) Activo 2) Inactivo 3) Eliminado
                return modeldb.fnMostrarTodosClienteByEstatus(cveEstado).OrderByDescending(x=>x.Clave).ToList();
            }
        }

        public List<Cliente> MostrarByID(int id)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                var query = from c in modeldb.fnMostrarTodosClienteByEstatus(1)
                            where c.Clave == id
                            select new Cliente
                            {
                                NombreCliente = c.Nombre,
                                ApepaternoCliente = c.ApPaterno,
                                ApematernoCliente = c.ApMaterno,
                                EdadCliente = c.Edad
                            };
                return query.ToList();
            }
        }
    }
}
