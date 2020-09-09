using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trial2_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
    }
}