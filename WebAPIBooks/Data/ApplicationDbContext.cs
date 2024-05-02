using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAPIBooks.Models;

namespace WebAPIBooks.Data;
//package manager console asagidaki satiri yazdim ve modellerle context dosyasini benim icin otomatik olarak olusturdu, cunku tablolarım zaten mevcuttu.
//"Data Source=(localdb)\MSSQLLocalDB; Database=TechCareer; Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data -Context ApplicationDbContext
public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Kategori> Kategoris { get; set; }
    public virtual DbSet<Kitap> Kitaps { get; set; }
    public virtual DbSet<Yayinevi> Yayinevis { get; set; }
    public virtual DbSet<Yazar> Yazars { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Database=TechCareer; Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
        modelBuilder.Entity<Kategori>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Category");

            entity.ToTable("Kategori");

            entity.Property(e => e.KategoriAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<Kitap>(entity =>
        {
            entity.ToTable("Kitap");

            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KitapAdi).HasMaxLength(250);
        });

        modelBuilder.Entity<Yayinevi>(entity =>
        {
            entity.ToTable("Yayinevi");

            entity.Property(e => e.YayineviAdi).HasMaxLength(200);
        });

        modelBuilder.Entity<Yazar>(entity =>
        {
            entity.ToTable("Yazar");

            entity.Property(e => e.YazarAdi).HasMaxLength(100);
            entity.Property(e => e.YazarSoyadi).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
