namespace WebBanDienThoaiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        public int MaNCC { get; set; }

        [StringLength(100)]
        public string TenNCC { get; set; }

        public string DiaChi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string DienThoai { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
