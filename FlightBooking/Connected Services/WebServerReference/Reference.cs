﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightBooking.WebServerReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServerReference.FlightsWebServiceSoap")]
    public interface FlightsWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        FlightBooking.WebServerReference.HelloWorldResponse HelloWorld(FlightBooking.WebServerReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<FlightBooking.WebServerReference.HelloWorldResponse> HelloWorldAsync(FlightBooking.WebServerReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name getFlightsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getFlights", ReplyAction="*")]
        FlightBooking.WebServerReference.getFlightsResponse getFlights(FlightBooking.WebServerReference.getFlightsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getFlights", ReplyAction="*")]
        System.Threading.Tasks.Task<FlightBooking.WebServerReference.getFlightsResponse> getFlightsAsync(FlightBooking.WebServerReference.getFlightsRequest request);
        
        // CODEGEN: Generating message contract since element name getAllFlightsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAllFlights", ReplyAction="*")]
        FlightBooking.WebServerReference.getAllFlightsResponse getAllFlights(FlightBooking.WebServerReference.getAllFlightsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAllFlights", ReplyAction="*")]
        System.Threading.Tasks.Task<FlightBooking.WebServerReference.getAllFlightsResponse> getAllFlightsAsync(FlightBooking.WebServerReference.getAllFlightsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public FlightBooking.WebServerReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(FlightBooking.WebServerReference.HelloWorldRequestBody Body) {
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
        public FlightBooking.WebServerReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(FlightBooking.WebServerReference.HelloWorldResponseBody Body) {
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
        public FlightBooking.WebServerReference.getFlightsRequestBody Body;
        
        public getFlightsRequest() {
        }
        
        public getFlightsRequest(FlightBooking.WebServerReference.getFlightsRequestBody Body) {
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
        public FlightBooking.WebServerReference.getFlightsResponseBody Body;
        
        public getFlightsResponse() {
        }
        
        public getFlightsResponse(FlightBooking.WebServerReference.getFlightsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getFlightsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public FlightBooking.WebServerReference.ArrayOfString[] getFlightsResult;
        
        public getFlightsResponseBody() {
        }
        
        public getFlightsResponseBody(FlightBooking.WebServerReference.ArrayOfString[] getFlightsResult) {
            this.getFlightsResult = getFlightsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getAllFlightsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getAllFlights", Namespace="http://tempuri.org/", Order=0)]
        public FlightBooking.WebServerReference.getAllFlightsRequestBody Body;
        
        public getAllFlightsRequest() {
        }
        
        public getAllFlightsRequest(FlightBooking.WebServerReference.getAllFlightsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getAllFlightsRequestBody {
        
        public getAllFlightsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getAllFlightsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getAllFlightsResponse", Namespace="http://tempuri.org/", Order=0)]
        public FlightBooking.WebServerReference.getAllFlightsResponseBody Body;
        
        public getAllFlightsResponse() {
        }
        
        public getAllFlightsResponse(FlightBooking.WebServerReference.getAllFlightsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getAllFlightsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public FlightBooking.WebServerReference.ArrayOfString getAllFlightsResult;
        
        public getAllFlightsResponseBody() {
        }
        
        public getAllFlightsResponseBody(FlightBooking.WebServerReference.ArrayOfString getAllFlightsResult) {
            this.getAllFlightsResult = getAllFlightsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FlightsWebServiceSoapChannel : FlightBooking.WebServerReference.FlightsWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlightsWebServiceSoapClient : System.ServiceModel.ClientBase<FlightBooking.WebServerReference.FlightsWebServiceSoap>, FlightBooking.WebServerReference.FlightsWebServiceSoap {
        
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
        FlightBooking.WebServerReference.HelloWorldResponse FlightBooking.WebServerReference.FlightsWebServiceSoap.HelloWorld(FlightBooking.WebServerReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            FlightBooking.WebServerReference.HelloWorldRequest inValue = new FlightBooking.WebServerReference.HelloWorldRequest();
            inValue.Body = new FlightBooking.WebServerReference.HelloWorldRequestBody();
            FlightBooking.WebServerReference.HelloWorldResponse retVal = ((FlightBooking.WebServerReference.FlightsWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FlightBooking.WebServerReference.HelloWorldResponse> FlightBooking.WebServerReference.FlightsWebServiceSoap.HelloWorldAsync(FlightBooking.WebServerReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<FlightBooking.WebServerReference.HelloWorldResponse> HelloWorldAsync() {
            FlightBooking.WebServerReference.HelloWorldRequest inValue = new FlightBooking.WebServerReference.HelloWorldRequest();
            inValue.Body = new FlightBooking.WebServerReference.HelloWorldRequestBody();
            return ((FlightBooking.WebServerReference.FlightsWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FlightBooking.WebServerReference.getFlightsResponse FlightBooking.WebServerReference.FlightsWebServiceSoap.getFlights(FlightBooking.WebServerReference.getFlightsRequest request) {
            return base.Channel.getFlights(request);
        }
        
        public FlightBooking.WebServerReference.ArrayOfString[] getFlights() {
            FlightBooking.WebServerReference.getFlightsRequest inValue = new FlightBooking.WebServerReference.getFlightsRequest();
            inValue.Body = new FlightBooking.WebServerReference.getFlightsRequestBody();
            FlightBooking.WebServerReference.getFlightsResponse retVal = ((FlightBooking.WebServerReference.FlightsWebServiceSoap)(this)).getFlights(inValue);
            return retVal.Body.getFlightsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FlightBooking.WebServerReference.getFlightsResponse> FlightBooking.WebServerReference.FlightsWebServiceSoap.getFlightsAsync(FlightBooking.WebServerReference.getFlightsRequest request) {
            return base.Channel.getFlightsAsync(request);
        }
        
        public System.Threading.Tasks.Task<FlightBooking.WebServerReference.getFlightsResponse> getFlightsAsync() {
            FlightBooking.WebServerReference.getFlightsRequest inValue = new FlightBooking.WebServerReference.getFlightsRequest();
            inValue.Body = new FlightBooking.WebServerReference.getFlightsRequestBody();
            return ((FlightBooking.WebServerReference.FlightsWebServiceSoap)(this)).getFlightsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FlightBooking.WebServerReference.getAllFlightsResponse FlightBooking.WebServerReference.FlightsWebServiceSoap.getAllFlights(FlightBooking.WebServerReference.getAllFlightsRequest request) {
            return base.Channel.getAllFlights(request);
        }
        
        public FlightBooking.WebServerReference.ArrayOfString getAllFlights() {
            FlightBooking.WebServerReference.getAllFlightsRequest inValue = new FlightBooking.WebServerReference.getAllFlightsRequest();
            inValue.Body = new FlightBooking.WebServerReference.getAllFlightsRequestBody();
            FlightBooking.WebServerReference.getAllFlightsResponse retVal = ((FlightBooking.WebServerReference.FlightsWebServiceSoap)(this)).getAllFlights(inValue);
            return retVal.Body.getAllFlightsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FlightBooking.WebServerReference.getAllFlightsResponse> FlightBooking.WebServerReference.FlightsWebServiceSoap.getAllFlightsAsync(FlightBooking.WebServerReference.getAllFlightsRequest request) {
            return base.Channel.getAllFlightsAsync(request);
        }
        
        public System.Threading.Tasks.Task<FlightBooking.WebServerReference.getAllFlightsResponse> getAllFlightsAsync() {
            FlightBooking.WebServerReference.getAllFlightsRequest inValue = new FlightBooking.WebServerReference.getAllFlightsRequest();
            inValue.Body = new FlightBooking.WebServerReference.getAllFlightsRequestBody();
            return ((FlightBooking.WebServerReference.FlightsWebServiceSoap)(this)).getAllFlightsAsync(inValue);
        }
    }
}