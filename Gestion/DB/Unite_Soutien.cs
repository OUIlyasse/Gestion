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
    
    public partial class Unite_Soutien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unite_Soutien()
        {
            this.Bon_Sortie = new HashSet<Bon_Sortie>();
            this.Bon_Retour = new HashSet<Bon_Retour>();
        }
    
        public int unt_ID { get; set; }
        public string unt_Unite { get; set; }
        public string unt_Description { get; set; }
        public Nullable<bool> unt_status { get; set; }
        public Nullable<int> vil_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Sortie> Bon_Sortie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Retour> Bon_Retour { get; set; }
        public virtual Ville Ville { get; set; }
    }
}
