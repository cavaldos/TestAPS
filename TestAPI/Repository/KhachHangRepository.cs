using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Data;  // Đảm bảo rằng bạn đã định nghĩa ApplicationDbContext trong không gian tên này

namespace TestAPI.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly ApplicationDbContext _context;

        public KhachHangRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<KhachHang>> GetAllKhachHangAsync()
        {
            return await _context.KhachHang.ToListAsync();
        }

        public async Task<KhachHang> GetKhachHangByIdAsync(int id)
        {
            return await _context.KhachHang.FindAsync(id);
        }

        public async Task<KhachHang> CreateKhachHangAsync(KhachHang khachHang)
        {
            _context.KhachHang.Add(khachHang);
            await _context.SaveChangesAsync();
            return khachHang;
        }

        public async Task<KhachHang> UpdateKhachHangAsync(KhachHang khachHang)
        {
            _context.Entry(khachHang).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return khachHang;
        }

        public async Task DeleteKhachHangAsync(int id)
        {
            var khachHang = await _context.KhachHang.FindAsync(id);
            if (khachHang != null)
            {
                _context.KhachHang.Remove(khachHang);
                await _context.SaveChangesAsync();
            }
        }
    }
}
