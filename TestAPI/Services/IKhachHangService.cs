using System;
using TestAPI.Models;

namespace TestAPI.Services
{
	public interface IKhachHangService
	{
		Task<IEnumerable<KhachHang>> GetAllKhachHangAsync();
		Task<KhachHang> GetKhachHangByIdAsync(int id);
		Task<KhachHang> CreateKhachHangAsync(KhachHang khachHang);
		Task<KhachHang> UpdateKhachHangAsync(KhachHang khachHang);
		Task DeleteKhachHangAsync(int id);
	}
}

