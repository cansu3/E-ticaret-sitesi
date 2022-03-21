using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.db;

namespace WebApplication1.Controllers
{
    public class BaseController : Controller
    {
        protected eticaretEntities1 context { get; private set; }
        public BaseController()
        {
            context = new eticaretEntities1();
           

        }
    }
}