using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI__Eduardo_Vera_20240906.Models
{
    public partial class Prueba06092024Context : DbContext
    {
        public Prueba06092024Context()
        {
        }

        public Prueba06092024Context(DbContextOptions<Prueba06092024Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Pago> Pagos { get; set; } = null!;
        public virtual DbSet<Prestamo> Prestamos { get; set; } = null!;
        public virtual DbSet<SolicitudPrestamo> SolicitudPrestamos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=escritorio\\localhost; database=Prueba06092024; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pago>(entity =>
            {
                entity.ToTable("Pago");

                entity.Property(e => e.PagoId).HasColumnName("PagoID");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.MetodoPago).HasMaxLength(50);

                entity.Property(e => e.MontoPagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrestamoId).HasColumnName("PrestamoID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Prestamo)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.PrestamoId)
                    .HasConstraintName("FK_Pago_Prestamo");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Pago_Usuario");
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.ToTable("Prestamo");

                entity.Property(e => e.PrestamoId).HasColumnName("PrestamoID");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FechaAprobacion).HasColumnType("date");

                entity.Property(e => e.MontoPrestado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.TasaInteres).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Solicitud)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.SolicitudId)
                    .HasConstraintName("FK_Prestamo_Solicitud");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Prestamo_Usuario");
            });

            modelBuilder.Entity<SolicitudPrestamo>(entity =>
            {
                entity.HasKey(e => e.SolicitudId)
                    .HasName("PK__Solicitu__85E95DA74BAC835F");

                entity.ToTable("SolicitudPrestamo");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FechaSolicitud).HasColumnType("date");

                entity.Property(e => e.MontoSolicitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.SolicitudPrestamos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Solicitud_Usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Correo, "UQ__Usuario__60695A192500287C")
                    .IsUnique();

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.Correo).HasMaxLength(100);

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.Tipo).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
