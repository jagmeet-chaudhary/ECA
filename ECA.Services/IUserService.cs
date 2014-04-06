using ECA.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ECA.Services
{
    [ServiceContract(Name = "IUserService", Namespace = "ECA.CatalogServices")]
    public interface IUserService
    {
        [OperationContract(Name = "ValidateUser")]
        [FaultContract(typeof(BaseServiceFault), Name = "BaseServiceFault")]
        bool ValidateUser(string UserName,string Password);
    }
}
