using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Newtonsoft.Json;
using LanguageSpecs.Web.Models;

namespace LanguageSpecs.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var datafile = Path.Combine(this.hostingEnvironment.WebRootPath, "data", "specs.json");
            var data = JsonConvert.DeserializeObject<IEnumerable<LanguageSpecData>>(System.IO.File.ReadAllText(datafile));

            return View(data.OrderBy(d => d.Title));
        }

        [Route("error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
