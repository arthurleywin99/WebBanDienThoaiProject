namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonDatHang")]
    public partial class DonDatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonDatHang()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }

        [Key]
        public int MaDDH { get; set; }

        [StringLength(11)]
        public string NgayDat { get; set; }

        [StringLength(20)]
        public string TinhTrangGiao { get; set; }

        [StringLength(11)]
        public string NgayGiao { get; set; }

        public bool? DaThanhToan { get; set; }

        public decimal? UuDai { get; set; }

        [Required]
        [StringLength(12)]
        public string SDTDat { get; set; }

        [Required]
        [StringLength(100)]
        public string EmailDat { get; set; }

        [StringLength(100)]
        public string MaChuyenKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}
