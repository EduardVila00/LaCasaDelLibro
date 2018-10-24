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
    
    public partial class Llibre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Llibre()
        {
            this.Copias = new HashSet<Copia>();
            this.Autors = new HashSet<Autor>();
        }
    
        public int ISBN { get; set; }
        public string Titol { get; set; }
        public int numPagines { get; set; }
        public bool disponible { get; set; }
        public string editorial { get; set; }
        public System.DateTime dataIntroduccio { get; set; }
        public System.DateTime dataDarreraModificacio { get; set; }
        public System.DateTime dataBaixa { get; set; }
        public int LlistaEsperas_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Copia> Copias { get; set; }
        public virtual LlistaEspera LlistaEspera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autors { get; set; }
    }
}