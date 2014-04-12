
using ECA.Model;
using ECA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLayer.SQL
{
    public class SQLCartRepository : SQLBaseRepository ,ICartRepository
    {
         public SQLCartRepository() : base()
        {
        }
         public SQLCartRepository(ECAEntities _DB): base(_DB)
       {
        }
        public IQueryable<Model.Cart> GetCartItems(int UserId)
        {
            return Db.Carts.Where(c => c.UserId == UserId).AsQueryable();
        }

        public void SaveCartItems(List<Model.Cart> items)
        {
            items.ForEach(c => Db.Carts.Add(c));
            Db.SaveChanges();
        }
    }
}
