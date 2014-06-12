﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vendor.CustomerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name productName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateStockWith", ReplyAction="*")]
        Vendor.CustomerService.UpdateStockWithResponse UpdateStockWith(Vendor.CustomerService.UpdateStockWithRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateStockWithRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateStockWith", Namespace="http://tempuri.org/", Order=0)]
        public Vendor.CustomerService.UpdateStockWithRequestBody Body;
        
        public UpdateStockWithRequest() {
        }
        
        public UpdateStockWithRequest(Vendor.CustomerService.UpdateStockWithRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateStockWithRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string productName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int quantity;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string description;
        
        public UpdateStockWithRequestBody() {
        }
        
        public UpdateStockWithRequestBody(string productName, int quantity, string description) {
            this.productName = productName;
            this.quantity = quantity;
            this.description = description;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateStockWithResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateStockWithResponse", Namespace="http://tempuri.org/", Order=0)]
        public Vendor.CustomerService.UpdateStockWithResponseBody Body;
        
        public UpdateStockWithResponse() {
        }
        
        public UpdateStockWithResponse(Vendor.CustomerService.UpdateStockWithResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateStockWithResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdateStockWithResult;
        
        public UpdateStockWithResponseBody() {
        }
        
        public UpdateStockWithResponseBody(string UpdateStockWithResult) {
            this.UpdateStockWithResult = UpdateStockWithResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : Vendor.CustomerService.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<Vendor.CustomerService.Service1Soap>, Vendor.CustomerService.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Vendor.CustomerService.UpdateStockWithResponse Vendor.CustomerService.Service1Soap.UpdateStockWith(Vendor.CustomerService.UpdateStockWithRequest request) {
            return base.Channel.UpdateStockWith(request);
        }
        
        public string UpdateStockWith(string productName, int quantity, string description) {
            Vendor.CustomerService.UpdateStockWithRequest inValue = new Vendor.CustomerService.UpdateStockWithRequest();
            inValue.Body = new Vendor.CustomerService.UpdateStockWithRequestBody();
            inValue.Body.productName = productName;
            inValue.Body.quantity = quantity;
            inValue.Body.description = description;
            Vendor.CustomerService.UpdateStockWithResponse retVal = ((Vendor.CustomerService.Service1Soap)(this)).UpdateStockWith(inValue);
            return retVal.Body.UpdateStockWithResult;
        }
    }
}
