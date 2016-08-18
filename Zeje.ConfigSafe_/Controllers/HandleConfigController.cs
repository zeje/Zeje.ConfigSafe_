using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zeje.ConfigSafe_.Controllers
{
    public class HandleConfigController : Controller
    {
        // GET: HandleConfig
        public ActionResult Index()
        {
            using (QYEntities db = new QYEntities())
            {
                var lst = db.QyUser.Take(10).ToList();
                return View(lst);
            }
        }
    }
}