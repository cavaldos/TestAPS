using System;
using System.ComponentModel.DataAnnotations;



namespace TestAPI.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhachHang { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
