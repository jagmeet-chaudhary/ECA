using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLogic.Interfaces
{
    public interface ICart
    {
         IList<Cart> GetCartItems(int userId);
        
    }
}
