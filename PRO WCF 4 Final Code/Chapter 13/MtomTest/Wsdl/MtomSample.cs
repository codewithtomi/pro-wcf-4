﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute()]
public interface IMtomSample
{
    
    [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/IMtomSample/GetFile", ReplyAction="http://tempuri.org/IMtomSample/GetFileResponse")]
    byte[] GetFile(string fileName);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IMtomSampleChannel : IMtomSample, System.ServiceModel.IClientChannel
{
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class MtomSampleProxy : System.ServiceModel.ClientBase<IMtomSample>, IMtomSample
{
    
    public MtomSampleProxy()
    {
    }
    
    public MtomSampleProxy(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MtomSampleProxy(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MtomSampleProxy(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MtomSampleProxy(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public byte[] GetFile(string fileName)
    {
        return base.InnerProxy.GetFile(fileName);
    }
}