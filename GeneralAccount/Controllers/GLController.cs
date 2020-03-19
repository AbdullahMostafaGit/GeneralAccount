using GeneralAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralAccount.Controllers
{
    public class GLController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View(db.JOU_1997.ToList());
        }
    }
}