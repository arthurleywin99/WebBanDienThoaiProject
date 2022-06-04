using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebBanDienThoaiProject.Models;
using WebBanDienThoaiProject.ViewModels;

namespace WebBanDienThoaiProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(SigninViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string username = viewModel.Username.ToString().Trim();
                string password = Utility.MD5Hash(viewModel.Password.ToString().Trim());
                using (var context = new Context())
                {
                    MemberAccount member = context.MemberAccounts
                        .FirstOrDefault(p => p.Email.Equals(username) && p.Password.Equals(password));
                    if (member == null)
                    {
                        ViewData["SigninError"] = "Tên tài khoản hoặc mật khẩu không chính xác";
                        return View();
                    }
                    else
                    {
                        string[] Name = member.FullName.Split(' ');
                        Session["Account"] = member;
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(SignupViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string email = viewModel.Email.ToString().Trim();
                string phoneNumber = viewModel.PhoneNumber.ToString().Trim();
                string password = viewModel.Password.ToString().Trim();
                string rePassword = viewModel.RePassword.ToString().Trim();
                string fullName = viewModel.FullName.ToString().Trim();
                bool isCheck = viewModel.IsChecked;

                if (!password.Equals(rePassword))
                {
                    ViewData["RePasswordError"] = "Mật khẩu không khớp";
                    return View();
                }
                if (!isCheck)
                {
                    ViewData["IsCheck"] = "Bạn chưa đồng ý với điều khoản dịch vụ của chúng tôi";
                    return View();
                }
                using (var context = new Context())
                {
                    bool isEmailExist = context.MemberAccounts.Any(p => p.Email.Equals(email));
                    if (isEmailExist)
                    {
                        ViewData["EmailError"] = "Email đã tồn tại trong hệ thống. Vui lòng sử dụng email khác";
                        return View();
                    }
                    bool isPhoneExist = context.MemberAccounts.Any(p => p.PhoneNumber.Equals(phoneNumber));
                    if (isPhoneExist)
                    {
                        ViewData["PhoneError"] = "Số điện thoại đã tồn tại trong hệ thống. Vui lòng sử dụng số điện thoại khác";
                        return View();
                    }
                    Guid AccountTypeID = context.AccountTypes.FirstOrDefault(p => p.UserTypeName.Equals("Basic")).ID;
                    MemberAccount member = new MemberAccount()
                    {
                        ID = Guid.NewGuid(),
                        MemberTypeID = AccountTypeID,
                        Email = email,
                        Password = Utility.MD5Hash(password),
                        FullName = fullName,
                        PhoneNumber = phoneNumber,
                        Status = true
                    };
                    context.MemberAccounts.Add(member);
                    context.SaveChanges();
                    TempData["AlertMessage"] = "Tạo tài khoản thành công. Vui lòng đăng nhập";
                    return RedirectToAction("Signin", "Account");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Signout()
        {
            Session["Account"] = null;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult AccountDetail(Guid Id)
        {
            return View();
        }
    }
}