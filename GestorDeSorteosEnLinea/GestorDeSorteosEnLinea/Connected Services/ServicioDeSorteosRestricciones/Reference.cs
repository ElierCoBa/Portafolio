﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorDeSorteosEnLinea.ServicioDeSorteosRestricciones {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDeSorteosRestricciones.IServiciosDeSorteosRestricciones")]
    public interface IServiciosDeSorteosRestricciones {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarSorteos", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarSorteosResponse")]
        GestorDeSorteosEnLinea.Model.Sorteos[] ListarSorteos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarSorteos", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarSorteosResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos[]> ListarSorteosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteosConRestricc" +
            "iones", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteosConRestricc" +
            "ionesResponse")]
        GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteosConRestricciones(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteosConRestricc" +
            "iones", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteosConRestricc" +
            "ionesResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones> ConsultarUnSorteosConRestriccionesAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarFechaDeunSorteo", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarFechaDeunSorteoRespo" +
            "nse")]
        string ConsultarFechaDeunSorteo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarFechaDeunSorteo", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarFechaDeunSorteoRespo" +
            "nse")]
        System.Threading.Tasks.Task<string> ConsultarFechaDeunSorteoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/CrearUnSorteoRestriccion", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/CrearUnSorteoRestriccionRespo" +
            "nse")]
        void CrearUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/CrearUnSorteoRestriccion", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/CrearUnSorteoRestriccionRespo" +
            "nse")]
        System.Threading.Tasks.Task CrearUnSorteoRestriccionAsync(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/EditarUnSorteoRestriccion", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/EditarUnSorteoRestriccionResp" +
            "onse")]
        void EditarUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/EditarUnSorteoRestriccion", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/EditarUnSorteoRestriccionResp" +
            "onse")]
        System.Threading.Tasks.Task EditarUnSorteoRestriccionAsync(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarRestriccionDeSorteo", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarRestriccionDeSorteoResp" +
            "onse")]
        GestorDeSorteosEnLinea.Model.SorteosRestricciones[] ListarRestriccionDeSorteo(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarRestriccionDeSorteo", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ListarRestriccionDeSorteoResp" +
            "onse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones[]> ListarRestriccionDeSorteoAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarNumeroDeunSorteoRest" +
            "ricciones", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarNumeroDeunSorteoRest" +
            "riccionesResponse")]
        int ConsultarNumeroDeunSorteoRestricciones(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarNumeroDeunSorteoRest" +
            "ricciones", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarNumeroDeunSorteoRest" +
            "riccionesResponse")]
        System.Threading.Tasks.Task<int> ConsultarNumeroDeunSorteoRestriccionesAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ComprobarSiExisteElSorteoConR" +
            "estriccion", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ComprobarSiExisteElSorteoConR" +
            "estriccionResponse")]
        bool ComprobarSiExisteElSorteoConRestriccion(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ComprobarSiExisteElSorteoConR" +
            "estriccion", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ComprobarSiExisteElSorteoConR" +
            "estriccionResponse")]
        System.Threading.Tasks.Task<bool> ComprobarSiExisteElSorteoConRestriccionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/PoseeRestriccionElSorteoSelec" +
            "cionado", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/PoseeRestriccionElSorteoSelec" +
            "cionadoResponse")]
        bool PoseeRestriccionElSorteoSeleccionado(int Numero, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/PoseeRestriccionElSorteoSelec" +
            "cionado", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/PoseeRestriccionElSorteoSelec" +
            "cionadoResponse")]
        System.Threading.Tasks.Task<bool> PoseeRestriccionElSorteoSeleccionadoAsync(int Numero, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteoConRestricci" +
            "onPorId", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteoConRestricci" +
            "onPorIdResponse")]
        GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteoConRestriccionPorId(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteoConRestricci" +
            "onPorId", ReplyAction="http://tempuri.org/IServiciosDeSorteosRestricciones/ConsultarUnSorteoConRestricci" +
            "onPorIdResponse")]
        System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones> ConsultarUnSorteoConRestriccionPorIdAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiciosDeSorteosRestriccionesChannel : GestorDeSorteosEnLinea.ServicioDeSorteosRestricciones.IServiciosDeSorteosRestricciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosDeSorteosRestriccionesClient : System.ServiceModel.ClientBase<GestorDeSorteosEnLinea.ServicioDeSorteosRestricciones.IServiciosDeSorteosRestricciones>, GestorDeSorteosEnLinea.ServicioDeSorteosRestricciones.IServiciosDeSorteosRestricciones {
        
        public ServiciosDeSorteosRestriccionesClient() {
        }
        
        public ServiciosDeSorteosRestriccionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosDeSorteosRestriccionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosDeSorteosRestriccionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosDeSorteosRestriccionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GestorDeSorteosEnLinea.Model.Sorteos[] ListarSorteos() {
            return base.Channel.ListarSorteos();
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.Sorteos[]> ListarSorteosAsync() {
            return base.Channel.ListarSorteosAsync();
        }
        
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteosConRestricciones(int id) {
            return base.Channel.ConsultarUnSorteosConRestricciones(id);
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones> ConsultarUnSorteosConRestriccionesAsync(int id) {
            return base.Channel.ConsultarUnSorteosConRestriccionesAsync(id);
        }
        
        public string ConsultarFechaDeunSorteo(int id) {
            return base.Channel.ConsultarFechaDeunSorteo(id);
        }
        
        public System.Threading.Tasks.Task<string> ConsultarFechaDeunSorteoAsync(int id) {
            return base.Channel.ConsultarFechaDeunSorteoAsync(id);
        }
        
        public void CrearUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo) {
            base.Channel.CrearUnSorteoRestriccion(elSorteo);
        }
        
        public System.Threading.Tasks.Task CrearUnSorteoRestriccionAsync(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo) {
            return base.Channel.CrearUnSorteoRestriccionAsync(elSorteo);
        }
        
        public void EditarUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo) {
            base.Channel.EditarUnSorteoRestriccion(elSorteo);
        }
        
        public System.Threading.Tasks.Task EditarUnSorteoRestriccionAsync(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo) {
            return base.Channel.EditarUnSorteoRestriccionAsync(elSorteo);
        }
        
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones[] ListarRestriccionDeSorteo(int Id) {
            return base.Channel.ListarRestriccionDeSorteo(Id);
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones[]> ListarRestriccionDeSorteoAsync(int Id) {
            return base.Channel.ListarRestriccionDeSorteoAsync(Id);
        }
        
        public int ConsultarNumeroDeunSorteoRestricciones(int id) {
            return base.Channel.ConsultarNumeroDeunSorteoRestricciones(id);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarNumeroDeunSorteoRestriccionesAsync(int id) {
            return base.Channel.ConsultarNumeroDeunSorteoRestriccionesAsync(id);
        }
        
        public bool ComprobarSiExisteElSorteoConRestriccion(int id) {
            return base.Channel.ComprobarSiExisteElSorteoConRestriccion(id);
        }
        
        public System.Threading.Tasks.Task<bool> ComprobarSiExisteElSorteoConRestriccionAsync(int id) {
            return base.Channel.ComprobarSiExisteElSorteoConRestriccionAsync(id);
        }
        
        public bool PoseeRestriccionElSorteoSeleccionado(int Numero, int Id) {
            return base.Channel.PoseeRestriccionElSorteoSeleccionado(Numero, Id);
        }
        
        public System.Threading.Tasks.Task<bool> PoseeRestriccionElSorteoSeleccionadoAsync(int Numero, int Id) {
            return base.Channel.PoseeRestriccionElSorteoSeleccionadoAsync(Numero, Id);
        }
        
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteoConRestriccionPorId(int Id) {
            return base.Channel.ConsultarUnSorteoConRestriccionPorId(Id);
        }
        
        public System.Threading.Tasks.Task<GestorDeSorteosEnLinea.Model.SorteosRestricciones> ConsultarUnSorteoConRestriccionPorIdAsync(int Id) {
            return base.Channel.ConsultarUnSorteoConRestriccionPorIdAsync(Id);
        }
    }
}