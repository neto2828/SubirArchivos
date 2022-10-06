using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using SubirArchivos.Models.ViewModels;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace SubirArchivos.Controllers
{
    public class ArchivoController : Controller
    {

        private readonly IHostEnvironment _host;

        public ArchivoController(IHostEnvironment host)
        {
            _host = host;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(ArchivoViewModel model)
        {
            string RutaSitio = _host.ContentRootPath;
            //string PathArchivo1 = Path.Combine(RutaSitio+"/Files/arhivo1.png");
            //string PathArchivo2 = Path.Combine(RutaSitio + "/Files/arhivo2.png");           
                if (!ModelState.IsValid)
            {
                return View("Index");
            }

            using (Stream fileStream1 = new FileStream(Path.Combine(RutaSitio + "/Files/arhivo1.png"), FileMode.Create))
            {
                model.Archivo1.CopyTo(fileStream1);
            }

            using (Stream fileStream2 = new FileStream(Path.Combine(RutaSitio + "/Files/arhivo2.png"), FileMode.Create))
            {
                model.Archivo2.CopyTo(fileStream2);
            }


            return RedirectToAction("Index");
        }
    }
}
