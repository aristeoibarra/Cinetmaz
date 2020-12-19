﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CinetmazEntities : DbContext
    {
        public CinetmazEntities()
            : base("name=CinetmazEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ca_clasificacion> ca_clasificacion { get; set; }
        public virtual DbSet<ca_pelicula> ca_pelicula { get; set; }
        public virtual DbSet<ca_sala> ca_sala { get; set; }
        public virtual DbSet<ma_cinetmaz> ma_cinetmaz { get; set; }
        public virtual DbSet<vwMostrarTodosPelicula> vwMostrarTodosPelicula { get; set; }
        public virtual DbSet<vwMostrarTodosSala> vwMostrarTodosSala { get; set; }
        public virtual DbSet<vwMostrarTodosClasificacion> vwMostrarTodosClasificacion { get; set; }
        public virtual DbSet<ca_cliente> ca_cliente { get; set; }
        public virtual DbSet<ca_estado> ca_estado { get; set; }
        public virtual DbSet<ca_asiento> ca_asiento { get; set; }
    
        public virtual int spAgregarClasificacion(string tipo, Nullable<int> edadMinima, string descripcion)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            var edadMinimaParameter = edadMinima.HasValue ?
                new ObjectParameter("edadMinima", edadMinima) :
                new ObjectParameter("edadMinima", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarClasificacion", tipoParameter, edadMinimaParameter, descripcionParameter);
        }
    
        public virtual int spEliminarClasificacion(Nullable<int> cveClasificacion)
        {
            var cveClasificacionParameter = cveClasificacion.HasValue ?
                new ObjectParameter("cveClasificacion", cveClasificacion) :
                new ObjectParameter("cveClasificacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarClasificacion", cveClasificacionParameter);
        }
    
        public virtual int spModificarClasificacion(Nullable<int> cveClasificacion, string tipo, Nullable<int> edadMinima, string descripcion)
        {
            var cveClasificacionParameter = cveClasificacion.HasValue ?
                new ObjectParameter("cveClasificacion", cveClasificacion) :
                new ObjectParameter("cveClasificacion", typeof(int));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            var edadMinimaParameter = edadMinima.HasValue ?
                new ObjectParameter("edadMinima", edadMinima) :
                new ObjectParameter("edadMinima", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificarClasificacion", cveClasificacionParameter, tipoParameter, edadMinimaParameter, descripcionParameter);
        }
    
        public virtual int spAgregarSala(string nombre, Nullable<int> capacidad, Nullable<int> cveClasificacion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var capacidadParameter = capacidad.HasValue ?
                new ObjectParameter("capacidad", capacidad) :
                new ObjectParameter("capacidad", typeof(int));
    
            var cveClasificacionParameter = cveClasificacion.HasValue ?
                new ObjectParameter("cveClasificacion", cveClasificacion) :
                new ObjectParameter("cveClasificacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarSala", nombreParameter, capacidadParameter, cveClasificacionParameter);
        }
    
        public virtual int spEliminarSala(Nullable<int> cveSala)
        {
            var cveSalaParameter = cveSala.HasValue ?
                new ObjectParameter("cveSala", cveSala) :
                new ObjectParameter("cveSala", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarSala", cveSalaParameter);
        }
    
        public virtual int spModificarSala(Nullable<int> cveSala, string nombre, Nullable<int> capacidad, Nullable<int> cveClasificacion)
        {
            var cveSalaParameter = cveSala.HasValue ?
                new ObjectParameter("cveSala", cveSala) :
                new ObjectParameter("cveSala", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var capacidadParameter = capacidad.HasValue ?
                new ObjectParameter("capacidad", capacidad) :
                new ObjectParameter("capacidad", typeof(int));
    
            var cveClasificacionParameter = cveClasificacion.HasValue ?
                new ObjectParameter("cveClasificacion", cveClasificacion) :
                new ObjectParameter("cveClasificacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificarSala", cveSalaParameter, nombreParameter, capacidadParameter, cveClasificacionParameter);
        }
    
        public virtual int spAgregarPelicula(string nombre, Nullable<int> cveSala)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var cveSalaParameter = cveSala.HasValue ?
                new ObjectParameter("cveSala", cveSala) :
                new ObjectParameter("cveSala", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarPelicula", nombreParameter, cveSalaParameter);
        }
    
        public virtual int spEliminarPelicula(Nullable<int> cvePelicula)
        {
            var cvePeliculaParameter = cvePelicula.HasValue ?
                new ObjectParameter("cvePelicula", cvePelicula) :
                new ObjectParameter("cvePelicula", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarPelicula", cvePeliculaParameter);
        }
    
        public virtual int spModificarPelicula(Nullable<int> cvePelicula, string nombre, Nullable<int> cveSala)
        {
            var cvePeliculaParameter = cvePelicula.HasValue ?
                new ObjectParameter("cvePelicula", cvePelicula) :
                new ObjectParameter("cvePelicula", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var cveSalaParameter = cveSala.HasValue ?
                new ObjectParameter("cveSala", cveSala) :
                new ObjectParameter("cveSala", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spModificarPelicula", cvePeliculaParameter, nombreParameter, cveSalaParameter);
        }
    }
}
