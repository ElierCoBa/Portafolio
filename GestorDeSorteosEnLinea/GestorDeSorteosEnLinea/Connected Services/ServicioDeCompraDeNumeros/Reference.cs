﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorDeSorteosEnLinea.ServicioDeCompraDeNumeros {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDeCompraDeNumeros.IServicioDeCompraDeNumeros")]
    public interface IServicioDeCompraDeNumeros {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/ListarSorteosActivosVigentes", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/ListarSorteosActivosVigentesRespons" +
            "e")]
        GestorDeSorteosEnLinea.Model.Sorteos[] ListarSorteosActivosVigentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/ListarSorteosActivosVigentes", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/ListarSorteosActivosVigentesRespons" +
            "e")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos[]> ListarSorteosActivosVigentesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarUnSorteo", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarUnSorteoResponse")]
        GestorDeSorteosEnLinea.Model.Sorteos ConsultarUnSorteo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarUnSorteo", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarUnSorteoResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos> ConsultarUnSorteoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/AgregarDetalleVenta", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/AgregarDetalleVentaResponse")]
        void AgregarDetalleVenta(GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, decimal elMontoDelNumeroComprado, int elIdDelSorteo, System.Nullable<System.DateTime> laFechaDelSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/AgregarDetalleVenta", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/AgregarDetalleVentaResponse")]
        System.Threading.Tasks.Task AgregarDetalleVentaAsync(GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, decimal elMontoDelNumeroComprado, int elIdDelSorteo, System.Nullable<System.DateTime> laFechaDelSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarMontoAcumuladoRestriccion", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarMontoAcumuladoRestriccionR" +
            "esponse")]
        decimal ConsultarMontoAcumuladoRestriccion(int Numero, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarMontoAcumuladoRestriccion", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/ConsultarMontoAcumuladoRestriccionR" +
            "esponse")]
        System.Threading.Tasks.Task<decimal> ConsultarMontoAcumuladoRestriccionAsync(int Numero, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/PoseeRestriccionElSorteoSeleccionad" +
            "o", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/PoseeRestriccionElSorteoSeleccionad" +
            "oResponse")]
        GestorDeSorteosEnLinea.Model.SorteosRestricciones PoseeRestriccionElSorteoSeleccionado(int Numero, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeCompraDeNumeros/PoseeRestriccionElSorteoSeleccionad" +
            "o", ReplyAction="http://tempuri.org/IServicioDeCompraDeNumeros/PoseeRestriccionElSorteoSeleccionad" +
            "oResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones> PoseeRestriccionElSorteoSeleccionadoAsync(int Numero, int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioDeCompraDeNumerosChannel : GestorDeSorteosEnLinea.ServicioDeCompraDeNumeros.IServicioDeCompraDeNumeros, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioDeCompraDeNumerosClient : System.ServiceModel.ClientBase<GestorDeSorteosEnLinea.ServicioDeCompraDeNumeros.IServicioDeCompraDeNumeros>, GestorDeSorteosEnLinea.ServicioDeCompraDeNumeros.IServicioDeCompraDeNumeros {
        
        public ServicioDeCompraDeNumerosClient() {
        }
        
        public ServicioDeCompraDeNumerosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioDeCompraDeNumerosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDeCompraDeNumerosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDeCompraDeNumerosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GestorDeSorteosEnLinea.Model.Sorteos[] ListarSorteosActivosVigentes() {
            return base.Channel.ListarSorteosActivosVigentes();
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos[]> ListarSorteosActivosVigentesAsync() {
            return base.Channel.ListarSorteosActivosVigentesAsync();
        }
        
        public GestorDeSorteosEnLinea.Model.Sorteos ConsultarUnSorteo(int id) {
            return base.Channel.ConsultarUnSorteo(id);
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos> ConsultarUnSorteoAsync(int id) {
            return base.Channel.ConsultarUnSorteoAsync(id);
        }
        
        public void AgregarDetalleVenta(GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, decimal elMontoDelNumeroComprado, int elIdDelSorteo, System.Nullable<System.DateTime> laFechaDelSorteo) {
            base.Channel.AgregarDetalleVenta(elDetalleDeLaVenta, elNumeroComprado, elMontoDelNumeroComprado, elIdDelSorteo, laFechaDelSorteo);
        }
        
        public System.Threading.Tasks.Task AgregarDetalleVentaAsync(GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, decimal elMontoDelNumeroComprado, int elIdDelSorteo, System.Nullable<System.DateTime> laFechaDelSorteo) {
            return base.Channel.AgregarDetalleVentaAsync(elDetalleDeLaVenta, elNumeroComprado, elMontoDelNumeroComprado, elIdDelSorteo, laFechaDelSorteo);
        }
        
        public decimal ConsultarMontoAcumuladoRestriccion(int Numero, int Id) {
            return base.Channel.ConsultarMontoAcumuladoRestriccion(Numero, Id);
        }
        
        public System.Threading.Tasks.Task<decimal> ConsultarMontoAcumuladoRestriccionAsync(int Numero, int Id) {
            return base.Channel.ConsultarMontoAcumuladoRestriccionAsync(Numero, Id);
        }
        
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones PoseeRestriccionElSorteoSeleccionado(int Numero, int Id) {
            return base.Channel.PoseeRestriccionElSorteoSeleccionado(Numero, Id);
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones> PoseeRestriccionElSorteoSeleccionadoAsync(int Numero, int Id) {
            return base.Channel.PoseeRestriccionElSorteoSeleccionadoAsync(Numero, Id);
        }
    }
}