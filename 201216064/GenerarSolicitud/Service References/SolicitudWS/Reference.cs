﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerarSolicitud.SolicitudWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Solicitud", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Solicitud : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codProyectoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GenerarSolicitud.SolicitudWS.SolicitudDetalle[] detalleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codProyecto {
            get {
                return this.codProyectoField;
            }
            set {
                if ((this.codProyectoField.Equals(value) != true)) {
                    this.codProyectoField = value;
                    this.RaisePropertyChanged("codProyecto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GenerarSolicitud.SolicitudWS.SolicitudDetalle[] detalle {
            get {
                return this.detalleField;
            }
            set {
                if ((object.ReferenceEquals(this.detalleField, value) != true)) {
                    this.detalleField = value;
                    this.RaisePropertyChanged("detalle");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SolicitudDetalle", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
    [System.SerializableAttribute()]
    public partial class SolicitudDetalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadColaborField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComentarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codExperienciaRubroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codPerfilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codTecnologiaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadColabor {
            get {
                return this.CantidadColaborField;
            }
            set {
                if ((this.CantidadColaborField.Equals(value) != true)) {
                    this.CantidadColaborField = value;
                    this.RaisePropertyChanged("CantidadColabor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comentario {
            get {
                return this.ComentarioField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentarioField, value) != true)) {
                    this.ComentarioField = value;
                    this.RaisePropertyChanged("Comentario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codExperienciaRubro {
            get {
                return this.codExperienciaRubroField;
            }
            set {
                if ((object.ReferenceEquals(this.codExperienciaRubroField, value) != true)) {
                    this.codExperienciaRubroField = value;
                    this.RaisePropertyChanged("codExperienciaRubro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codPerfil {
            get {
                return this.codPerfilField;
            }
            set {
                if ((object.ReferenceEquals(this.codPerfilField, value) != true)) {
                    this.codPerfilField = value;
                    this.RaisePropertyChanged("codPerfil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codTecnologia {
            get {
                return this.codTecnologiaField;
            }
            set {
                if ((object.ReferenceEquals(this.codTecnologiaField, value) != true)) {
                    this.codTecnologiaField = value;
                    this.RaisePropertyChanged("codTecnologia");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
    [System.SerializableAttribute()]
    public partial class MyExcepcion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MesssageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Messsage {
            get {
                return this.MesssageField;
            }
            set {
                if ((object.ReferenceEquals(this.MesssageField, value) != true)) {
                    this.MesssageField = value;
                    this.RaisePropertyChanged("Messsage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RazonSocialClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RucClienteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodCliente {
            get {
                return this.CodClienteField;
            }
            set {
                if ((this.CodClienteField.Equals(value) != true)) {
                    this.CodClienteField = value;
                    this.RaisePropertyChanged("CodCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazonSocialCliente {
            get {
                return this.RazonSocialClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.RazonSocialClienteField, value) != true)) {
                    this.RazonSocialClienteField = value;
                    this.RaisePropertyChanged("RazonSocialCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RucCliente {
            get {
                return this.RucClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.RucClienteField, value) != true)) {
                    this.RucClienteField = value;
                    this.RaisePropertyChanged("RucCliente");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Proyecto", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Proyecto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GenerarSolicitud.SolicitudWS.Cliente ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodProyectoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreProyectoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GenerarSolicitud.SolicitudWS.Cliente Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodProyecto {
            get {
                return this.CodProyectoField;
            }
            set {
                if ((this.CodProyectoField.Equals(value) != true)) {
                    this.CodProyectoField = value;
                    this.RaisePropertyChanged("CodProyecto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProyecto {
            get {
                return this.NombreProyectoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreProyectoField, value) != true)) {
                    this.NombreProyectoField = value;
                    this.RaisePropertyChanged("NombreProyecto");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SolicitudWS.ISolicitudes")]
    public interface ISolicitudes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/CrearSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/CrearSolicitudResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/CrearSolicitudMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.Solicitud CrearSolicitud(int codProyecto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/CrearSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/CrearSolicitudResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud> CrearSolicitudAsync(int codProyecto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/CrearSolicitudDetalle", ReplyAction="http://tempuri.org/ISolicitudes/CrearSolicitudDetalleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/CrearSolicitudDetalleMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.SolicitudDetalle CrearSolicitudDetalle(int codigo, int cantidadColabor, string codPerfil, string codTecnologia, string codExperienciaRubro, string comentario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/CrearSolicitudDetalle", ReplyAction="http://tempuri.org/ISolicitudes/CrearSolicitudDetalleResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.SolicitudDetalle> CrearSolicitudDetalleAsync(int codigo, int cantidadColabor, string codPerfil, string codTecnologia, string codExperienciaRubro, string comentario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ObtenerSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/ObtenerSolicitudResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/ObtenerSolicitudMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.Solicitud ObtenerSolicitud(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ObtenerSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/ObtenerSolicitudResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud> ObtenerSolicitudAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ObtenerCliente", ReplyAction="http://tempuri.org/ISolicitudes/ObtenerClienteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/ObtenerClienteMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.Cliente ObtenerCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ObtenerCliente", ReplyAction="http://tempuri.org/ISolicitudes/ObtenerClienteResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Cliente> ObtenerClienteAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ObtenerProyecto", ReplyAction="http://tempuri.org/ISolicitudes/ObtenerProyectoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/ObtenerProyectoMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.Proyecto ObtenerProyecto(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ObtenerProyecto", ReplyAction="http://tempuri.org/ISolicitudes/ObtenerProyectoResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Proyecto> ObtenerProyectoAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ModificarSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/ModificarSolicitudResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/ModificarSolicitudMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.Solicitud ModificarSolicitud(int codigo, int codProyecto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ModificarSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/ModificarSolicitudResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud> ModificarSolicitudAsync(int codigo, int codProyecto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/EliminarSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/EliminarSolicitudResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/EliminarSolicitudMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        void EliminarSolicitud(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/EliminarSolicitud", ReplyAction="http://tempuri.org/ISolicitudes/EliminarSolicitudResponse")]
        System.Threading.Tasks.Task EliminarSolicitudAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ListarSolicitudes", ReplyAction="http://tempuri.org/ISolicitudes/ListarSolicitudesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GenerarSolicitud.SolicitudWS.MyExcepcion), Action="http://tempuri.org/ISolicitudes/ListarSolicitudesMyExcepcionFault", Name="MyExcepcion", Namespace="http://schemas.datacontract.org/2004/07/SolicitudService.Dominio")]
        GenerarSolicitud.SolicitudWS.Solicitud[] ListarSolicitudes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudes/ListarSolicitudes", ReplyAction="http://tempuri.org/ISolicitudes/ListarSolicitudesResponse")]
        System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud[]> ListarSolicitudesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISolicitudesChannel : GenerarSolicitud.SolicitudWS.ISolicitudes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SolicitudesClient : System.ServiceModel.ClientBase<GenerarSolicitud.SolicitudWS.ISolicitudes>, GenerarSolicitud.SolicitudWS.ISolicitudes {
        
        public SolicitudesClient() {
        }
        
        public SolicitudesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SolicitudesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolicitudesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolicitudesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GenerarSolicitud.SolicitudWS.Solicitud CrearSolicitud(int codProyecto) {
            return base.Channel.CrearSolicitud(codProyecto);
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud> CrearSolicitudAsync(int codProyecto) {
            return base.Channel.CrearSolicitudAsync(codProyecto);
        }
        
        public GenerarSolicitud.SolicitudWS.SolicitudDetalle CrearSolicitudDetalle(int codigo, int cantidadColabor, string codPerfil, string codTecnologia, string codExperienciaRubro, string comentario) {
            return base.Channel.CrearSolicitudDetalle(codigo, cantidadColabor, codPerfil, codTecnologia, codExperienciaRubro, comentario);
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.SolicitudDetalle> CrearSolicitudDetalleAsync(int codigo, int cantidadColabor, string codPerfil, string codTecnologia, string codExperienciaRubro, string comentario) {
            return base.Channel.CrearSolicitudDetalleAsync(codigo, cantidadColabor, codPerfil, codTecnologia, codExperienciaRubro, comentario);
        }
        
        public GenerarSolicitud.SolicitudWS.Solicitud ObtenerSolicitud(int codigo) {
            return base.Channel.ObtenerSolicitud(codigo);
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud> ObtenerSolicitudAsync(int codigo) {
            return base.Channel.ObtenerSolicitudAsync(codigo);
        }
        
        public GenerarSolicitud.SolicitudWS.Cliente ObtenerCliente(int codigo) {
            return base.Channel.ObtenerCliente(codigo);
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Cliente> ObtenerClienteAsync(int codigo) {
            return base.Channel.ObtenerClienteAsync(codigo);
        }
        
        public GenerarSolicitud.SolicitudWS.Proyecto ObtenerProyecto(int codigo) {
            return base.Channel.ObtenerProyecto(codigo);
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Proyecto> ObtenerProyectoAsync(int codigo) {
            return base.Channel.ObtenerProyectoAsync(codigo);
        }
        
        public GenerarSolicitud.SolicitudWS.Solicitud ModificarSolicitud(int codigo, int codProyecto) {
            return base.Channel.ModificarSolicitud(codigo, codProyecto);
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud> ModificarSolicitudAsync(int codigo, int codProyecto) {
            return base.Channel.ModificarSolicitudAsync(codigo, codProyecto);
        }
        
        public void EliminarSolicitud(int codigo) {
            base.Channel.EliminarSolicitud(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarSolicitudAsync(int codigo) {
            return base.Channel.EliminarSolicitudAsync(codigo);
        }
        
        public GenerarSolicitud.SolicitudWS.Solicitud[] ListarSolicitudes() {
            return base.Channel.ListarSolicitudes();
        }
        
        public System.Threading.Tasks.Task<GenerarSolicitud.SolicitudWS.Solicitud[]> ListarSolicitudesAsync() {
            return base.Channel.ListarSolicitudesAsync();
        }
    }
}
