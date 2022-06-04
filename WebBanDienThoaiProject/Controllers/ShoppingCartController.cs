using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDienThoaiProject.ViewModels;
using WebBanDienThoaiProject.Models;

namespace WebBanDienThoaiProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        private List<ShoppingCartViewModel> GetAlls()
        {
            List<ShoppingCartViewModel> list = Session["Cart"] as List<ShoppingCartViewModel>;
            if (list == null)
            {
                list = new List<ShoppingCartViewModel>();
                Session["Cart"] = list;
            }
            return list;
        }

        private void AddItems(List<ShoppingCartViewModel> carts, Guid ProductID) 
        {
            bool isExist = carts.Any(p => p.ID == ProductID);
            if (isExist)
            {
                foreach (var item in carts)
                {
                    if (item.ID == ProductID)
                    {
                        item.Quantity += 1;
                        break;
                    }
                }
            }
            else
            {
                carts.Add(new ShoppingCartViewModel
                {
                    ID = ProductID,
                    Quantity = 1
                });
            }
            Session["Cart"] = carts;
        }

        [HttpGet]
        public ActionResult AddToCart(Guid ProductID, string CurrentURL)
        {
            using (var context = new Context())
            {
                List<ShoppingCartViewModel> carts = GetAlls();
                AddItems(carts, ProductID);
            }
            return Redirect(CurrentURL);
        }
    }
}