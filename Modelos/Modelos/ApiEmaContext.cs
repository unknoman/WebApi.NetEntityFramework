using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApplication1.Modelos;

public partial class ApiEmaContext : DbContext
{
    public ApiEmaContext()
    {
    }

    public ApiEmaContext(DbContextOptions<ApiEmaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tipouser> Tipousers { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  => optionsBuilder.UseSqlServer("Server=localhost;Database=ApiEma;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tipouser>(entity =>
        {
            entity.HasKey(e => e.Idtipo).HasName("PK__TIPOUSER__E57FEC10F972C3DE");

            entity.ToTable("TIPOUSER");

            entity.HasIndex(e => e.Idtipo, "TIPOUSER_PK").IsUnique();

            entity.Property(e => e.Idtipo).HasColumnName("IDTIPO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PK__USUARIO__98242AA93D1F14CB");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Idtipo, "RELATION_14_FK");

            entity.HasIndex(e => e.Idusuario, "USUARIO_PK").IsUnique();

            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.Idtipo).HasColumnName("IDTIPO");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("USUARIO");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
