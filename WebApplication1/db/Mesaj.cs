//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesaj()
        {
            this.Mesaj1 = new HashSet<Mesaj>();
        }
    
        public int id { get; set; }
        public string konu { get; set; }
        public string metin { get; set; }
        public bool okundu { get; set; }
        public System.DateTime gönderme_tarihi { get; set; }
        public Nullable<int> gönderen_id { get; set; }
        public Nullable<int> alıcı_id { get; set; }
        public Nullable<int> parent_mesaj_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesaj> Mesaj1 { get; set; }
        public virtual Mesaj Mesaj2 { get; set; }
        public virtual Üye Üye { get; set; }
        public virtual Üye Üye1 { get; set; }
    }
}
