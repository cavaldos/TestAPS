using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;
using TestAPI.Services;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangService _khachHangService;

        public KhachHangController(IKhachHangService khachHangService)
        {
            _khachHangService = khachHangService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<KhachHang>>> GetKhachHang()
        {
            try
            {
                var khachHangs = await _khachHangService.GetAllKhachHangAsync();
                return Ok(khachHangs);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new
                    {
                        message = "Có lỗi xảy ra khi lấy danh sách khách hàng",
                        error = ex.Message
                    }
                );
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<KhachHang>> GetKhachHang(int id)
        {
            try
            {
                var khachHang = await _khachHangService.GetKhachHangByIdAsync(id);

                if (khachHang == null)
                {
                    return NotFound(new { message = "Không tìm thấy khách hàng" });
                }

                return Ok(khachHang);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new
                    {
                        message = "Có lỗi xảy ra khi lấy thông tin khách hàng",
                        error = ex.Message
                    }
                );
            }
        }

        [HttpPost]
        public async Task<ActionResult<KhachHang>> CreateKhachHang(KhachHang khachHang)
        {
            try
            {
                var createdKhachHang = await _khachHangService.CreateKhachHangAsync(khachHang);
                return CreatedAtAction(
                    nameof(GetKhachHang),
                    new { id = createdKhachHang.MaKhachHang },
                    createdKhachHang
                );
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new { message = "Có lỗi xảy ra khi tạo khách hàng", error = ex.Message }
                );
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKhachHang(int id, KhachHang khachHang)
        {
            if (id != khachHang.MaKhachHang)
            {
                return BadRequest(new { message = "Id không khớp" });
            }

            try
            {
                await _khachHangService.UpdateKhachHangAsync(khachHang);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new { message = "Có lỗi xảy ra khi cập nhật khách hàng", error = ex.Message }
                );
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhachHang(int id)
        {
            try
            {
                await _khachHangService.DeleteKhachHangAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(
                    500,
                    new { message = "Có lỗi xảy ra khi xóa khách hàng", error = ex.Message }
                );
            }
        }
    }
}
