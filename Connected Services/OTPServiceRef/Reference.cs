//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApprovedMedicalSurvey.OTPServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendStatus", Namespace="https://www.tamimahsms.com/")]
    [System.SerializableAttribute()]
    public partial class SendStatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long ProccessedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BatchRefCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusDescField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long Proccessed {
            get {
                return this.ProccessedField;
            }
            set {
                if ((this.ProccessedField.Equals(value) != true)) {
                    this.ProccessedField = value;
                    this.RaisePropertyChanged("Proccessed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StatusCode {
            get {
                return this.StatusCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusCodeField, value) != true)) {
                    this.StatusCodeField = value;
                    this.RaisePropertyChanged("StatusCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string BatchRefCode {
            get {
                return this.BatchRefCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BatchRefCodeField, value) != true)) {
                    this.BatchRefCodeField = value;
                    this.RaisePropertyChanged("BatchRefCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string StatusDesc {
            get {
                return this.StatusDescField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusDescField, value) != true)) {
                    this.StatusDescField = value;
                    this.RaisePropertyChanged("StatusDesc");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.tamimahsms.com/", ConfigurationName="OTPServiceRef.BulkPushSoap")]
    public interface BulkPushSoap {
        
        // CODEGEN: Generating message contract since element name UserName from namespace https://www.tamimahsms.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="https://www.tamimahsms.com/SendSMS", ReplyAction="*")]
        ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponse SendSMS(ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.tamimahsms.com/SendSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponse> SendSMSAsync(ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMS", Namespace="https://www.tamimahsms.com/", Order=0)]
        public ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequestBody Body;
        
        public SendSMSRequest() {
        }
        
        public SendSMSRequest(ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://www.tamimahsms.com/")]
    public partial class SendSMSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Message;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public long Priority;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Schdate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Sender;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string AppID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string SourceRef;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string MSISDNs;
        
        public SendSMSRequestBody() {
        }
        
        public SendSMSRequestBody(string UserName, string Password, string Message, long Priority, string Schdate, string Sender, string AppID, string SourceRef, string MSISDNs) {
            this.UserName = UserName;
            this.Password = Password;
            this.Message = Message;
            this.Priority = Priority;
            this.Schdate = Schdate;
            this.Sender = Sender;
            this.AppID = AppID;
            this.SourceRef = SourceRef;
            this.MSISDNs = MSISDNs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSResponse", Namespace="https://www.tamimahsms.com/", Order=0)]
        public ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponseBody Body;
        
        public SendSMSResponse() {
        }
        
        public SendSMSResponse(ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://www.tamimahsms.com/")]
    public partial class SendSMSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApprovedMedicalSurvey.OTPServiceRef.SendStatus SendSMSResult;
        
        public SendSMSResponseBody() {
        }
        
        public SendSMSResponseBody(ApprovedMedicalSurvey.OTPServiceRef.SendStatus SendSMSResult) {
            this.SendSMSResult = SendSMSResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BulkPushSoapChannel : ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BulkPushSoapClient : System.ServiceModel.ClientBase<ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap>, ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap {
        
        public BulkPushSoapClient() {
        }
        
        public BulkPushSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BulkPushSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BulkPushSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BulkPushSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponse ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap.SendSMS(ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest request) {
            return base.Channel.SendSMS(request);
        }
        
        public ApprovedMedicalSurvey.OTPServiceRef.SendStatus SendSMS(string UserName, string Password, string Message, long Priority, string Schdate, string Sender, string AppID, string SourceRef, string MSISDNs) {
            ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest inValue = new ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest();
            inValue.Body = new ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequestBody();
            inValue.Body.UserName = UserName;
            inValue.Body.Password = Password;
            inValue.Body.Message = Message;
            inValue.Body.Priority = Priority;
            inValue.Body.Schdate = Schdate;
            inValue.Body.Sender = Sender;
            inValue.Body.AppID = AppID;
            inValue.Body.SourceRef = SourceRef;
            inValue.Body.MSISDNs = MSISDNs;
            ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponse retVal = ((ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap)(this)).SendSMS(inValue);
            return retVal.Body.SendSMSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponse> ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap.SendSMSAsync(ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest request) {
            return base.Channel.SendSMSAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApprovedMedicalSurvey.OTPServiceRef.SendSMSResponse> SendSMSAsync(string UserName, string Password, string Message, long Priority, string Schdate, string Sender, string AppID, string SourceRef, string MSISDNs) {
            ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest inValue = new ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequest();
            inValue.Body = new ApprovedMedicalSurvey.OTPServiceRef.SendSMSRequestBody();
            inValue.Body.UserName = UserName;
            inValue.Body.Password = Password;
            inValue.Body.Message = Message;
            inValue.Body.Priority = Priority;
            inValue.Body.Schdate = Schdate;
            inValue.Body.Sender = Sender;
            inValue.Body.AppID = AppID;
            inValue.Body.SourceRef = SourceRef;
            inValue.Body.MSISDNs = MSISDNs;
            return ((ApprovedMedicalSurvey.OTPServiceRef.BulkPushSoap)(this)).SendSMSAsync(inValue);
        }
    }
}
