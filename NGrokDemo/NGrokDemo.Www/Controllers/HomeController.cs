using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGrokDemo.Www.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index(HelloModel model) {
            return View(model);
        }

    }

    public class HelloModel {
        public string Name { get; set; }
        public string Language { get; set; }
    }
}
