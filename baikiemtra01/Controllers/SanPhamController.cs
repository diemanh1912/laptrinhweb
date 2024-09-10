using BaiTap06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public class SanPhamViewModel
        {
            public string TenSanPham { get; set; }
            public decimal GiaBan { get; set; }
            public string AnhMoTa { get; set; }
        }
    }

}