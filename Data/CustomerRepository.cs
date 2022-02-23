using System.Collections.Generic;
using CustomersApi.Data.Data;
using CustomersApi.Data.Interfaces;
using CustomersApi.Models;
using System.Linq;
using System;

namespace CustomersApi.Data.Repositories
{
    public class CustomerRepository :  ICustomerRepository
    {

        public CustomersDbContext Context { get; }
    


        public CustomerRepository(CustomersDbContext context) 
        {
          Context = context;
        }
        // Create a Customer or returns 0
        public int CreateCustomer(CustomerData customerDto)
        {
            try
            {
                var customer = new Customer()
                {
                    Name = customerDto.Name,
                    Email = customerDto.Email
                };
                Context.Add(customer);
                Context.SaveChanges();
                return customer.id;
            }
            catch (Exception)//Something went wrong
            {
                return 0;
            }
        }
        //delete Customer with given id 
        public Status DeleteCustomer(int id)
        {
            var customer = Context.Customers.SingleOrDefault(v => v.id == id);
            if (customer == null)//no such customer
            {
                return Status.NotFound;
            }
            Context.Remove(customer);//delete customer
            Context.SaveChanges();
            return Status.Success;
        }
        // return customer with given id or null if no such Customer
        public CustomerData GetCustomer(int id)
        {
            var customer = Context.Customers.SingleOrDefault(v => v.id == id);
            if (customer == null)//no such customer
            {
                return null;
            }
            var customerDto = new CustomerData()
            {
                id = customer.id,
                Name = customer.Name,
                Email = customer.Email
            };
            return customerDto;
        }

        //Get all customers
        public IEnumerable<CustomerData> GetCustomers()
        {
            var customerDtoList = Context.Customers.Select(customer =>
            new CustomerData()
            {
                id = customer.id,
                Name = customer.Name,
                Email = customer.Email
            }).ToList();
            return customerDtoList;
        }
        //update customer
        public Status UpdateCustomer(int id, CustomerData customerDto)
        {
            var customer = Context.Customers.SingleOrDefault(v => v.id == id);
            if (customer == null)//No such Customer
            {
                return Status.NotFound;
            }
            customer.Name = customerDto.Name;
            customer.Email = customerDto.Email;
            Context.Update(customer);
            Context.SaveChanges();
            return Status.Success;
        }
    }
}