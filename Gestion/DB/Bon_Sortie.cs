//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bon_Sortie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Sortie()
        {
            this.Bon_Sortie_Article = new HashSet<Bon_Sortie_Article>();
        }
    
        public int bs_ID { get; set; }
        public Nullable<System.DateTime> bs_Date { get; set; }
        public string bs_Designation { get; set; }
        public string bs_Reference { get; set; }
        public Nullable<int> unt_ID { get; set; }
        public string bs_Description { get; set; }
        public Nullable<bool> bs_Historique { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Sortie_Article> Bon_Sortie_Article { get; set; }
        public virtual Unite_Soutien Unite_Soutien { get; set; }
    }
}