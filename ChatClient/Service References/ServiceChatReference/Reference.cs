﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatClient.ServiceChatReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceChat")]
    [System.SerializableAttribute()]
    public partial class UserType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BlockedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public bool Blocked {
            get {
                return this.BlockedField;
            }
            set {
                if ((this.BlockedField.Equals(value) != true)) {
                    this.BlockedField = value;
                    this.RaisePropertyChanged("Blocked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Online {
            get {
                return this.OnlineField;
            }
            set {
                if ((this.OnlineField.Equals(value) != true)) {
                    this.OnlineField = value;
                    this.RaisePropertyChanged("Online");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceChat")]
    [System.SerializableAttribute()]
    public partial class MessageType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ChatClient.ServiceChatReference.UserType FromUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SubmitDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ChatClient.ServiceChatReference.UserType ToUserField;
        
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
        public ChatClient.ServiceChatReference.UserType FromUser {
            get {
                return this.FromUserField;
            }
            set {
                if ((object.ReferenceEquals(this.FromUserField, value) != true)) {
                    this.FromUserField = value;
                    this.RaisePropertyChanged("FromUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SubmitDate {
            get {
                return this.SubmitDateField;
            }
            set {
                if ((this.SubmitDateField.Equals(value) != true)) {
                    this.SubmitDateField = value;
                    this.RaisePropertyChanged("SubmitDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ChatClient.ServiceChatReference.UserType ToUser {
            get {
                return this.ToUserField;
            }
            set {
                if ((object.ReferenceEquals(this.ToUserField, value) != true)) {
                    this.ToUserField = value;
                    this.RaisePropertyChanged("ToUser");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceChatReference.IServiceChat")]
    public interface IServiceChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/GetOnlineUsers", ReplyAction="http://tempuri.org/IServiceChat/GetOnlineUsersResponse")]
        ChatClient.ServiceChatReference.UserType[] GetOnlineUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/LoginUser", ReplyAction="http://tempuri.org/IServiceChat/LoginUserResponse")]
        bool LoginUser(ChatClient.ServiceChatReference.UserType user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/LogoutUser", ReplyAction="http://tempuri.org/IServiceChat/LogoutUserResponse")]
        bool LogoutUser(ChatClient.ServiceChatReference.UserType user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendMessage", ReplyAction="http://tempuri.org/IServiceChat/SendMessageResponse")]
        bool SendMessage(ChatClient.ServiceChatReference.UserType fromUser, ChatClient.ServiceChatReference.UserType toUser, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/RecieveMessages", ReplyAction="http://tempuri.org/IServiceChat/RecieveMessagesResponse")]
        ChatClient.ServiceChatReference.MessageType[] RecieveMessages(ChatClient.ServiceChatReference.UserType user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatChannel : ChatClient.ServiceChatReference.IServiceChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceChatClient : System.ServiceModel.ClientBase<ChatClient.ServiceChatReference.IServiceChat>, ChatClient.ServiceChatReference.IServiceChat {
        
        public ServiceChatClient() {
        }
        
        public ServiceChatClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceChatClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ChatClient.ServiceChatReference.UserType[] GetOnlineUsers() {
            return base.Channel.GetOnlineUsers();
        }
        
        public bool LoginUser(ChatClient.ServiceChatReference.UserType user) {
            return base.Channel.LoginUser(user);
        }
        
        public bool LogoutUser(ChatClient.ServiceChatReference.UserType user) {
            return base.Channel.LogoutUser(user);
        }
        
        public bool SendMessage(ChatClient.ServiceChatReference.UserType fromUser, ChatClient.ServiceChatReference.UserType toUser, string message) {
            return base.Channel.SendMessage(fromUser, toUser, message);
        }
        
        public ChatClient.ServiceChatReference.MessageType[] RecieveMessages(ChatClient.ServiceChatReference.UserType user) {
            return base.Channel.RecieveMessages(user);
        }
    }
}
