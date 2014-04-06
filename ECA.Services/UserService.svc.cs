using ECA.BusinessLogic.Interfaces;
using ECA.Model;
using ECA.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ECA.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        private IUserRole  _userRole;

        public UserService(IUserRole userRole)
        {
            _userRole  = userRole;
        }


        public bool ValidateUser(string UserName,string Password)
        {
            try
            {
                return _userRole.ValidateUser(UserName, Password);
            }
            catch (Exception ex)
            {
                throw new FaultException<BaseServiceFault>(new BaseServiceFault(), ex.Message);
            }
        }
    }
}
