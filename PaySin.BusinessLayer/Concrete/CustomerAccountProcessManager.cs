using PaySin.BusinessLayer.Abstract;
using PaySin.DataAccessLayer.Abstract;
using PaySin.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySin.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProsess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public List<CustomerAccountProsess> TGetAll()
        {
            return _customerAccountProcessDal.GetAll();
        }

        public CustomerAccountProsess TGetByID(int id)
        {
            return _customerAccountProcessDal.GetByID(id);
        }

        public void TInsert(CustomerAccountProsess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CustomerAccountProsess t)
        {
            _customerAccountProcessDal.Update(t);
        }
    }
}
