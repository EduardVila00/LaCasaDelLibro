//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test
{
    using System;
    using System.Collections.Generic;
    
    public partial class Copia
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public System.DateTime dataIntroduccio { get; set; }
        public System.DateTime dataDarreraModificacio { get; set; }
        public System.DateTime dataBaixa { get; set; }
    
        public virtual Llibre Llibre { get; set; }
        public virtual Sancio Sancio { get; set; }
    }
}
