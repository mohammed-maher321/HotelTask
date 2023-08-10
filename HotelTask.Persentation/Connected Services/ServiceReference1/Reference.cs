﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HotelQueryModel", Namespace="http://schemas.datacontract.org/2004/07/HotelTask.Dto.Queries")]
    public partial class HotelQueryModel : object
    {
        
        private string KeyWordField;
        
        private System.Nullable<decimal> PriceFromField;
        
        private System.Nullable<decimal> PriceToField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KeyWord
        {
            get
            {
                return this.KeyWordField;
            }
            set
            {
                this.KeyWordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PriceFrom
        {
            get
            {
                return this.PriceFromField;
            }
            set
            {
                this.PriceFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PriceTo
        {
            get
            {
                return this.PriceToField;
            }
            set
            {
                this.PriceToField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoapHotelDto", Namespace="http://schemas.datacontract.org/2004/07/HotelTask.Soap.Model")]
    public partial class SoapHotelDto : object
    {
        
        private string CodeField;
        
        private string CurrencyField;
        
        private string IsReadyField;
        
        private string LocationField;
        
        private decimal LowestPriceField;
        
        private string NameField;
        
        private string RatingField;
        
        private System.Collections.Generic.List<ServiceReference1.SoapRoomDto> RoomsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Currency
        {
            get
            {
                return this.CurrencyField;
            }
            set
            {
                this.CurrencyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IsReady
        {
            get
            {
                return this.IsReadyField;
            }
            set
            {
                this.IsReadyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal LowestPrice
        {
            get
            {
                return this.LowestPriceField;
            }
            set
            {
                this.LowestPriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReference1.SoapRoomDto> Rooms
        {
            get
            {
                return this.RoomsField;
            }
            set
            {
                this.RoomsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoapRoomDto", Namespace="http://schemas.datacontract.org/2004/07/HotelTask.Soap.Model")]
    public partial class SoapRoomDto : object
    {
        
        private string CodeField;
        
        private string NameField;
        
        private int OccupancyField;
        
        private bool StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Occupancy
        {
            get
            {
                return this.OccupancyField;
            }
            set
            {
                this.OccupancyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISoapHotelService")]
    public interface ISoapHotelService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapHotelService/GetAllHotels", ReplyAction="http://tempuri.org/ISoapHotelService/GetAllHotelsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.SoapHotelDto>> GetAllHotelsAsync(ServiceReference1.HotelQueryModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ISoapHotelServiceChannel : ServiceReference1.ISoapHotelService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class SoapHotelServiceClient : System.ServiceModel.ClientBase<ServiceReference1.ISoapHotelService>, ServiceReference1.ISoapHotelService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SoapHotelServiceClient() : 
                base(SoapHotelServiceClient.GetDefaultBinding(), SoapHotelServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISoapHotelService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapHotelServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SoapHotelServiceClient.GetBindingForEndpoint(endpointConfiguration), SoapHotelServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapHotelServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SoapHotelServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapHotelServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SoapHotelServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapHotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.SoapHotelDto>> GetAllHotelsAsync(ServiceReference1.HotelQueryModel model)
        {
            return base.Channel.GetAllHotelsAsync(model);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapHotelService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapHotelService))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7271/SoapHotelService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SoapHotelServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISoapHotelService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SoapHotelServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISoapHotelService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISoapHotelService,
        }
    }
}