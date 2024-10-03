using DAL;
using DataAccessLayer.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerDal
    {
        public CustomerRepository(Context context) : base(context)
        {
        }
        public List<Customer> GetCustomersByCity(string city)
        {
            throw new NotImplementedException();
        }
    }
}
