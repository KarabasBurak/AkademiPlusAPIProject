using AkademiPlusAPI.DataAccessLayer.Abstract;
using AkademiPlusAPI.DataAccessLayer.Concrete;
using AkademiPlusAPI.DataAccessLayer.Repositories;
using AkademiPlusAPI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusAPI.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public int GetCustomerCounts()
        {
            var context = new Context();
            return context.Customers.Count();
        }
    }
}
