﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorDeSorteosEnLinea.ServicioDeResultadosDeSorteo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDeResultadosDeSorteo.IServicioDeResultadosDeSorteo")]
    public interface IServicioDeResultadosDeSorteo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ListarResultados", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ListarResultadosResponse")]
        GestorDeSorteosEnLinea.Model.Sorteos[] ListarResultados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ListarResultados", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ListarResultadosResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos[]> ListarResultadosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ConsultarUnResultado", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ConsultarUnResultadoResponse")]
        GestorDeSorteosEnLinea.Model.SorteosResultados ConsultarUnResultado(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ConsultarUnResultado", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ConsultarUnResultadoResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosResultados> ConsultarUnResultadoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteos", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteosResponse")]
        void AgregarSorteos(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, GestorDeSorteosEnLinea.Model.Sorteos elSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteos", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteosResponse")]
        System.Threading.Tasks.Task AgregarSorteosAsync(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, GestorDeSorteosEnLinea.Model.Sorteos elSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteosHistoricos", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteosHistoricosResponse" +
            "")]
        void AgregarSorteosHistoricos(GestorDeSorteosEnLinea.Model.SorteosHistorico SorteosHistorico, int elIdDelSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteosHistoricos", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/AgregarSorteosHistoricosResponse" +
            "")]
        System.Threading.Tasks.Task AgregarSorteosHistoricosAsync(GestorDeSorteosEnLinea.Model.SorteosHistorico SorteosHistorico, int elIdDelSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/CerrarUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/CerrarUnSorteoResponse")]
        void CerrarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/CerrarUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/CerrarUnSorteoResponse")]
        System.Threading.Tasks.Task CerrarUnSorteoAsync(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalVendidoEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalVendidoEnUnSorteoR" +
            "esponse")]
        decimal ObtenerElTotalVendidoEnUnSorteo(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalVendidoEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalVendidoEnUnSorteoR" +
            "esponse")]
        System.Threading.Tasks.Task<decimal> ObtenerElTotalVendidoEnUnSorteoAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlPrimerNume" +
            "roEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlPrimerNume" +
            "roEnUnSorteoResponse")]
        decimal ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(int id, int segundoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlPrimerNume" +
            "roEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlPrimerNume" +
            "roEnUnSorteoResponse")]
        System.Threading.Tasks.Task<decimal> ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteoAsync(int id, int segundoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlSegundoNum" +
            "eroEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlSegundoNum" +
            "eroEnUnSorteoResponse")]
        decimal ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(int id, int segundoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlSegundoNum" +
            "eroEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlSegundoNum" +
            "eroEnUnSorteoResponse")]
        System.Threading.Tasks.Task<decimal> ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteoAsync(int id, int segundoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlTercerNume" +
            "roEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlTercerNume" +
            "roEnUnSorteoResponse")]
        decimal ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(int id, int segundoNumero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlTercerNume" +
            "roEnUnSorteo", ReplyAction="http://tempuri.org/IServicioDeResultadosDeSorteo/ObtenerElTotalPagadoAlTercerNume" +
            "roEnUnSorteoResponse")]
        System.Threading.Tasks.Task<decimal> ObtenerElTotalPagadoAlTercerNumeroEnUnSorteoAsync(int id, int segundoNumero);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioDeResultadosDeSorteoChannel : GestorDeSorteosEnLinea.ServicioDeResultadosDeSorteo.IServicioDeResultadosDeSorteo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioDeResultadosDeSorteoClient : System.ServiceModel.ClientBase<GestorDeSorteosEnLinea.ServicioDeResultadosDeSorteo.IServicioDeResultadosDeSorteo>, GestorDeSorteosEnLinea.ServicioDeResultadosDeSorteo.IServicioDeResultadosDeSorteo {
        
        public ServicioDeResultadosDeSorteoClient() {
        }
        
        public ServicioDeResultadosDeSorteoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioDeResultadosDeSorteoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDeResultadosDeSorteoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDeResultadosDeSorteoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GestorDeSorteosEnLinea.Model.Sorteos[] ListarResultados() {
            return base.Channel.ListarResultados();
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos[]> ListarResultadosAsync() {
            return base.Channel.ListarResultadosAsync();
        }
        
        public GestorDeSorteosEnLinea.Model.SorteosResultados ConsultarUnResultado(int id) {
            return base.Channel.ConsultarUnResultado(id);
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosResultados> ConsultarUnResultadoAsync(int id) {
            return base.Channel.ConsultarUnResultadoAsync(id);
        }
        
        public void AgregarSorteos(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, GestorDeSorteosEnLinea.Model.Sorteos elSorteo) {
            base.Channel.AgregarSorteos(elResultado, elSorteoHistorico, elSorteo);
        }
        
        public System.Threading.Tasks.Task AgregarSorteosAsync(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, GestorDeSorteosEnLinea.Model.Sorteos elSorteo) {
            return base.Channel.AgregarSorteosAsync(elResultado, elSorteoHistorico, elSorteo);
        }
        
        public void AgregarSorteosHistoricos(GestorDeSorteosEnLinea.Model.SorteosHistorico SorteosHistorico, int elIdDelSorteo) {
            base.Channel.AgregarSorteosHistoricos(SorteosHistorico, elIdDelSorteo);
        }
        
        public System.Threading.Tasks.Task AgregarSorteosHistoricosAsync(GestorDeSorteosEnLinea.Model.SorteosHistorico SorteosHistorico, int elIdDelSorteo) {
            return base.Channel.AgregarSorteosHistoricosAsync(SorteosHistorico, elIdDelSorteo);
        }
        
        public void CerrarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico) {
            base.Channel.CerrarUnSorteo(elSorteo, elSorteoHistorico);
        }
        
        public System.Threading.Tasks.Task CerrarUnSorteoAsync(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico) {
            return base.Channel.CerrarUnSorteoAsync(elSorteo, elSorteoHistorico);
        }
        
        public decimal ObtenerElTotalVendidoEnUnSorteo(int Id) {
            return base.Channel.ObtenerElTotalVendidoEnUnSorteo(Id);
        }
        
        public System.Threading.Tasks.Task<decimal> ObtenerElTotalVendidoEnUnSorteoAsync(int Id) {
            return base.Channel.ObtenerElTotalVendidoEnUnSorteoAsync(Id);
        }
        
        public decimal ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(int id, int segundoNumero) {
            return base.Channel.ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(id, segundoNumero);
        }
        
        public System.Threading.Tasks.Task<decimal> ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteoAsync(int id, int segundoNumero) {
            return base.Channel.ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteoAsync(id, segundoNumero);
        }
        
        public decimal ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(int id, int segundoNumero) {
            return base.Channel.ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(id, segundoNumero);
        }
        
        public System.Threading.Tasks.Task<decimal> ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteoAsync(int id, int segundoNumero) {
            return base.Channel.ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteoAsync(id, segundoNumero);
        }
        
        public decimal ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(int id, int segundoNumero) {
            return base.Channel.ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(id, segundoNumero);
        }
        
        public System.Threading.Tasks.Task<decimal> ObtenerElTotalPagadoAlTercerNumeroEnUnSorteoAsync(int id, int segundoNumero) {
            return base.Channel.ObtenerElTotalPagadoAlTercerNumeroEnUnSorteoAsync(id, segundoNumero);
        }
    }
}
