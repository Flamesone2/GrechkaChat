﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrechkaChat.ServiceGrechkaChat {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceGrechkaChat.IServiceChat", CallbackContract=typeof(GrechkaChat.ServiceGrechkaChat.IServiceChatCallback))]
    public interface IServiceChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Connect", ReplyAction="http://tempuri.org/IServiceChat/ConnectResponse")]
        int Connect(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Connect", ReplyAction="http://tempuri.org/IServiceChat/ConnectResponse")]
        System.Threading.Tasks.Task<int> ConnectAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Disconnect", ReplyAction="http://tempuri.org/IServiceChat/DisconnectResponse")]
        void Disconnect(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/Disconnect", ReplyAction="http://tempuri.org/IServiceChat/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/SendMsg")]
        void SendMsg(string msg, int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/SendMsg")]
        System.Threading.Tasks.Task SendMsgAsync(string msg, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/AutorisationCheck", ReplyAction="http://tempuri.org/IServiceChat/AutorisationCheckResponse")]
        void AutorisationCheck(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/AutorisationCheck", ReplyAction="http://tempuri.org/IServiceChat/AutorisationCheckResponse")]
        System.Threading.Tasks.Task AutorisationCheckAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/RegistrationCheck", ReplyAction="http://tempuri.org/IServiceChat/RegistrationCheckResponse")]
        void RegistrationCheck(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/RegistrationCheck", ReplyAction="http://tempuri.org/IServiceChat/RegistrationCheckResponse")]
        System.Threading.Tasks.Task RegistrationCheckAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NumberOfUsers")]
        void NumberOfUsers();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NumberOfUsers")]
        System.Threading.Tasks.Task NumberOfUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/MsgCallback")]
        void MsgCallback(string msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/AutCallBack")]
        void AutCallBack(bool aut, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NumberOfUsersCallBack")]
        void NumberOfUsersCallBack();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatChannel : GrechkaChat.ServiceGrechkaChat.IServiceChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceChatClient : System.ServiceModel.DuplexClientBase<GrechkaChat.ServiceGrechkaChat.IServiceChat>, GrechkaChat.ServiceGrechkaChat.IServiceChat {
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Connect(string name) {
            return base.Channel.Connect(name);
        }
        
        public System.Threading.Tasks.Task<int> ConnectAsync(string name) {
            return base.Channel.ConnectAsync(name);
        }
        
        public void Disconnect(int id) {
            base.Channel.Disconnect(id);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(int id) {
            return base.Channel.DisconnectAsync(id);
        }
        
        public void SendMsg(string msg, int id) {
            base.Channel.SendMsg(msg, id);
        }
        
        public System.Threading.Tasks.Task SendMsgAsync(string msg, int id) {
            return base.Channel.SendMsgAsync(msg, id);
        }
        
        public void AutorisationCheck(string login, string password) {
            base.Channel.AutorisationCheck(login, password);
        }
        
        public System.Threading.Tasks.Task AutorisationCheckAsync(string login, string password) {
            return base.Channel.AutorisationCheckAsync(login, password);
        }
        
        public void RegistrationCheck(string login, string password) {
            base.Channel.RegistrationCheck(login, password);
        }
        
        public System.Threading.Tasks.Task RegistrationCheckAsync(string login, string password) {
            return base.Channel.RegistrationCheckAsync(login, password);
        }
        
        public void NumberOfUsers() {
            base.Channel.NumberOfUsers();
        }
        
        public System.Threading.Tasks.Task NumberOfUsersAsync() {
            return base.Channel.NumberOfUsersAsync();
        }
    }
}
