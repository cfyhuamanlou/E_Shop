using E_Shop.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        private readonly ICustomerService _customerService;
        public LoginController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string loginName, string loginPwd)
        {
            var customer= _customerService.FindEntityAsync(c => c.LoginName == loginName && c.LoginPwd == loginPwd);
            if(customer==null)
            {
                return Content("no");
            }
            else
            {
                return Content("ok");
            }
        }



    }
}