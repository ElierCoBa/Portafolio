using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestorDeSorteosEnLinea.Controllers
{
    [Authorize]
    public class SorteosCerradosController : Controller
    {
        public ActionResult Index()
        {

            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();

            var laListaDeSorteos = elClienteDeServiciosDeSorteos.ListarSorteosCerrados();
            return View(laListaDeSorteos);
        }


      
        public ActionResult Details(int id, Model.SorteosResultados elResultado)
        {

            ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient elClienteDeResulados = new ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient();
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
            var laListaDeSorteos = elClienteDeServiciosDeSorteos.ConsultarUnSorteo(id);
            Decimal TotalVendidoSorte = elClienteDeResulados.ObtenerElTotalVendidoEnUnSorteo(id);

            elResultado = elClienteDeResulados.ConsultarUnResultado(id);

            Decimal TotalPagadoAlNumeroDelPrimerLugar = elClienteDeResulados.ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(id, elResultado.PrimerLugar);
            Decimal TotalPagadoAlNumeroDelSegundoLugar = elClienteDeResulados.ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(id, elResultado.SegundoLugar);
            Decimal TotalPagadoAlNumeroDelTercerLugar = elClienteDeResulados.ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(id, elResultado.TercerLugar);

            Decimal TotalPagadoEnPremios = TotalPagadoAlNumeroDelPrimerLugar + TotalPagadoAlNumeroDelSegundoLugar + TotalPagadoAlNumeroDelTercerLugar;


            ViewBag.TotalPagadoPrimerNumero = TotalPagadoAlNumeroDelPrimerLugar.ToString();
            ViewBag.TotalPagadoSegundoNumero = TotalPagadoAlNumeroDelSegundoLugar.ToString();
            ViewBag.TotalPagadoTercerNumero = TotalPagadoAlNumeroDelTercerLugar.ToString();
            ViewBag.TotalPagadoEnPremios = TotalPagadoEnPremios.ToString();
            ViewBag.TotalVendido = TotalVendidoSorte.ToString();

            return View(laListaDeSorteos);
            
        }

       
        
    }
}
