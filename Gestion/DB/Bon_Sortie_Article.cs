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
    
    public partial class Bon_Sortie_Article
    {
        public int bs_A_ID { get; set; }
        public Nullable<System.DateTime> bs_A_Date { get; set; }
        public Nullable<int> bs_Qte_Livree { get; set; }
        public Nullable<int> bs_ID { get; set; }
        public Nullable<int> pne_ID { get; set; }
        public string bs_A_Description { get; set; }
        public Nullable<bool> bs_A_Historique { get; set; }
    
        public virtual Bon_Sortie Bon_Sortie { get; set; }
        public virtual Pneu Pneu { get; set; }
    }
}