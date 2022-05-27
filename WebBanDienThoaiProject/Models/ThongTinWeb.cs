namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinWeb")]
    public partial class ThongTinWeb
    {
        [Key]
        public int MaThongTin { get; set; }

        public string TuKhoa { get; set; }

        public string NoiDung { get; set; }

        public bool? TrangThai { get; set; }
    }
}
