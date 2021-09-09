using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial1.Controllers
{
    public class CajeroController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Retiro( int cantidada)
        {
            
            return View();
        }

        public ActionResult RetiroExitoso()
        {

            return View();
        }

        public ActionResult RetiroFallido()
        {

            return View();
        }
    }

    
    
    

}