using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace LaParisWebApp1.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        public ActionResult Productos()
        {
            //List<Marca> m = new List<Marca>();
            //m.Add(new Marca(Nombre, Imagen));
            return View();
            
        }
    }
}

