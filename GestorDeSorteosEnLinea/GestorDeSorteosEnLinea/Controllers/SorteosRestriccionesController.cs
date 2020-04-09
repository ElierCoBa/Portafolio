using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestorDeSorteosEnLinea.Controllers
{
    [Authorize]
    public class SorteosRestriccionesController : Controller
    {

        public ActionResult Index()
        {

            ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient elServicioDeSorteosRestricciones;
            elServicioDeSorteosRestricciones = new ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient();

            var laListaDeSorteos = elServicioDeSorteosRestricciones.ListarSorteos();

            return View(laListaDeSorteos);
            
        }

       

        public ActionResult DetallesIndex(Model.Sorteos elSorteo)
        {
            ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient elServicioDeSorteosRestricciones;
            elServicioDeSorteosRestricciones = new ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient();
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDelServicioDeSorteo = new ServicioDeSorteos.ServicioDeSorteosClient();
            var laListaDeRestricciones = elServicioDeSorteosRestricciones.ListarRestriccionDeSorteo(elSorteo.Id);
            return View(laListaDeRestricciones);
        }

        // GET: SorteosRestricciones/Create
        public ActionResult Create(int id)
        {
            ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient elServicioDeSorteosRestricciones;
            elServicioDeSorteosRestricciones = new ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient();
            
            ViewBag.Fecha = elServicioDeSorteosRestricciones.ConsultarFechaDeunSorteo(id);

            ViewBag.yaExisteElSorteoConRestriccion = false;
            ViewBag.Numero = 0;
            
            return View();
        }

        // POST: SorteosRestricciones/Create
        [HttpPost]
        public ActionResult Create(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo)
        {
            try
            {
                ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient elServicioDeSorteosRestricciones;
                elServicioDeSorteosRestricciones = new ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient();
                
                elSorteo.MontoMaximo = int.Parse(Request.Form["elMontoComprado"]);
                elSorteo.Numero = int.Parse(Request.Form["elNumeroComprado"]);

                if (elServicioDeSorteosRestricciones.PoseeRestriccionElSorteoSeleccionado(elSorteo.Numero,elSorteo.Id) == false)
                {
               

                    elServicioDeSorteosRestricciones.CrearUnSorteoRestriccion(elSorteo);

                    return RedirectToAction("Index");
                }
                  else {

                    ViewBag.Fecha = elServicioDeSorteosRestricciones.ConsultarFechaDeunSorteo(elSorteo.Id);
                    ViewBag.Numero = elSorteo.Numero.ToString();
                    
                    ViewBag.yaExisteElSorteoConRestriccion = elServicioDeSorteosRestricciones.PoseeRestriccionElSorteoSeleccionado(elSorteo.Numero, elSorteo.Id);

                    return View(); }


            }
            catch
            {
                return View();
            }
        }


        public ActionResult EditarRestriccion(int id)
        {

            ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient elServicioDeSorteosRestricciones;
            elServicioDeSorteosRestricciones = new ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient();
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();

            var elSorteoRestriccionConsultado = elServicioDeSorteosRestricciones.ConsultarUnSorteosConRestricciones(id);
            var elSorteoConsultado = elClienteDeSorteos.ConsultarUnSorteo(elSorteoRestriccionConsultado.IdSorteos);
            ViewData["FechaSorteo"] = elSorteoConsultado.Fecha.ToString("dd/MM/yyyy"); ;
            return View(elSorteoRestriccionConsultado);
        }
        [HttpPost]
        public ActionResult EditarRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo)
        {
            try
            {

                ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient elServicioDeSorteosRestricciones;
                elServicioDeSorteosRestricciones = new ServicioDeSorteosRestricciones.ServiciosDeSorteosRestriccionesClient();

                elServicioDeSorteosRestricciones.EditarUnSorteoRestriccion(elSorteo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
    }
}
