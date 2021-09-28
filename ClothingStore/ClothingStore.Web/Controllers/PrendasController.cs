using ClothingStore.BL;
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
            var prendasBL = new PrendasBL();
            var listadePrendas = prendasBL.ObtenerPrendas();

            return View(listadePrendas);
        }
    }
}