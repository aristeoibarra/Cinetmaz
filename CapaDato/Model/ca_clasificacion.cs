//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ca_clasificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_clasificacion()
        {
            this.ca_sala = new HashSet<ca_sala>();
        }
    
        public int cve_clasificacion { get; set; }
        public string tipo_clasificacion { get; set; }
        public int edadminima_clasificacion { get; set; }
        public string descripcion_clasificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_sala> ca_sala { get; set; }
    }
}
