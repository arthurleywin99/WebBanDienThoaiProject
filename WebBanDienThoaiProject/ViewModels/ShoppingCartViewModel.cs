using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanDienThoaiProject.ViewModels
{
    public class ShoppingCartViewModel
    {
        public Guid ID { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
    }
}