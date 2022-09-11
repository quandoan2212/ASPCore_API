using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class QuanLyHeThongPhongMayContext : DbContext
    {
        public QuanLyHeThongPhongMayContext()
        {
        }

        public QuanLyHeThongPhongMayContext(DbContextOptions<QuanLyHeThongPhongMayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<LichDungPhongMay> LichDungPhongMays { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<PhongMay> PhongMays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=M2LAPTOP\\SQLEXPRESS02;Initial Catalog=QuanLyHeThongPhongMay;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.HasKey(e => e.MaGv)
                    .HasName("PK__GiangVie__2725AEF380E35CE2");

                entity.ToTable("GiangVien");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaGV");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SoDt)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");
            });

            modelBuilder.Entity<LichDungPhongMay>(entity =>
            {
                entity.HasKey(e => e.MaLich)
                    .HasName("malich_pk");

                entity.ToTable("LichDungPhongMay");

                entity.Property(e => e.MaLich)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaGv)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaGV");

                entity.Property(e => e.MaMon)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHoc).HasColumnType("date");

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.LichDungPhongMays)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichDungPh__MaGV__182C9B23");

                entity.HasOne(d => d.MaMonNavigation)
                    .WithMany(p => p.LichDungPhongMays)
                    .HasForeignKey(d => d.MaMon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichDungP__MaMon__164452B1");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.LichDungPhongMays)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichDungP__MaPho__173876EA");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMon)
                    .HasName("PK__MonHoc__3A5B29A818D5E29C");

                entity.ToTable("MonHoc");

                entity.Property(e => e.MaMon)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoTietTh).HasColumnName("SoTietTH");

                entity.Property(e => e.TenMon)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PhongMay>(entity =>
            {
                entity.HasKey(e => e.MaPhong)
                    .HasName("PK__PhongMay__20BD5E5BF128905C");

                entity.ToTable("PhongMay");

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
