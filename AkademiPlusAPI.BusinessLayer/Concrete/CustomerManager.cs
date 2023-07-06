using AkademiPlusAPI.BusinessLayer.Abstract;
using AkademiPlusAPI.DataAccessLayer.Abstract;
using AkademiPlusAPI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusAPI.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public int TGetCustomerCounts()
        {
            return _customerDal.GetCustomerCounts();
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
