﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanDienThoaiProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}