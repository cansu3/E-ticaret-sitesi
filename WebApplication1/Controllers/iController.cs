using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.db;

namespace WebApplication1.Controllers
{
   
    public class iController : Controller
    {
        eticaretEntities1 context;
        // GET: i
        public ActionResult Index()
        {
            context = new eticaretEntities1();
            return View();
        }
    }
}