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
    
    public partial class Fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fournisseur()
        {
            this.Bon_Entree = new HashSet<Bon_Entree>();
            this.Representant = new HashSet<Representant>();
        }
    
        public int frns_ID { get; set; }
        public string frns_Nom { get; set; }
        public string frns_Adresse { get; set; }
        public string frns_Adresse2 { get; set; }
        public string frns_Code_Postal { get; set; }
        public Nullable<int> vil_ID { get; set; }
        public string frns_Email { get; set; }
        public string frns_GSM { get; set; }
        public string frns_GSM2 { get; set; }
        public string frns_Fixe1 { get; set; }
        public string frns_Fixe2 { get; set; }
        public string frns_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Entree> Bon_Entree { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Representant> Representant { get; set; }
    }
}