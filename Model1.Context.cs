﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GiteHouseEntities1 : DbContext
    {
        public GiteHouseEntities1()
            : base("name=GiteHouseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activite> Activites { get; set; }
        public virtual DbSet<Administrateur> Administrateurs { get; set; }
        public virtual DbSet<Adresse> Adresses { get; set; }
        public virtual DbSet<AppointmentDiary> AppointmentDiaries { get; set; }
        public virtual DbSet<Avi> Avis { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<Equipement> Equipements { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Hebergement> Hebergements { get; set; }
        public virtual DbSet<Hote> Hotes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Messagerie> Messageries { get; set; }
        public virtual DbSet<MoyenPaiement> MoyenPaiements { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Prestation> Prestations { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Saison> Saisons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tarification> Tarifications { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<TypeHebergement> TypeHebergements { get; set; }
        public virtual DbSet<TypeSejour> TypeSejours { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }
    }
}
