using System;
using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TenLopHoc { get; set; }

        [Required]
        public int NamNhapHoc { get; set; } // Thay đổi kiểu dữ liệu thành int

        [Required]
        public int NamRaTruong { get; set; } // Thay đổi kiểu dữ liệu thành int

        [Required]
        public int SoLuongSinhVien { get; set; }
    }
}
