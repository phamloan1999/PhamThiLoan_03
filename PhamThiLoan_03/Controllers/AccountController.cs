using PhamThiLoan_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PhamThiLoan_03.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
       
            public ViewResult Login(string returnUrl)
            {
                ViewBag.returnUrl = returnUrl;
                return View();
            }
            // Nhận dữ liệu từ client gửi lên
            [HttpPost]
            [AllowAnonymous]
            [ValidateAntiForgeryToken]
            public ActionResult Login(AccountModel acc, string returnUrl)
            {
                // Nếu vượt qua được validation ở AccountModel

                if (ModelState.IsValid)
                {
                    // Kiểm tra thông tin đăng nhập
                    if (acc.Username == "admin" && acc.Password == "123456")
{
                        // Set Cookie

                        FormsAuthentication.SetAuthCookie(acc.Username, true);
                        return RedirectTolocal(returnUrl);
                    }
                }
                return View(acc);
            }
            public ActionResult Logoff()
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Index", "Home");
            }
            // Kiểm tra xem returnUrl có thuộc hệ thống hay không
            private ActionResult RedirectTolocal(string returnUrl)
            {
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

        }
    }



