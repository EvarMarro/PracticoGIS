using System.Web.Mvc;
using Npgsql;
using PracticoGIS.Models;
using PracticoGIS.Service;

namespace PracticoGIS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           
            return View();
        }

        #region ABM
        public ActionResult AltaContenedor(Contenedor contenedor)
        {
            return Json(ContenedorService.AltaContenedor(contenedor), JsonRequestBehavior.AllowGet);
        }


        #endregion
    }
}
