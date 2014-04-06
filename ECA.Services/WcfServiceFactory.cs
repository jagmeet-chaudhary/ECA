
using ECA.BusinessLayer.SQL;
using ECA.BusinessLogic;
using ECA.BusinessLogic.Interfaces;
using ECA.Repository;
using ECA.Repository.SQL;
using Microsoft.Practices.Unity;
using Unity.Wcf;

namespace ECA.Services
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			// register all your components with the container here
            // container
            //    .RegisterType<IService1, Service1>()
            //    .RegisterType<DataContext>(new HierarchicalLifetimeManager());

            //Catalog service
            container.RegisterType<ICatalogService, CatalogService>();
            container.RegisterType<ICatalog, Catalog>();
            container.RegisterType<IBookRepository, SQLBookRepository>();

            //Cart service
            container.RegisterType<ICartService, CartService>();
            container.RegisterType<ICart , ShoppingCart>();
            container.RegisterType<ICartRepository , SQLCartRepository>();

            //User service
            //container.RegisterType<IUserService, UserService>();
            //container.RegisterType<IUserRole, UserRole>();
            //container.RegisterType<IUserRepository, SQLUserRepository>();
            
               
               
        }
    }    
}