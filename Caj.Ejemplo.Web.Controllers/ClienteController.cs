using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Caj.Ejemplo.Web.Datos;
using Caj.Ejemplo.Web.Model;

namespace Caj.Ejemplo.Web.Controllers
{
    public class ClienteController : Controller
    {

        public ActionResult Inicio()
        {
            var lstClietnes = new ClienteData().CargaClientes();

            return View(lstClietnes);
        }


        public ActionResult Detalle()
        {
            ViewBag.Titulo = "Detalle ";
            var objCLiente = new Cliente () { idCliente = 1, Nombre = "Javisss", Tipo="Jay" };

            return PartialView("_Detalle", objCLiente);

        }

    }
}
