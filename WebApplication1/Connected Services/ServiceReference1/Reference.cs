﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.FlightsWebServiceSoap")]
    public interface FlightsWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApplication1.ServiceReference1.HelloWorldResponse HelloWorld(WebApplication1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApplication1.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name getFlightsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getFlights", ReplyAction="*")]
        WebApplication1.ServiceReference1.getFlightsResponse getFlights(WebApplication1.ServiceReference1.getFlightsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getFlights", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.getFlightsResponse> getFlightsAsync(WebApplication1.ServiceReference1.getFlightsRequest request);
        
        // CODEGEN: Generating message contract since element name getOneFlightResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getOneFlight", ReplyAction="*")]
        WebApplication1.ServiceReference1.getOneFlightResponse getOneFlight(WebApplication1.ServiceReference1.getOneFlightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getOneFlight", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.getOneFlightResponse> getOneFlightAsync(WebApplication1.ServiceReference1.getOneFlightRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplication1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplication1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getFlightsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getFlights", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.getFlightsRequestBody Body;
        
        public getFlightsRequest() {
        }
        
        public getFlightsRequest(WebApplication1.ServiceReference1.getFlightsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getFlightsRequestBody {
        
        public getFlightsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getFlightsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getFlightsResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.getFlightsResponseBody Body;
        
        public getFlightsResponse() {
        }
        
        public getFlightsResponse(WebApplication1.ServiceReference1.getFlightsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getFlightsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplication1.ServiceReference1.ArrayOfString[] getFlightsResult;
        
        public getFlightsResponseBody() {
        }
        
        public getFlightsResponseBody(WebApplication1.ServiceReference1.ArrayOfString[] getFlightsResult) {
            this.getFlightsResult = getFlightsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getOneFlightRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getOneFlight", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.getOneFlightRequestBody Body;
        
        public getOneFlightRequest() {
        }
        
        public getOneFlightRequest(WebApplication1.ServiceReference1.getOneFlightRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getOneFlightRequestBody {
        
        public getOneFlightRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getOneFlightResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getOneFlightResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.getOneFlightResponseBody Body;
        
        public getOneFlightResponse() {
        }
        
        public getOneFlightResponse(WebApplication1.ServiceReference1.getOneFlightResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getOneFlightResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplication1.ServiceReference1.ArrayOfString getOneFlightResult;
        
        public getOneFlightResponseBody() {
        }
        
        public getOneFlightResponseBody(WebApplication1.ServiceReference1.ArrayOfString getOneFlightResult) {
            this.getOneFlightResult = getOneFlightResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FlightsWebServiceSoapChannel : WebApplication1.ServiceReference1.FlightsWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlightsWebServiceSoapClient : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.FlightsWebServiceSoap>, WebApplication1.ServiceReference1.FlightsWebServiceSoap {
        
        public FlightsWebServiceSoapClient() {
        }
        
        public FlightsWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightsWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightsWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightsWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.HelloWorldResponse WebApplication1.ServiceReference1.FlightsWebServiceSoap.HelloWorld(WebApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplication1.ServiceReference1.HelloWorldRequest inValue = new WebApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication1.ServiceReference1.HelloWorldRequestBody();
            WebApplication1.ServiceReference1.HelloWorldResponse retVal = ((WebApplication1.ServiceReference1.FlightsWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.HelloWorldResponse> WebApplication1.ServiceReference1.FlightsWebServiceSoap.HelloWorldAsync(WebApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebApplication1.ServiceReference1.HelloWorldRequest inValue = new WebApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication1.ServiceReference1.HelloWorldRequestBody();
            return ((WebApplication1.ServiceReference1.FlightsWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.getFlightsResponse WebApplication1.ServiceReference1.FlightsWebServiceSoap.getFlights(WebApplication1.ServiceReference1.getFlightsRequest request) {
            return base.Channel.getFlights(request);
        }
        
        public WebApplication1.ServiceReference1.ArrayOfString[] getFlights() {
            WebApplication1.ServiceReference1.getFlightsRequest inValue = new WebApplication1.ServiceReference1.getFlightsRequest();
            inValue.Body = new WebApplication1.ServiceReference1.getFlightsRequestBody();
            WebApplication1.ServiceReference1.getFlightsResponse retVal = ((WebApplication1.ServiceReference1.FlightsWebServiceSoap)(this)).getFlights(inValue);
            return retVal.Body.getFlightsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.getFlightsResponse> WebApplication1.ServiceReference1.FlightsWebServiceSoap.getFlightsAsync(WebApplication1.ServiceReference1.getFlightsRequest request) {
            return base.Channel.getFlightsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.getFlightsResponse> getFlightsAsync() {
            WebApplication1.ServiceReference1.getFlightsRequest inValue = new WebApplication1.ServiceReference1.getFlightsRequest();
            inValue.Body = new WebApplication1.ServiceReference1.getFlightsRequestBody();
            return ((WebApplication1.ServiceReference1.FlightsWebServiceSoap)(this)).getFlightsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.getOneFlightResponse WebApplication1.ServiceReference1.FlightsWebServiceSoap.getOneFlight(WebApplication1.ServiceReference1.getOneFlightRequest request) {
            return base.Channel.getOneFlight(request);
        }
        
        public WebApplication1.ServiceReference1.ArrayOfString getOneFlight() {
            WebApplication1.ServiceReference1.getOneFlightRequest inValue = new WebApplication1.ServiceReference1.getOneFlightRequest();
            inValue.Body = new WebApplication1.ServiceReference1.getOneFlightRequestBody();
            WebApplication1.ServiceReference1.getOneFlightResponse retVal = ((WebApplication1.ServiceReference1.FlightsWebServiceSoap)(this)).getOneFlight(inValue);
            return retVal.Body.getOneFlightResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.getOneFlightResponse> WebApplication1.ServiceReference1.FlightsWebServiceSoap.getOneFlightAsync(WebApplication1.ServiceReference1.getOneFlightRequest request) {
            return base.Channel.getOneFlightAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.getOneFlightResponse> getOneFlightAsync() {
            WebApplication1.ServiceReference1.getOneFlightRequest inValue = new WebApplication1.ServiceReference1.getOneFlightRequest();
            inValue.Body = new WebApplication1.ServiceReference1.getOneFlightRequestBody();
            return ((WebApplication1.ServiceReference1.FlightsWebServiceSoap)(this)).getOneFlightAsync(inValue);
        }
    }
}
