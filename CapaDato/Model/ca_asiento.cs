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
    
    public partial class ca_asiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_asiento()
        {
            this.ma_cinetmaz = new HashSet<ma_cinetmaz>();
        }
    
        public int cve_asiento { get; set; }
        public int numero_asiento { get; set; }
        public int cveestado_asiento { get; set; }
        public int cvesala_asiento { get; set; }
    
        public virtual ca_estado ca_estado { get; set; }
        public virtual ca_sala ca_sala { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_cinetmaz> ma_cinetmaz { get; set; }
    }
}
