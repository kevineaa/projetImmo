//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcranAccueil
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROPOSITION_VISITE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPOSITION_VISITE()
        {
            this.RDV = new HashSet<RDV>();
        }
    
        public short IDVISITE { get; set; }
        public short IDFICHESOUHAITS { get; set; }
        public short IDBIEN { get; set; }
        public System.DateTime DATERDV { get; set; }
    
        public virtual BIEN BIEN { get; set; }
        public virtual FICHE_DE_SOUHAITS FICHE_DE_SOUHAITS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RDV> RDV { get; set; }
    }
}
