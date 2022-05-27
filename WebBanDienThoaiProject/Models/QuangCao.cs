namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuangCao")]
    public partial class QuangCao
    {
        [Key]
        public int MaQC { get; set; }

        [StringLength(100)]
        public string TenQC { get; set; }

        [StringLength(12)]
        public string ThoiGianBatDau { get; set; }

        [StringLength(12)]
        public string ThoiGianKetThuc { get; set; }

        public string DuongDan { get; set; }

        public string HinhAnh { get; set; }

        public bool? TrangThai { get; set; }
    }
}
