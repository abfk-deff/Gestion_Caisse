//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCaisse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Approvisionnement
    {
        public int idApprovisionnement { get; set; }
        public string source { get; set; }
        public Nullable<int> montantApprovisionne { get; set; }
        public Nullable<int> idCaisse { get; set; }
        public Nullable<int> idEmploye { get; set; }
        public Nullable<System.DateTime> dateApprovisionnement { get; set; }
    
        public virtual Caisse Caisse { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
