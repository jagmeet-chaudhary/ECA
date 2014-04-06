using ECA.Model;
using ECA.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ECA.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICatalogService" in both code and config file together.
    [ServiceContract(Name = "ICatalogService", Namespace = "ECA.CatalogServices")]
    public interface ICatalogService
    {

        [OperationContract(Name = "GetAllBooksGroupedByCategory")]
        [FaultContract(typeof(BaseServiceFault), Name = "BaseServiceFault")]
        List<BookCategory> GetAllBooksGroupedByCategory();

        [OperationContract(Name = "GetAllBooksGroupedByCategoryAsString")]
        [WebInvoke(UriTemplate = "Books/{format}", Method = "GET")]
        [FaultContract(typeof(BaseServiceFault), Name = "BaseServiceFault")]
        string GetAllBooksGroupedByCategoryAsString(string format);

        [OperationContract(Name = "GetBookDetails")]
        [FaultContract(typeof(BaseServiceFault), Name = "BaseServiceFault")]
        Book GetBookDetails(string id);
    }
}
