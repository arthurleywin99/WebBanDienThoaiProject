using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanDienThoaiProject.ViewModels
{
    public class SignupViewModel
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string FullName { get; set; }
        public bool IsChecked { get; set; }
    }
}