using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Logic;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        IOptionGenerator _generator;

        public HomeController(IOptionGenerator generator)
        {
            _generator = generator;
        }


        [HttpGet]
        public ActionResult Index()
        {
            DropDownListModel model = new DropDownListModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(DropDownListModel model)
        {
            if (model.Options == null)
                model.Options = new List<string>();
            if (ModelState.IsValid)
                model.Options.Add(_generator.GenerateOption(model.NewOption));
               
            return View(model);
        }

    }
}
