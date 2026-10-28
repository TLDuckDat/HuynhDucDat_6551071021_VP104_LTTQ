using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HuynhDucDat_6551071021_VP104_LTTQ.Models;

public partial class DuLieuNhanSuContext : DbContext
{
    public DuLieuNhanSuContext() { }

    public DuLieuNhanSuContext(DbContextOptions<DuLieuNhanSuContext> options) : base(options) { }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DuLieu_NhanSu;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NHANVIEN__77B2CA47C35B579E");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.MaNhanVien).HasMaxLength(10);
            entity.Property(e => e.LuongCoBan).HasMaxLength(12);
            entity.Property(e => e.TenNhanVien).HasColumnType("ntext");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
