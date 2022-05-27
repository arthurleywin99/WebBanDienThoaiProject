namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuan")]
    public partial class BinhLuan
    {
        [Key]
        public int MaBinhLuan { get; set; }

        public int? MaSP { get; set; }

        public int? MaTV { get; set; }

        public string NoiDung { get; set; }

        [Required]
        [StringLength(11)]
        public string NgayBinhLuan { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
