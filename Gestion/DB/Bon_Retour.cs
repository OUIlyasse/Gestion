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
    
    public partial class Bon_Retour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Retour()
        {
            this.Bon_Retour_Article = new HashSet<Bon_Retour_Article>();
        }
    
        public int br_ID { get; set; }
        public Nullable<System.DateTime> br_Date { get; set; }
        public string br_Designation { get; set; }
        public string br_Reference { get; set; }
        public string br_PV { get; set; }
        public Nullable<int> unt_ID { get; set; }
        public string br_Description { get; set; }
        public Nullable<bool> br_Historique { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Retour_Article> Bon_Retour_Article { get; set; }
        public virtual Unite_Soutien Unite_Soutien { get; set; }
    }
}
