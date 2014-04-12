using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.BusinessLayer.SQL
{
    public class SQLBaseRepository
    {
        public ECAEntities Db { get; set; }
        public SQLBaseRepository()
        {
            Db = new ECAEntities();
            Db.Configuration.ProxyCreationEnabled = false;
        }
        public SQLBaseRepository(ECAEntities _Db)
        {
            Db = _Db;
            try //TBD:Check why ProxyCreationEnabled is null in case of Mock DB
            {
                Db.Configuration.ProxyCreationEnabled = false;
            }
            catch { }
        }
    }
}
