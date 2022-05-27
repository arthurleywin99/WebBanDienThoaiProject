namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banner")]
    public partial class Banner
    {
        [Key]
        public int MaBanner { get; set; }

        [StringLength(100)]
        public string TenBanner { get; set; }

        public string HinhAnh { get; set; }

        public string DuongDan { get; set; }

        public bool? TrangThai { get; set; }
    }
}
