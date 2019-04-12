using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jQuery3_3_1_Demo.Controllers
{
    public class JsonController : Controller
    {
        public JsonResult GetSponsors()
        {
            var sponsors = new List<string>
            {
                "Luther Burbank Savings", "Amy's Kitchen-Petaluma", "Exchange Bank-Santa Rosa", "KZST Radio Station",
                "Friedman's Home Improvement - Santa Rosa"
            };
            return Json(new {sponsors});
        }
    }
}