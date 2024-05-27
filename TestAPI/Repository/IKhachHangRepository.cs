using System;
using TestAPI.Models;

namespace TestAPI.Repository
{
	public interface IKhachHangRepository
	{
        Task<IEnumerable<KhachHang>> GetAllKhachHangAsync();
        Task<KhachHang> GetKhachHangByIdAsync(int id);
        Task<KhachHang> CreateKhachHangAsync(KhachHang khachHang);
        Task<KhachHang> UpdateKhachHangAsync(KhachHang khachHang);
        Task DeleteKhachHangAsync(int id);
    }
}

