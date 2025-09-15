using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject1.Controllers
{
    public class DemoController : Controller
    {
        public string Index()
        {
            return "Hello from Demo Controller - Index Action Method.";
        }
        public string Show()
        {
            return "Hello from Demo Controller - Show Action Method.";
        }
    }
}