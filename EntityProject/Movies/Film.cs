//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        public int FilmID { get; set; }
        public string Titel { get; set; }
        public Nullable<System.TimeSpan> Längd { get; set; }
        public Nullable<System.DateTime> UtgivningsÅr { get; set; }
        public string Omdöme { get; set; }
        public int KategoriID { get; set; }
    
        public virtual Kategori Kategori { get; set; }
    }
}
