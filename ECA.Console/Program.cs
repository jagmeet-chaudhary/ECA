using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ECA.BusinessLogic;
//using ECA.Model;
using ECA.Console.catalogService;
using System.ServiceModel;

namespace ECA.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
               
                catalogService.CatalogServiceClient client = new catalogService.CatalogServiceClient();
                //List<BookCategory> lstjson = client.GetAllBooksGroupedByCategory_JSON();
                List<ECA.Console.catalogService.BookCategory> lst = client.GetAllBooksGroupedByCategory();
                foreach (BookCategory cat in lst)
                {
                    System.Console.WriteLine(cat.CategoryName);
                    foreach (Book b in cat.Books)
                    {
                        System.Console.WriteLine("|__" + b.Title);
                    }
                }
            }
            catch (FaultException fex)
            {
                System.Console.WriteLine(fex.Message);
            }
            catch (Exception ex)
            {

                throw;
            }
            
         

        }
    }
}
