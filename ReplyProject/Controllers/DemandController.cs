using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReplyProject.Controllers
{
    public class DemandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
