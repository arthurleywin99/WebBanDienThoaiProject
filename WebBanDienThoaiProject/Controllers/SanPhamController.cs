using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDienThoaiProject.Models;

namespace WebBanDienThoai.Controllers
{
    public class SanPhamController : Controller
    {
        public ActionResult DanhSachSanPhamTheoLoai(int id)
        {
            using (var context = new Context())
            {
                List<SanPham> listSanPham = (from A in context.SanPhams
                                             join B in context.LoaiSanPhams
                                             on A.MaLoai equals B.MaLoai
                                             where B.MaLoai == id
                                             select A).ToList();
                return View(listSanPham);
            }
        }

        public ActionResult ChiTietSanPham(int id)
        {
            using (var context = new Context())
            {
                SanPham sanPham = context.SanPhams.FirstOrDefault(p => p.MaSP == id);
                return View(sanPham);
            }
        }
    }
}