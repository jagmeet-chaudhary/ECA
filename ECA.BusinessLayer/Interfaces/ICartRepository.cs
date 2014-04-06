using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.Repository
{
    public interface ICartRepository
    {
        IQueryable<Cart> GetCartItems(int UserId);
        void SaveCartItems(List<Cart> items);
    }
}
