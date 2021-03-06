﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PCName", ReplyAction="http://tempuri.org/IService1/PCNameResponse")]
        System.Threading.Tasks.Task<string> PCNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OSName", ReplyAction="http://tempuri.org/IService1/OSNameResponse")]
        System.Threading.Tasks.Task<string> OSNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OSVersion", ReplyAction="http://tempuri.org/IService1/OSVersionResponse")]
        System.Threading.Tasks.Task<string> OSVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TotalPhysicalMemory", ReplyAction="http://tempuri.org/IService1/TotalPhysicalMemoryResponse")]
        System.Threading.Tasks.Task<string> TotalPhysicalMemoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CPUInfo", ReplyAction="http://tempuri.org/IService1/CPUInfoResponse")]
        System.Threading.Tasks.Task<string> CPUInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InputLocale", ReplyAction="http://tempuri.org/IService1/InputLocaleResponse")]
        System.Threading.Tasks.Task<string> InputLocaleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SystemLocale", ReplyAction="http://tempuri.org/IService1/SystemLocaleResponse")]
        System.Threading.Tasks.Task<string> SystemLocaleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DiskCapacity", ReplyAction="http://tempuri.org/IService1/DiskCapacityResponse")]
        System.Threading.Tasks.Task<int> DiskCapacityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Services", ReplyAction="http://tempuri.org/IService1/ServicesResponse")]
        System.Threading.Tasks.Task<string[]> ServicesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : ServiceReference2.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference2.IService1>, ServiceReference2.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.TcpEndPoint.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> PCNameAsync()
        {
            return base.Channel.PCNameAsync();
        }
        
        public System.Threading.Tasks.Task<string> OSNameAsync()
        {
            return base.Channel.OSNameAsync();
        }
        
        public System.Threading.Tasks.Task<string> OSVersionAsync()
        {
            return base.Channel.OSVersionAsync();
        }
        
        public System.Threading.Tasks.Task<string> TotalPhysicalMemoryAsync()
        {
            return base.Channel.TotalPhysicalMemoryAsync();
        }
        
        public System.Threading.Tasks.Task<string> CPUInfoAsync()
        {
            return base.Channel.CPUInfoAsync();
        }
        
        public System.Threading.Tasks.Task<string> InputLocaleAsync()
        {
            return base.Channel.InputLocaleAsync();
        }
        
        public System.Threading.Tasks.Task<string> SystemLocaleAsync()
        {
            return base.Channel.SystemLocaleAsync();
        }
        
        public System.Threading.Tasks.Task<int> DiskCapacityAsync()
        {
            return base.Channel.DiskCapacityAsync();
        }
        
        public System.Threading.Tasks.Task<string[]> ServicesAsync()
        {
            return base.Channel.ServicesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.TcpEndPoint))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.TransferMode = System.ServiceModel.TransferMode.Streamed;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.TcpEndPoint))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://localhost:8733/Service1");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.TcpEndPoint);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.TcpEndPoint);
        }
        
        public enum EndpointConfiguration
        {
            
            TcpEndPoint,
        }
    }
}
