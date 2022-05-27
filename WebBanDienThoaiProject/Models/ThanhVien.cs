namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            BinhLuans = new HashSet<BinhLuan>();
        }

        [Key]
        public int MaTV { get; set; }

        public int? MaLoaiTV { get; set; }

        public int? MaBinhLuan { get; set; }

        [Required]
        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(33)]
        public string MatKhau { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(15)]
        public string DienThoai { get; set; }

        public string CauHoi { get; set; }

        public string CauTraLoi { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        public virtual LoaiThanhVien LoaiThanhVien { get; set; }
    }
}
