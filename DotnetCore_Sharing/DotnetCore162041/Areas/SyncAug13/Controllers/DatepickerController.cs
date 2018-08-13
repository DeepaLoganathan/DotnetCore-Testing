using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2;

namespace DotnetCore162041.SyncAug13.Controllers
{
    [Area("SyncAug13")]
    public class DatepickerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}