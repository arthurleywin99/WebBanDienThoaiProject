using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDienThoaiProject.Models;

namespace WebBanDienThoai.Controllers
{
    public class RatingController : Controller
    {
        [HttpGet]
        public ActionResult GetRatingStars(int id)
        {
            using (var context = new Context())
            {
                
            }
            return View();
        }
    }
}