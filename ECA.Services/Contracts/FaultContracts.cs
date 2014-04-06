using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ECA.Services.Contracts
{
    [DataContract(Name = "BaseServiceFault", Namespace = "ECA.Services.FaultContracts")]
    public class BaseServiceFault : IExtensibleDataObject
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        public ExtensionDataObject ExtensionData
        {
            get;
            set;
        }
    }
    
}