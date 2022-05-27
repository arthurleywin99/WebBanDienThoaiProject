namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarouselSlider")]
    public partial class CarouselSlider
    {
        [Key]
        public int ThuTuHinh { get; set; }

        [StringLength(20)]
        public string TenThuTu { get; set; }

        public string HinhAnh { get; set; }

        public string DuongDan { get; set; }

        public bool? TrangThai { get; set; }
    }
}
