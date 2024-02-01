using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface ICustomerRepo
    {
        //void AddCustomer(CustomerDTO req);
        void AddCustomerDetails(AddCustomerDetails req);
        //Task<List<GetCustomers>> GetCustomers();
        //Task<GetCustomers> GetCustomer(int CustomerID);
        Task<GetCustomerDetails> GetCustomerDetail(int CustomerID);
        Task<bool> EditCustomerDetails(EditCustomerDetails req);
        Task<List<GetCustomerDetails>> GetCustomerDetails();   
        //Task<bool>EditCustomer(EditCustomerDTO req);

    }
}
