using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDienThoaiProject.Models;

namespace WebBanDienThoai.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (var context = new Context())
            {
                List<Product> productList = context.Products.ToList();
                return View(productList);
            }
        }

        [HttpGet]
        public ActionResult ProductsByProductType(Guid Id)
        {
            using (var context = new Context())
            {
                List<Product> listSanPham = (from A in context.Products
                                             join B in context.ProductTypes
                                             on A.ProductTypeID equals B.ID
                                             where B.ID.Equals(Id)
                                             select A).ToList();
                return View(listSanPham);
            }
        }

        [HttpGet]
        public ActionResult ProductDetails(Guid Id)
        {
            using (var context = new Context())
            {
                Product product = context.Products.FirstOrDefault(p => p.ID.Equals(Id));
                return View(product);
            }
        }

        [HttpGet]
        public ActionResult SearchProducts(string keyword)
        {
            using (var context = new Context())
            {
                List<Product> productListByName = context.Products.Where(p => p.ProductName.Contains(keyword)).ToList();
                List<Product> productListByProductType = (from A in context.Products
                                            join B in context.ProductTypes
                                            on A.ProductTypeID equals B.ID
                                            where B.ProductTypeName.Contains(keyword)
                                            select A).ToList();
                List<Product> productListByBrandName = (from A in context.Products
                                              join B in context.Brands
                                               on A.BrandID equals B.ID
                                               where B.BrandName.Contains(keyword)
                                               select A).ToList();
                HashSet<Product> productList = new HashSet<Product>();
                productList = AddData(productList, productListByName);
                productList = AddData(productList, productListByProductType);
                productList = AddData(productList, productListByBrandName);

                return View(productList);
            }
        }

        private HashSet<Product> AddData(HashSet<Product> list, List<Product> productList)
        {
            foreach (var item in productList)
            {
                list.Add(item);
            }
            return list;
        }
    }
}