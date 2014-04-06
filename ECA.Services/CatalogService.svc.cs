using ECA.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using ECA.Services.Contracts;
using ECA.Model;
using System.ServiceModel.Web;

namespace ECA.Services
{
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall )]
   public class CatalogService : ICatalogService
    {
        private ICatalog  _catalog;
       
        public CatalogService(ICatalog catalog)
        {
            _catalog = catalog;
        }
       
        public List<Model.BookCategory> GetAllBooksGroupedByCategory()
        {
            try
            {
                return _catalog.GetAllBooksGroupedByCategory().ToList();
            }
            catch (Exception Ex)
            {

                throw new FaultException<BaseServiceFault>(new BaseServiceFault() ,Ex.Message);
            }
        }

        public string GetAllBooksGroupedByCategoryAsString(string format)
        {
            try
            {
                return format.ToUpper().Equals("JSON") ? Helper.ConvertToJSON(_catalog.GetAllBooksGroupedByCategory()) : Helper.ConvertToXML(_catalog.GetAllBooksGroupedByCategory());
                
            }
            catch (Exception Ex)
            {

                throw new FaultException<BaseServiceFault>(new BaseServiceFault(), Ex.Message);
            }
        }
        public Book GetBookDetails(string id)
        {
            try
            {
                return _catalog.GetBookById(id);
            }
            catch (Exception ex)
            {
                throw new FaultException<BaseServiceFault>(new BaseServiceFault(), ex.Message);
            }
        }
    }
}
