﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.Example03
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfClient.Example03.IMyInterface")]
    public interface IMyInterface
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyInterface/HelloWorld", ReplyAction="http://tempuri.org/IMyInterface/HelloWorldResponse")]
        string HelloWorld(string yourName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMyInterfaceChannel : WcfClient.Example03.IMyInterface, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MyInterfaceClient : System.ServiceModel.ClientBase<WcfClient.Example03.IMyInterface>, WcfClient.Example03.IMyInterface
    {
        
        public MyInterfaceClient()
        {
        }
        
        public MyInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public MyInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MyInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MyInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string HelloWorld(string yourName)
        {
            return base.Channel.HelloWorld(yourName);
        }
    }
}
