﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace GestorDeSorteosEnLinea.Controllers
{
    [Authorize]
    public class MisSorteosController : Controller
    {
  
        public ActionResult Index()
        {
     
            Model.SorteosDetalleVentas elDetalle = new Model.SorteosDetalleVentas();
            ServicioDeMisSorteos.ServicioDeMisSorteosClient elClienteDeServiciosDeMisSorteos = new ServicioDeMisSorteos.ServicioDeMisSorteosClient();
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
          
            var laListaDeSorteos = elClienteDeServiciosDeMisSorteos.ListarSorteosDeUsuario(User.Identity.GetUserId());
  
            
            return View(laListaDeSorteos);
        }
     
        public ActionResult _ElDetalleDeLaFechaDelSorteo()
        {

            ServicioDeMisSorteos.ServicioDeMisSorteosClient elClienteDeServiciosDeMisSorteos = new ServicioDeMisSorteos.ServicioDeMisSorteosClient();

            var laListaDeSorteos = elClienteDeServiciosDeMisSorteos.ListarSorteos();
            return PartialView(laListaDeSorteos);
        }
        public ActionResult Details(int id)
        {
            ServicioDeMisSorteos.ServicioDeMisSorteosClient elClienteDeServiciosDeMisSorteos = new ServicioDeMisSorteos.ServicioDeMisSorteosClient();
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
            
            var elSorteoAConsultar = elClienteDeServiciosDeMisSorteos.ConsultarUnSorteoDeUsuario(id);

            var elSorteo = elClienteDeServiciosDeSorteos.ConsultarUnSorteo(elSorteoAConsultar.IdSorteos);
            var elResultadoDelSorteo = elClienteDeServiciosDeMisSorteos.ConsultarResultadoDeSorteo(elSorteo.Id);
       

            if (elResultadoDelSorteo != null)
            {
                var elDetalleDelSorteo = elClienteDeServiciosDeMisSorteos.ConsultarUnSorteoDeUsuario(elResultadoDelSorteo.IdSorteos);
                var elMontoGanado = elClienteDeServiciosDeMisSorteos.ObtenerMontoGanado(elSorteoAConsultar, elSorteo);
                ViewBag.Opciones = elSorteo.Fecha.ToString("dd/MM/yyyy");
                ViewData["PrimerLugar"] = elResultadoDelSorteo.PrimerLugar;
                ViewData["SegundoLugar"] = elResultadoDelSorteo.SegundoLugar;
                ViewData["TercerLugar"] = elResultadoDelSorteo.TercerLugar;
                ViewData["MontoGanado"] = elMontoGanado;
                return View(elSorteoAConsultar);

            }
            else
            {
              
                ViewBag.Opciones = elSorteo.Fecha.ToString("dd/MM/yyyy");
                ViewData["PrimerLugar"] = 0;
                ViewData["SegundoLugar"] = 0;
                ViewData["TercerLugar"] = 0;
                ViewData["MontoGanado"] = 0;
                return View(elSorteoAConsultar);

            }
           
        }
        public ActionResult _DetallesSorteo(int id)
        {
            ServicioDeMisSorteos.ServicioDeMisSorteosClient elClienteDeServiciosDeMisSorteos = new ServicioDeMisSorteos.ServicioDeMisSorteosClient();

           var elSorteoAConsultar = elClienteDeServiciosDeMisSorteos.ConsultarUnSorteo(id);
            return PartialView(elSorteoAConsultar);
        }

    }
}