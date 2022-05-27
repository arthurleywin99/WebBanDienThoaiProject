namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        public int MaTin { get; set; }

        public string HinhBia { get; set; }

        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        [StringLength(12)]
        public string NgayDang { get; set; }

        public string DuongDan { get; set; }

        public bool? TrangThai { get; set; }
    }
}
