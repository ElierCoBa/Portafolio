﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestorDeSorteosEnLinea.Controllers
{
    [Authorize]
    public class ResultadosDeSorteoController : Controller
    {
        public ActionResult Index()
        {

            ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient elClienteDeResulados = new ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient();
            var laListaDeSorteos = elClienteDeResulados.ListarResultados();
            return View(laListaDeSorteos);
        }

        public ActionResult Details(Model.SorteosResultados elResultado)
        {

            ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient elClienteDeResulados = new ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient();
            

            var elSorteoAConsultar = elClienteDeResulados.ConsultarUnResultado(elResultado.IdSorteos);
            return View(elSorteoAConsultar);
            
        }

        public ActionResult Create(int id)
        {
            ServicioDeSorteos.ServicioDeSorteosClient elCliente = new ServicioDeSorteos.ServicioDeSorteosClient();
            ViewData["laFechaDelSorteo"] = elCliente.ConsultarUnSorteo(id).Fecha.ToShortDateString();
            return View();
        }


        [HttpPost]
        public ActionResult Create(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado, GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {

                try
                {

                    ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient elClienteDeResulados = new ServicioDeResultadosDeSorteo.ServicioDeResultadosDeSorteoClient();
                    elSorteo.Estado = Model.Estados.Cerrado;
                    elResultado.IdSorteos = elSorteo.Id;
                    elResultado.Id = 0;
                    elSorteoHistorico.TipoDeModificacion = Model.TipoDeModificacion.Insercion;
                    elClienteDeResulados.AgregarSorteos(elResultado, elSorteoHistorico, elSorteo);



               Decimal TotalVendidoSorte = elClienteDeResulados.ObtenerElTotalVendidoEnUnSorteo(elResultado.IdSorteos);


               
                Decimal TotalPagadoAlNumeroDelPrimerLugar = elClienteDeResulados.ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(elResultado.IdSorteos, elResultado.PrimerLugar);
                Decimal TotalPagadoAlNumeroDelSegundoLugar = elClienteDeResulados.ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(elResultado.IdSorteos, elResultado.SegundoLugar);
                Decimal TotalPagadoAlNumeroDelTercerLugar = elClienteDeResulados.ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(elResultado.IdSorteos, elResultado.TercerLugar);

                Decimal TotalPagadoEnPremios = TotalPagadoAlNumeroDelPrimerLugar + TotalPagadoAlNumeroDelSegundoLugar + TotalPagadoAlNumeroDelTercerLugar;


                ViewBag.TotalPagadoPrimerNumero = TotalPagadoAlNumeroDelPrimerLugar.ToString();
                ViewBag.TotalPagadoSegundoNumero = TotalPagadoAlNumeroDelSegundoLugar.ToString();
                ViewBag.TotalPagadoTercerNumero = TotalPagadoAlNumeroDelTercerLugar.ToString();
                ViewBag.TotalPagadoEnPremios = TotalPagadoEnPremios.ToString();
                ViewBag.TotalVendido = TotalVendidoSorte.ToString();
               

                return View("Details");


                }
                catch
                {

                    return View();
                }
        }
          
    }
}
