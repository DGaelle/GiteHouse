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
    
    public partial class Message
    {
        public int IdMessage { get; set; }
        public int IdConversation { get; set; }
        public int IdExpediteur { get; set; }
        public int IdDestinataire { get; set; }
        public string Texte { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsLu { get; set; }
    
        public virtual Conversation Conversation { get; set; }
    }
}
