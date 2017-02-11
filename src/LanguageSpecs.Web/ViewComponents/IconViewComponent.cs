using LanguageSpecs.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageSpecs.Web.ViewComponents
{
    public class IconViewComponent : ViewComponent
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public IconViewComponent(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IViewComponentResult> InvokeAsync(LanguageSpecData model)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var icon = String.IsNullOrWhiteSpace(model.Icon) ? "fa fa-code" : model.Icon;
            var logo = model.Logo;

            if (!String.IsNullOrWhiteSpace(logo))
            {
                var logoPath = $"data\\images\\{logo}";
                if (File.Exists(Path.Combine(_hostingEnvironment.WebRootPath, logoPath)))
                {
                    return View("Logo", $"/{logoPath.Replace("\\", "/")}");
                }
            }
            return View("Default", icon);
        }
    }
}
