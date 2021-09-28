using ClothingStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingStore.Web.Controllers
{
    public class PrendasController : Controller
    {
        // GET: Prendas
        public ActionResult Index()
        {
            var prendas1 = new PrendasModel();
            prendas1.Id = 1;
            prendas1.Descripcion = "Jeans";

            var prendas2 = new PrendasModel();
            prendas2.Id = 2;
            prendas2.Descripcion = "Camisa";

            var prendas3 = new PrendasModel();
            prendas3.Id = 3;
            prendas3.Descripcion = "Vestido";

            var prendas4 = new PrendasModel();
            prendas4.Id = 4;
            prendas4.Descripcion = "Blusa";

            var listadeprendas = new List<PrendasModel>();
            listadeprendas.Add(prendas1);
            listadeprendas.Add(prendas2);
            listadeprendas.Add(prendas3);
            listadeprendas.Add(prendas4);

            return View(listadeprendas);
        }
    }
}