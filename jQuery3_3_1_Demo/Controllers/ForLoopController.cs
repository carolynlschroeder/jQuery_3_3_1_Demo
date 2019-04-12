using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jQuery3_3_1_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace jQuery3_3_1_Demo.Controllers
{
    public class ForLoopController : Controller
    {
        public IActionResult Index()
        {
            var model = new NamesModel();
            model.Names = new List<string>
                {"Carol Mason", "Amy Montoni", "Robert Morris", "Richard Thurmond", "Val Fox"};
            return View(model);
        }
    }
}