using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_BookStore.BusinessLayer;
using E_BookStore.Model;

namespace E_BookStore.AdminPanel.Controllers
{
    public class BookController : Controller
    {
        [Route("Books")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
