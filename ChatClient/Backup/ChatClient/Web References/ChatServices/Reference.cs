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

namespace ChatClient.ChatServices {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ChatServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ChatService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetUsersOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback RemoveUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReceiveMessageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ChatService() {
            this.Url = global::ChatClient.Properties.Settings.Default.DDATalk_ChatServices_ChatService;
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
        public event GetUsersCompletedEventHandler GetUsersCompleted;
        
        /// <remarks/>
        public event AddUserCompletedEventHandler AddUserCompleted;
        
        /// <remarks/>
        public event RemoveUserCompletedEventHandler RemoveUserCompleted;
        
        /// <remarks/>
        public event SendMessageCompletedEventHandler SendMessageCompleted;
        
        /// <remarks/>
        public event ReceiveMessageCompletedEventHandler ReceiveMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUsers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUsers() {
            object[] results = this.Invoke("GetUsers", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetUsersAsync() {
            this.GetUsersAsync(null);
        }
        
        /// <remarks/>
        public void GetUsersAsync(object userState) {
            if ((this.GetUsersOperationCompleted == null)) {
                this.GetUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUsersOperationCompleted);
            }
            this.InvokeAsync("GetUsers", new object[0], this.GetUsersOperationCompleted, userState);
        }
        
        private void OnGetUsersOperationCompleted(object arg) {
            if ((this.GetUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUsersCompleted(this, new GetUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddUser(string strUser) {
            this.Invoke("AddUser", new object[] {
                        strUser});
        }
        
        /// <remarks/>
        public void AddUserAsync(string strUser) {
            this.AddUserAsync(strUser, null);
        }
        
        /// <remarks/>
        public void AddUserAsync(string strUser, object userState) {
            if ((this.AddUserOperationCompleted == null)) {
                this.AddUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddUserOperationCompleted);
            }
            this.InvokeAsync("AddUser", new object[] {
                        strUser}, this.AddUserOperationCompleted, userState);
        }
        
        private void OnAddUserOperationCompleted(object arg) {
            if ((this.AddUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RemoveUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RemoveUser(string strUser) {
            this.Invoke("RemoveUser", new object[] {
                        strUser});
        }
        
        /// <remarks/>
        public void RemoveUserAsync(string strUser) {
            this.RemoveUserAsync(strUser, null);
        }
        
        /// <remarks/>
        public void RemoveUserAsync(string strUser, object userState) {
            if ((this.RemoveUserOperationCompleted == null)) {
                this.RemoveUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRemoveUserOperationCompleted);
            }
            this.InvokeAsync("RemoveUser", new object[] {
                        strUser}, this.RemoveUserOperationCompleted, userState);
        }
        
        private void OnRemoveUserOperationCompleted(object arg) {
            if ((this.RemoveUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RemoveUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendMessage(string strFromUser, string strToUser, string strMess) {
            this.Invoke("SendMessage", new object[] {
                        strFromUser,
                        strToUser,
                        strMess});
        }
        
        /// <remarks/>
        public void SendMessageAsync(string strFromUser, string strToUser, string strMess) {
            this.SendMessageAsync(strFromUser, strToUser, strMess, null);
        }
        
        /// <remarks/>
        public void SendMessageAsync(string strFromUser, string strToUser, string strMess, object userState) {
            if ((this.SendMessageOperationCompleted == null)) {
                this.SendMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMessageOperationCompleted);
            }
            this.InvokeAsync("SendMessage", new object[] {
                        strFromUser,
                        strToUser,
                        strMess}, this.SendMessageOperationCompleted, userState);
        }
        
        private void OnSendMessageOperationCompleted(object arg) {
            if ((this.SendMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ReceiveMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ReceiveMessage(string strUser) {
            object[] results = this.Invoke("ReceiveMessage", new object[] {
                        strUser});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ReceiveMessageAsync(string strUser) {
            this.ReceiveMessageAsync(strUser, null);
        }
        
        /// <remarks/>
        public void ReceiveMessageAsync(string strUser, object userState) {
            if ((this.ReceiveMessageOperationCompleted == null)) {
                this.ReceiveMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReceiveMessageOperationCompleted);
            }
            this.InvokeAsync("ReceiveMessage", new object[] {
                        strUser}, this.ReceiveMessageOperationCompleted, userState);
        }
        
        private void OnReceiveMessageOperationCompleted(object arg) {
            if ((this.ReceiveMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReceiveMessageCompleted(this, new ReceiveMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetUsersCompletedEventHandler(object sender, GetUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void AddUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void RemoveUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SendMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ReceiveMessageCompletedEventHandler(object sender, ReceiveMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReceiveMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReceiveMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591