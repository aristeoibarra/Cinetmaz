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
    
    public partial class ca_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_cliente()
        {
            this.ma_cinetmaz = new HashSet<ma_cinetmaz>();
        }
    
        public int cve_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string apepaterno_cliente { get; set; }
        public string apematerno_cliente { get; set; }
        public int edad_cliente { get; set; }
        public int cveestado_cliente { get; set; }
        public int cveusuarioalta_cliente { get; set; }
        public System.DateTime fechaalta_cliente { get; set; }
        public Nullable<int> cveusuariomod_cliente { get; set; }
        public Nullable<System.DateTime> fechamod_cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_cinetmaz> ma_cinetmaz { get; set; }
        public virtual ca_estado ca_estado { get; set; }
    }
}
