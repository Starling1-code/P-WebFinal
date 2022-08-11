using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace P_WebFinal.Models
{
    public partial class CineVirtualContext : DbContext
    {
        public CineVirtualContext()
        {
        }

        public CineVirtualContext(DbContextOptions<CineVirtualContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pelicula> Peliculas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=DESKTOP-5DH6KOH; database=CineVirtual; integrated security=true;");
         }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PK__Pelicula__B770B53EECA1A98C");

                entity.Property(e => e.IdP).HasColumnName("Id_P");

                entity.Property(e => e.Año)
                    .HasColumnType("datetime")
                    .HasColumnName("Año_P");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_P");

                entity.Property(e => e.Director)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Director_P");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Genero_P");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Titulo_P");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
