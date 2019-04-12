using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jQuery3_3_1_Demo.Controllers
{
    public class AjaxDeferredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}