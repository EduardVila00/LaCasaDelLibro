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
    
    public partial class Autor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autor()
        {
            this.Llibres = new HashSet<Llibre>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public System.DateTime dataIntroduccio { get; set; }
        public System.DateTime dataDarreraModificacio { get; set; }
        public System.DateTime dataBaixa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Llibre> Llibres { get; set; }
    }
}
