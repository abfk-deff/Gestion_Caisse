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
    
    public partial class Decaissement
    {
        public int idDecaissement { get; set; }
        public Nullable<int> idEmploye { get; set; }
        public Nullable<int> idCaisse { get; set; }
        public Nullable<int> idDemandeDecaissement { get; set; }
        public string dateDecaissement { get; set; }
    
        public virtual Caisse Caisse { get; set; }
        public virtual Employe Employe { get; set; }
        public virtual DemandeDecaissement DemandeDecaissement { get; set; }
    }
}
