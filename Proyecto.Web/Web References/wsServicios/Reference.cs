﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Proyecto.Web.wsServicios {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsServiciosSoap", Namespace="http://tempuri.org/")]
    public partial class wsServicios : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getEventos_JsonOperationCompleted;
        
        private System.Threading.SendOrPostCallback getEventos_XMLOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsServicios() {
            this.Url = global::Proyecto.Web.Properties.Settings.Default.Proyecto_Web_wsServicios_wsServicios;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getEventos_JsonCompletedEventHandler getEventos_JsonCompleted;
        
        /// <remarks/>
        public event getEventos_XMLCompletedEventHandler getEventos_XMLCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEventos_Json", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getEventos_Json() {
            object[] results = this.Invoke("getEventos_Json", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getEventos_JsonAsync() {
            this.getEventos_JsonAsync(null);
        }
        
        /// <remarks/>
        public void getEventos_JsonAsync(object userState) {
            if ((this.getEventos_JsonOperationCompleted == null)) {
                this.getEventos_JsonOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEventos_JsonOperationCompleted);
            }
            this.InvokeAsync("getEventos_Json", new object[0], this.getEventos_JsonOperationCompleted, userState);
        }
        
        private void OngetEventos_JsonOperationCompleted(object arg) {
            if ((this.getEventos_JsonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEventos_JsonCompleted(this, new getEventos_JsonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEventos_XML", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public clsEventos[] getEventos_XML() {
            object[] results = this.Invoke("getEventos_XML", new object[0]);
            return ((clsEventos[])(results[0]));
        }
        
        /// <remarks/>
        public void getEventos_XMLAsync() {
            this.getEventos_XMLAsync(null);
        }
        
        /// <remarks/>
        public void getEventos_XMLAsync(object userState) {
            if ((this.getEventos_XMLOperationCompleted == null)) {
                this.getEventos_XMLOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEventos_XMLOperationCompleted);
            }
            this.InvokeAsync("getEventos_XML", new object[0], this.getEventos_XMLOperationCompleted, userState);
        }
        
        private void OngetEventos_XMLOperationCompleted(object arg) {
            if ((this.getEventos_XMLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEventos_XMLCompleted(this, new getEventos_XMLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clsEventos {
        
        private int cODIGOField;
        
        private string nOMBREField;
        
        private string uBICACIONField;
        
        private string pARTICIPANTESField;
        
        private string tODO_DIAField;
        
        private string fECHAField;
        
        private clsRelacionadoCon rELACIONADO_CONField;
        
        private string dESCRIPCIONField;
        
        /// <remarks/>
        public int CODIGO {
            get {
                return this.cODIGOField;
            }
            set {
                this.cODIGOField = value;
            }
        }
        
        /// <remarks/>
        public string NOMBRE {
            get {
                return this.nOMBREField;
            }
            set {
                this.nOMBREField = value;
            }
        }
        
        /// <remarks/>
        public string UBICACION {
            get {
                return this.uBICACIONField;
            }
            set {
                this.uBICACIONField = value;
            }
        }
        
        /// <remarks/>
        public string PARTICIPANTES {
            get {
                return this.pARTICIPANTESField;
            }
            set {
                this.pARTICIPANTESField = value;
            }
        }
        
        /// <remarks/>
        public string TODO_DIA {
            get {
                return this.tODO_DIAField;
            }
            set {
                this.tODO_DIAField = value;
            }
        }
        
        /// <remarks/>
        public string FECHA {
            get {
                return this.fECHAField;
            }
            set {
                this.fECHAField = value;
            }
        }
        
        /// <remarks/>
        public clsRelacionadoCon RELACIONADO_CON {
            get {
                return this.rELACIONADO_CONField;
            }
            set {
                this.rELACIONADO_CONField = value;
            }
        }
        
        /// <remarks/>
        public string DESCRIPCION {
            get {
                return this.dESCRIPCIONField;
            }
            set {
                this.dESCRIPCIONField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clsRelacionadoCon {
        
        private int cODIGOField;
        
        private string dESCRIPCIONField;
        
        /// <remarks/>
        public int CODIGO {
            get {
                return this.cODIGOField;
            }
            set {
                this.cODIGOField = value;
            }
        }
        
        /// <remarks/>
        public string DESCRIPCION {
            get {
                return this.dESCRIPCIONField;
            }
            set {
                this.dESCRIPCIONField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getEventos_JsonCompletedEventHandler(object sender, getEventos_JsonCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEventos_JsonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEventos_JsonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getEventos_XMLCompletedEventHandler(object sender, getEventos_XMLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEventos_XMLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEventos_XMLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public clsEventos[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((clsEventos[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591