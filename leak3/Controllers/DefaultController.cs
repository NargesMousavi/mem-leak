using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace leak3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //Marshal.AllocHGlobal(1000000000);
            return View();
        }
        private void timerUnManaged_Tick(object sender, EventArgs e)
        {
           
        }
    }
}