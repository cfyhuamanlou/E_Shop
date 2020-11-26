using E_Shop.Entity;
using E_Shop.IBLL;
using E_Shop.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.BLL
{
    public class CustomerService : BaseService<Customer>,ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
            this.CurrentDal = _customerDal;
        }
    }
}
