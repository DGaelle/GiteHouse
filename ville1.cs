//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiteHouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class ville1
    {
        public int id { get; set; }
        public string departement_id { get; set; }
        public string nom { get; set; }
        public string codepostal { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
    
        public virtual departement departement { get; set; }
    }
}
