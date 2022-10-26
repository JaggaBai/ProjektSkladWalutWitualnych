using Microsoft.AspNetCore.Mvc;
using ProjektObsługaOperacjiKont.Models;

namespace ProjektObsługaOperacjiKont.Controllers
{
    public class TypDigitalCurrency : Controller
    {
        public IActionResult Create() { return View(); }


        [HttpPost]
        public IActionResult Create(TypDigitalCurrency typdigitalcurrency)
        { if (!ModelState.IsValid)
            {
                return View(typdigitalcurrency);
            }
            return View();
        }
    }
}

