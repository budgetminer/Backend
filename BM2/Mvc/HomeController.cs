//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace BM2.Mvc
//{
//    [Route("[controller]")]
//    public class HomeController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View("~/Mvc/Views/Home/Index.cshtml");
//        }

//        public IActionResult AccessDenied()
//        {
//            return View("~/Mvc/Views/AccessDenied.cshtml");
//        }

//        public IActionResult LoggedOut()
//        {
//            return View("~/Mvc/Views/LoggedOut.cshtml");
//        }

//        public IActionResult NotLoggedOut()
//        {
//            return View("~/Mvc/Views/NotLoggedOut.cshtml");
//        }

//        //public async Task<IActionResult> Logout([FromServices] IAuthService authService)
//        //{
//        //    try
//        //    {
//        //        var redirectUrl = await authService.LogOutAsync(ControllerContext, "Home", "LoggedOut");
//        //        return string.IsNullOrEmpty(redirectUrl) ? NotLoggedOut() : Redirect(redirectUrl);
//        //    }
//        //    catch (Exception)
//        //    {
//        //        return NotLoggedOut();
//        //    }
//        //}
//    }
//}
