namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoiDap")]
    public partial class HoiDap
    {
        [Key]
        public int MaHoiDap { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        public string DiaChi { get; set; }

        [StringLength(255)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public bool? TrangThai { get; set; }
    }
}
