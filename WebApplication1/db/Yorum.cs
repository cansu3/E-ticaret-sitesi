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
    
    public partial class Yorum
    {
        public int id { get; set; }
        public int ürün_id { get; set; }
        public int üye_id { get; set; }
        public string metin { get; set; }
        public System.DateTime ekleme_tarihi { get; set; }
        public Nullable<System.DateTime> güncelleme_tarihi { get; set; }
    
        public virtual Ürün Ürün { get; set; }
        public virtual Üye Üye { get; set; }
    }
}
