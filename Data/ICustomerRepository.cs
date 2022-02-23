
using System.Collections.Generic;
using CustomersApi.Data.Data;

namespace CustomersApi.Data.Interfaces
{
    public interface ICustomerRepository
    {
        CustomerData GetCustomer(int id);
        IEnumerable<CustomerData> GetCustomers();
        Status DeleteCustomer(int id);
        int CreateCustomer(CustomerData customerDto);
        Status UpdateCustomer(int id, CustomerData customerDto);
    }
}
