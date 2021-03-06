﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemList
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", ConfigurationName="SystemList.zaygbcsys_ws_systlst")]
    public interface zaygbcsys_ws_systlst
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:soap:functions:mc-style:zaygbcsys_ws_systlst:ZaygbcsysRf" +
            "csSystlstRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SystemList.ZaygbcsysRfcsSystlstResponse1> ZaygbcsysRfcsSystlstAsync(SystemList.ZaygbcsysRfcsSystlstRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZaygbcsysRfcsSystlst
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZaygbcsysMsxxlistV6Rf
    {
        
        private string nameField;
        
        private string hostField;
        
        private string servField;
        
        private byte[] msgtypesField;
        
        private byte[] hostadrField;
        
        private byte[] servnoField;
        
        private byte[] stateField;
        
        private string hostnamelongField;
        
        private string hostaddrV4StrField;
        
        private string hostaddrV6StrField;
        
        private byte[] sysservice0Field;
        
        private byte[] sysservice1Field;
        
        private byte[] sysservice2Field;
        
        private byte[] sysservice3Field;
        
        private string servicesField;
        
        private string servstrField;
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Serv
        {
            get
            {
                return this.servField;
            }
            set
            {
                this.servField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=3)]
        public byte[] Msgtypes
        {
            get
            {
                return this.msgtypesField;
            }
            set
            {
                this.msgtypesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=4)]
        public byte[] Hostadr
        {
            get
            {
                return this.hostadrField;
            }
            set
            {
                this.hostadrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=5)]
        public byte[] Servno
        {
            get
            {
                return this.servnoField;
            }
            set
            {
                this.servnoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=6)]
        public byte[] State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Hostnamelong
        {
            get
            {
                return this.hostnamelongField;
            }
            set
            {
                this.hostnamelongField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string HostaddrV4Str
        {
            get
            {
                return this.hostaddrV4StrField;
            }
            set
            {
                this.hostaddrV4StrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string HostaddrV6Str
        {
            get
            {
                return this.hostaddrV6StrField;
            }
            set
            {
                this.hostaddrV6StrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=10)]
        public byte[] Sysservice0
        {
            get
            {
                return this.sysservice0Field;
            }
            set
            {
                this.sysservice0Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=11)]
        public byte[] Sysservice1
        {
            get
            {
                return this.sysservice1Field;
            }
            set
            {
                this.sysservice1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=12)]
        public byte[] Sysservice2
        {
            get
            {
                return this.sysservice2Field;
            }
            set
            {
                this.sysservice2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=13)]
        public byte[] Sysservice3
        {
            get
            {
                return this.sysservice3Field;
            }
            set
            {
                this.sysservice3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string Services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string Servstr
        {
            get
            {
                return this.servstrField;
            }
            set
            {
                this.servstrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZaygbcsysRfcsSystlstResponse
    {
        
        private ZaygbcsysMsxxlistV6Rf[] etSysListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZaygbcsysMsxxlistV6Rf[] EtSysList
        {
            get
            {
                return this.etSysListField;
            }
            set
            {
                this.etSysListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZaygbcsysRfcsSystlstRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public SystemList.ZaygbcsysRfcsSystlst ZaygbcsysRfcsSystlst;
        
        public ZaygbcsysRfcsSystlstRequest()
        {
        }
        
        public ZaygbcsysRfcsSystlstRequest(SystemList.ZaygbcsysRfcsSystlst ZaygbcsysRfcsSystlst)
        {
            this.ZaygbcsysRfcsSystlst = ZaygbcsysRfcsSystlst;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZaygbcsysRfcsSystlstResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public SystemList.ZaygbcsysRfcsSystlstResponse ZaygbcsysRfcsSystlstResponse;
        
        public ZaygbcsysRfcsSystlstResponse1()
        {
        }
        
        public ZaygbcsysRfcsSystlstResponse1(SystemList.ZaygbcsysRfcsSystlstResponse ZaygbcsysRfcsSystlstResponse)
        {
            this.ZaygbcsysRfcsSystlstResponse = ZaygbcsysRfcsSystlstResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface zaygbcsys_ws_systlstChannel : SystemList.zaygbcsys_ws_systlst, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class zaygbcsys_ws_systlstClient : System.ServiceModel.ClientBase<SystemList.zaygbcsys_ws_systlst>, SystemList.zaygbcsys_ws_systlst
    {
        
        public zaygbcsys_ws_systlstClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SystemList.ZaygbcsysRfcsSystlstResponse1> SystemList.zaygbcsys_ws_systlst.ZaygbcsysRfcsSystlstAsync(SystemList.ZaygbcsysRfcsSystlstRequest request)
        {
            return base.Channel.ZaygbcsysRfcsSystlstAsync(request);
        }
        
        public System.Threading.Tasks.Task<SystemList.ZaygbcsysRfcsSystlstResponse1> ZaygbcsysRfcsSystlstAsync(SystemList.ZaygbcsysRfcsSystlst ZaygbcsysRfcsSystlst)
        {
            SystemList.ZaygbcsysRfcsSystlstRequest inValue = new SystemList.ZaygbcsysRfcsSystlstRequest();
            inValue.ZaygbcsysRfcsSystlst = ZaygbcsysRfcsSystlst;
            return ((SystemList.zaygbcsys_ws_systlst)(this)).ZaygbcsysRfcsSystlstAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
