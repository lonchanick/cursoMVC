using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_dotNET_CORE.Models.DB;

public partial class CContext : DbContext
{
    public CContext()
    {
    }

    public CContext(DbContextOptions<CContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JasonPlaceholder> JasonPlaceholders { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-Q56U00KU; Database=C#; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JasonPlaceholder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__jasonPla__3213E83F5FD417BD");

            entity.ToTable("jasonPlaceholder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Body)
                .HasColumnType("text")
                .HasColumnName("body");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__students__3213E83FB1C7DC9A");

            entity.ToTable("students");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gender)
                .HasColumnType("text")
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
