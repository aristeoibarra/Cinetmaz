﻿using CapaDato.Model;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio.Negocio
{
    public class Nusuario
    {
        public bool Agregar(Usuario dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spAgregarUsuario(dat.NombreUsuario
                                        , dat.UserUsuario
                                        , dat.PasswordUsuario);
                return true;
            }
        }

        public bool Modificar(Usuario dat)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spModificarUsuario(dat.CveUsuario
                                          , dat.NombreUsuario
                                          , dat.UserUsuario
                                          , dat.PasswordUsuario);
                return true;
            }
        }

        public bool Eliminar(int cveUsuario)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.spEliminarUsuario(cveUsuario);
                return true;
            }
        }

        public bool CambiarEstado(int cveUsuario, int cveEstado)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                modeldb.SpCambiarEstadoUsuario(cveUsuario, cveEstado);
                return true;
            }
        }

        public List<fnMostrarTodosUsuarioByEstatus_Result> MostrarTodosByEstatus(int cveEstado)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                // 1) Activo 2) Inactivo 3) Eliminado
                return modeldb.fnMostrarTodosUsuarioByEstatus(cveEstado).ToList();
            }
        }

        public List<Usuario> MostrarByID(int id)
        {
            using (CinetmazEntities modeldb = new CinetmazEntities())
            {
                var query = from u in modeldb.fnMostrarTodosUsuarioByEstatus(1)
                            where u.Clave == id
                            select new Usuario
                            {
                                NombreUsuario = u.Nombre,
                                UserUsuario = u.Usuario
                            };
                return query.ToList();
            }
        }
    }
}
