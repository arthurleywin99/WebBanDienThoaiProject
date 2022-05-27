using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDienThoaiProject.Models;

namespace WebBanDienThoai.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Banner LoaiSanPham
        /// </summary>
        /// <returns></returns>
        public ActionResult LoaiSanPham()
        {
            using (var context = new Context())
            {
                var loaiSanPhamList = context.LoaiSanPhams.ToList();
                return PartialView(loaiSanPhamList);
            }
        }

        /// <summary>
        /// Carousel Slider
        /// </summary>
        /// <returns></returns>
        public ActionResult CarouselSlider()
        {
            using (var context = new Context())
            {
                var sliderImages = context.CarouselSliders.ToList();
                return PartialView(sliderImages);
            }
        }

        /// <summary>
        /// Middle Banner
        /// </summary>
        /// <returns></returns>
        public ActionResult MidBanner()
        {
            using (var context = new Context())
            {
                var midBanner = context.Banners.SingleOrDefault(p => p.TenBanner.Equals("MID"));
                return PartialView(midBanner);
            }
        }

        /// <summary>
        /// Top 5 điện thoại nổi bật
        /// </summary>
        /// <returns></returns>
        public ActionResult DienThoaiNoiBat()
        {
            using (var context = new Context())
            {
                List<SanPham> dienThoaiList = (from A in context.SanPhams
                                               join B in context.LoaiSanPhams on A.MaLoai equals B.MaLoai
                                               where B.TenLoai == "Điện thoại"
                                               orderby A.SoLanMua
                                               select A).OrderBy(p => p.SoLanMua).Take(4).ToList();
                return PartialView(dienThoaiList);
            }
        }

        /// <summary>
        /// Top 4 laptop nổi bật
        /// </summary>
        /// <returns></returns>
        public ActionResult LaptopNoiBat()
        {
            using (var context = new Context())
            {
                List<SanPham> laptopList = (from A in context.SanPhams
                                               join B in context.LoaiSanPhams on A.MaLoai equals B.MaLoai
                                               where B.TenLoai == "Laptop"
                                               orderby A.SoLanMua
                                               select A).OrderBy(p => p.SoLanMua).Take(4).ToList();
                return PartialView(laptopList);
            }
        }

        /// <summary>
        /// Chuyên Trang Thương Hiệu
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuyenTrangThuongHieu()
        {
            using (var context = new Context())
            {
                List<ChuyenTrangThuongHieu> thuongHieuList = context.ChuyenTrangThuongHieus.ToList();
                return PartialView(thuongHieuList);
            }
        }
    }
}