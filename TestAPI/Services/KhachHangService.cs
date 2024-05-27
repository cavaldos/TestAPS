using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.Repository;

namespace TestAPI.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepository _khachHangRepository;

        public KhachHangService(IKhachHangRepository khachHangRepository)
        {
            _khachHangRepository = khachHangRepository;
        }

        public async Task<IEnumerable<KhachHang>> GetAllKhachHangAsync()
        {
            return await _khachHangRepository.GetAllKhachHangAsync();
        }

        public async Task<KhachHang> GetKhachHangByIdAsync(int id)
        {
            return await _khachHangRepository.GetKhachHangByIdAsync(id);
        }

        public async Task<KhachHang> CreateKhachHangAsync(KhachHang khachHang)
        {
            return await _khachHangRepository.CreateKhachHangAsync(khachHang);
        }

        public async Task<KhachHang> UpdateKhachHangAsync(KhachHang khachHang)
        {
            return await _khachHangRepository.UpdateKhachHangAsync(khachHang);
        }

        public async Task DeleteKhachHangAsync(int id)
        {
            await _khachHangRepository.DeleteKhachHangAsync(id);
        }
    }
}
