//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Copia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Copia()
        {
            this.Prestec = new HashSet<Prestec>();
        }
    
        public int Id { get; set; }
        public bool disponible { get; set; }
        public System.DateTime dataIntroduccio { get; set; }
        public System.DateTime dataDarreraModificacio { get; set; }
        public Nullable<System.DateTime> dataBaixa { get; set; }
        public string LlibreIsbn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prestec> Prestec { get; set; }
        public virtual Llibre Llibre { get; set; }
    }
}
