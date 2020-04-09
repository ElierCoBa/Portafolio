﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace GestorDeSorteosEnLinea.Controllers
{
    [Authorize]
    public class SorteosController : Controller
    {


        public ActionResult Index()
        {

            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();

            var laListaDeSorteos = elClienteDeServiciosDeSorteos.ListarSorteos();
            return View(laListaDeSorteos);
        }
       

        public ActionResult Details(Model.Sorteos elSorteo)
        {


            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
            var laListaDeSorteosHistoricos = elClienteDeServiciosDeSorteos.ListarSorteosHistoricos(elSorteo.Id);
            var elSorteoAConsultar = elClienteDeServiciosDeSorteos.ConsultarUnSorteo(elSorteo.Id);
            ViewData["FechaDeSorteo"] = elSorteoAConsultar.Fecha.ToString("dd/MM/yyyy");
            ViewData["EstadoSorteo"] = elSorteoAConsultar.Estado;
            return View(laListaDeSorteosHistoricos);
        }



       
   
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {
            if (elSorteo.Fecha >= DateTime.Now)
            {

                try
                {

                    ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
                    elSorteo.Estado = Model.Estados.Activo;
                    elSorteoHistorico.TipoDeModificacion = Model.TipoDeModificacion.Insercion;
                    elSorteoHistorico.Id_AspNetUser = User.Identity.GetUserId();
                    elClienteDeServiciosDeSorteos.AgregarSorteos(elSorteo, elSorteoHistorico);

                    return RedirectToAction("Index");
                }
                catch
                {

                    return View();
                }
            }
            else
            {
                ViewData["elMensajeDeError"] = "La fecha debe ser mayor o igual a la fecha actual";
                return View();

            }
        }

   
        public ActionResult DesactivarUnSorteo(int Id)
        {
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
            var elSorteoConsultado = elClienteDeServiciosDeSorteos.ConsultarUnSorteo(Id);

            return View(elSorteoConsultado);
        }

      
        [HttpPost]
        public ActionResult DesactivarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {
            string laDescripcionDeLaModificacion = "";
            laDescripcionDeLaModificacion = Request.Form["DescripcionDeLaModificacion"];

            if (laDescripcionDeLaModificacion != "")
            {
                try
                {
            
                    ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
                    elSorteo.Estado = Model.Estados.Inactivo;
                    elSorteoHistorico.TipoDeModificacion = Model.TipoDeModificacion.Inactivacion;
                    elSorteoHistorico.Id_AspNetUser = User.Identity.GetUserId();
                    elClienteDeServiciosDeSorteos.InactivarUnSorteo(elSorteo, elSorteoHistorico, laDescripcionDeLaModificacion);
                    return RedirectToAction("Index");
                }
                catch
                {

                    return View();
                }
            }
            else
            {
                ViewData["elMensajeDeError"] = "La descripición de la modificación es requerida";
                return View();

            }
        }

 
        public ActionResult ActivarUnSorteo(int Id)
        {
            ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
            var elSorteoConsultado = elClienteDeServiciosDeSorteos.ConsultarUnSorteo(Id);

            return View(elSorteoConsultado);
        }

        // POST: Sorteos/Delete/5
        [HttpPost]
        public ActionResult ActivarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {
            string laDescripcionDeLaModificacion = "";
            laDescripcionDeLaModificacion = Request.Form["DescripcionDeLaModificacion"];

            if (laDescripcionDeLaModificacion != "")
            {
                try
                {

                    ServicioDeSorteos.ServicioDeSorteosClient elClienteDeServiciosDeSorteos = new ServicioDeSorteos.ServicioDeSorteosClient();
                    elSorteo.Estado = Model.Estados.Activo;
                    elSorteoHistorico.TipoDeModificacion = Model.TipoDeModificacion.Activacion;
                    elSorteoHistorico.Id_AspNetUser = User.Identity.GetUserId();
                    elClienteDeServiciosDeSorteos.ActivarUnSorteo(elSorteo, elSorteoHistorico, laDescripcionDeLaModificacion);


                    return RedirectToAction("Index");
                }
                catch
                {

                return View();

                }
            }
            else
            {
                ViewData["elMensajeDeError"] = "La descripición de la modificación es requerida";
                return View();

            }
        }
    }
}