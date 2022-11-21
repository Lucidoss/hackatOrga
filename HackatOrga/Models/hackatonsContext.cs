using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HackatOrga.Models
{
    public partial class hackatonsContext : DbContext
    {
        public hackatonsContext()
        {
        }

        public hackatonsContext(DbContextOptions<hackatonsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Atelier> Ateliers { get; set; } = null!;
        public virtual DbSet<Conference> Conferences { get; set; } = null!;
        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
        public virtual DbSet<Hackathon> Hackathons { get; set; } = null!;
        public virtual DbSet<Inscription> Inscriptions { get; set; } = null!;
        public virtual DbSet<Intervenant> Intervenants { get; set; } = null!;
        public virtual DbSet<Intervenir> Intervenirs { get; set; } = null!;
        public virtual DbSet<Participant> Participants { get; set; } = null!;
        public virtual DbSet<Participantatelier> Participantateliers { get; set; } = null!;
        public virtual DbSet<Participer> Participers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3307;user=root;database=hackatons;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.5-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Atelier>(entity =>
            {
                entity.HasKey(e => e.Idevenement)
                    .HasName("PRIMARY");

                entity.ToTable("atelier");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Idevenement)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("IDEVENEMENT");

                entity.Property(e => e.Datedebut).HasColumnName("DATEDEBUT");

                entity.Property(e => e.Datefin).HasColumnName("DATEFIN");

                entity.Property(e => e.Duree)
                    .HasColumnType("time")
                    .HasColumnName("DUREE");

                entity.Property(e => e.Nbparticipants)
                    .HasColumnType("int(11)")
                    .HasColumnName("NBPARTICIPANTS");

                entity.Property(e => e.Nomevenement)
                    .HasMaxLength(64)
                    .HasColumnName("NOMEVENEMENT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Conference>(entity =>
            {
                entity.HasKey(e => e.Idevenement)
                    .HasName("PRIMARY");

                entity.ToTable("conference");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Idevenement)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("IDEVENEMENT");

                entity.Property(e => e.Datedebut).HasColumnName("DATEDEBUT");

                entity.Property(e => e.Datefin).HasColumnName("DATEFIN");

                entity.Property(e => e.Duree)
                    .HasColumnType("time")
                    .HasColumnName("DUREE");

                entity.Property(e => e.Nomevenement)
                    .HasMaxLength(64)
                    .HasColumnName("NOMEVENEMENT")
                    .IsFixedLength();

                entity.Property(e => e.Theme)
                    .HasMaxLength(128)
                    .HasColumnName("THEME");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.Idevenement)
                    .HasName("PRIMARY");

                entity.ToTable("evenement");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Idhackathon, "FK_EVENEMENT_HACKATHON");

                entity.Property(e => e.Idevenement)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDEVENEMENT");

                entity.Property(e => e.Datedebut).HasColumnName("DATEDEBUT");

                entity.Property(e => e.Datefin).HasColumnName("DATEFIN");

                entity.Property(e => e.Duree)
                    .HasColumnType("time")
                    .HasColumnName("DUREE");

                entity.Property(e => e.Idhackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDHACKATHON");

                entity.Property(e => e.Nomevenement)
                    .HasMaxLength(64)
                    .HasColumnName("NOMEVENEMENT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.HasKey(e => e.Idhackathon)
                    .HasName("PRIMARY");

                entity.ToTable("hackathon");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Idhackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDHACKATHON");

                entity.Property(e => e.Cp)
                    .HasMaxLength(5)
                    .HasColumnName("CP")
                    .IsFixedLength();

                entity.Property(e => e.Datedebut).HasColumnName("DATEDEBUT");

                entity.Property(e => e.Datefin).HasColumnName("DATEFIN");

                entity.Property(e => e.Datelimite).HasColumnName("DATELIMITE");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION")
                    .IsFixedLength();

                entity.Property(e => e.Heuredebut)
                    .HasColumnType("time")
                    .HasColumnName("HEUREDEBUT");

                entity.Property(e => e.Heurefin)
                    .HasColumnType("time")
                    .HasColumnName("HEUREFIN");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("IMAGE")
                    .IsFixedLength();

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("LIEU")
                    .IsFixedLength();

                entity.Property(e => e.Nbplaces)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("NBPLACES");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("RUE")
                    .IsFixedLength();

                entity.Property(e => e.Theme)
                    .HasMaxLength(255)
                    .HasColumnName("THEME")
                    .IsFixedLength();

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("VILLE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PRIMARY");

                entity.ToTable("inscription");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Idhackathon, "FK_INSCRIPTION_HACKATHON");

                entity.HasIndex(e => e.Idparticipant, "FK_INSCRIPTION_PARTICIPANT");

                entity.Property(e => e.Code)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("CODE");

                entity.Property(e => e.Dateinscription).HasColumnName("DATEINSCRIPTION");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION")
                    .IsFixedLength();

                entity.Property(e => e.Idhackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDHACKATHON");

                entity.Property(e => e.Idparticipant)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDPARTICIPANT");
            });

            modelBuilder.Entity<Intervenant>(entity =>
            {
                entity.HasKey(e => e.Idintervenant)
                    .HasName("PRIMARY");

                entity.ToTable("intervenant");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Idintervenant)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDINTERVENANT");

                entity.Property(e => e.Nom)
                    .HasMaxLength(32)
                    .HasColumnName("NOM")
                    .IsFixedLength();

                entity.Property(e => e.Prenom)
                    .HasMaxLength(32)
                    .HasColumnName("PRENOM")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Intervenir>(entity =>
            {
                entity.HasKey(e => new { e.Idintervenant, e.Idevenement })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("intervenir");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Idevenement, "FK_INTERVENIR_CONFERENCE");

                entity.Property(e => e.Idintervenant)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDINTERVENANT");

                entity.Property(e => e.Idevenement)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDEVENEMENT");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.Idparticipant)
                    .HasName("PRIMARY");

                entity.ToTable("participant");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Idparticipant)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDPARTICIPANT");

                entity.Property(e => e.Cp)
                    .HasMaxLength(5)
                    .HasColumnName("CP")
                    .IsFixedLength();

                entity.Property(e => e.Datenaissance).HasColumnName("DATENAISSANCE");

                entity.Property(e => e.Email)
                    .HasMaxLength(32)
                    .HasColumnName("EMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(32)
                    .HasColumnName("LOGIN")
                    .IsFixedLength();

                entity.Property(e => e.Mdp)
                    .HasMaxLength(32)
                    .HasColumnName("MDP")
                    .IsFixedLength();

                entity.Property(e => e.Nom)
                    .HasMaxLength(32)
                    .HasColumnName("NOM")
                    .IsFixedLength();

                entity.Property(e => e.Prenom)
                    .HasMaxLength(32)
                    .HasColumnName("PRENOM")
                    .IsFixedLength();

                entity.Property(e => e.Rue)
                    .HasMaxLength(128)
                    .HasColumnName("RUE");

                entity.Property(e => e.Ville)
                    .HasMaxLength(64)
                    .HasColumnName("VILLE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Participantatelier>(entity =>
            {
                entity.HasKey(e => e.Idparticipantatelier)
                    .HasName("PRIMARY");

                entity.ToTable("participantatelier");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Idparticipantatelier)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDPARTICIPANTATELIER");

                entity.Property(e => e.Email)
                    .HasMaxLength(32)
                    .HasColumnName("EMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Nom)
                    .HasMaxLength(32)
                    .HasColumnName("NOM")
                    .IsFixedLength();

                entity.Property(e => e.Prenom)
                    .HasMaxLength(32)
                    .HasColumnName("PRENOM")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Participer>(entity =>
            {
                entity.HasKey(e => new { e.Idparticipantatelier, e.Idevenement })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("participer");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Idevenement, "FK_PARTICIPER_ATELIER");

                entity.Property(e => e.Idparticipantatelier)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDPARTICIPANTATELIER");

                entity.Property(e => e.Idevenement)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDEVENEMENT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
