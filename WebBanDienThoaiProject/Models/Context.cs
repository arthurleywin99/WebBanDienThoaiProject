using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebBanDienThoaiProject.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<BinhLuan> BinhLuans { get; set; }
        public virtual DbSet<CarouselSlider> CarouselSliders { get; set; }
        public virtual DbSet<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual DbSet<ChuyenTrangThuongHieu> ChuyenTrangThuongHieus { get; set; }
        public virtual DbSet<DonDatHang> DonDatHangs { get; set; }
        public virtual DbSet<HoiDap> HoiDaps { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<LoaiThanhVien> LoaiThanhViens { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<QuangCao> QuangCaos { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<ThongTinWeb> ThongTinWebs { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }
        public virtual DbSet<TinTuc> TinTucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>()
                .Property(e => e.DuongDan)
                .IsUnicode(false);

            modelBuilder.Entity<BinhLuan>()
                .Property(e => e.NgayBinhLuan)
                .IsUnicode(false);

            modelBuilder.Entity<CarouselSlider>()
                .Property(e => e.DuongDan)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenTrangThuongHieu>()
                .Property(e => e.DuongDan)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.NgayDat)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.NgayGiao)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.UuDai)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.SDTDat)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.EmailDat)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.MaChuyenKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .HasMany(e => e.ChiTietDonDatHangs)
                .WithRequired(e => e.DonDatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoiDap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<HoiDap>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThanhVien>()
                .Property(e => e.UuDai)
                .HasPrecision(5, 0);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<QuangCao>()
                .Property(e => e.ThoiGianBatDau)
                .IsUnicode(false);

            modelBuilder.Entity<QuangCao>()
                .Property(e => e.ThoiGianKetThuc)
                .IsUnicode(false);

            modelBuilder.Entity<QuangCao>()
                .Property(e => e.DuongDan)
                .IsUnicode(false);

            modelBuilder.Entity<QuangCao>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.NgayCapNhat)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDonDatHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThuongHieu>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.HinhBia)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.NgayDang)
                .IsUnicode(false);

            modelBuilder.Entity<TinTuc>()
                .Property(e => e.DuongDan)
                .IsUnicode(false);
        }
    }
}
