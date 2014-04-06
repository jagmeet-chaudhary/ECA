using ECA.Model;
using ECA.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ECA.Services
{
    [ServiceContract(Name = "ICartService", Namespace = "ECA.CartServices")]
    public interface ICartService
    {
        [OperationContract(Name = "GetCartItems")]
        [FaultContract(typeof(BaseServiceFault), Name = "BaseServiceFault")]
        List<Cart> GetCartItems(int userId);

    }
}