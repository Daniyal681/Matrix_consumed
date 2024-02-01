using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ControlAccount { get; set; }
        public string DetailAccount { get; set; }
        public string AccountType { get; set; }
        public EStatus IsActive { get; set; }

    }
    public class EditCustomerDTO
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ControlAccount { get; set; }
        public string DetailAccount { get; set; }
        public string AccountType { get; set; }
        public bool IsActive { get; set; }

    }

    public class GetCustomers
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ControlAccount { get; set; }
        public string DetailAccount { get; set; }
        public string AccountType { get; set; }
        public bool IsActive { get; set; }

    }

    public class AddCustomerDetails
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ControlAccountID { get; set; }
        public string ControlAccount { get; set; }
        public string DetailAccountID { get; set; }
        public string DetailAccount { get; set; }
        public string AccountType { get; set; }
        public string? AccountID { get; set; }
        public string? AccountCode { get; set; }
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }
        public string Account { get; set; }
        public string DocNumber { get; set; }
        public string Status { get; set; }
        public string Agreement { get; set; }

        //card 1
        public string Address { get; set; }
        public int AreaID { get; set; }
        public string AreaCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Cluster { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        //card 2
        public string PrincipleID { get; set; }
        public string PrincipleName { get; set; }

        //card 3 Taxation
        public string CNIC { get; set; }
        public string Expiry { get; set; }
        public string NTN { get; set; }
        public string STRN { get; set; }

        //card 4
        public string KickbackAllowed { get; set; }
        public string RecIncentive { get; set; }
        public string KickbackMethod { get; set; }
        public string AddIncentive { get; set; }
        public string SalesPersonID { get; set; }
        public string SalesPerson { get; set; }
        public string CreditDays { get; set; }
        public string CreditLimit { get; set; }

        //public List<int> Brands { get; set; } 
    }

    public class GetCustomerDetails
    {
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string ControlAccountID { get; set; }
    public string ControlAccount { get; set; }
    public string DetailAccountID { get; set; }
    public string DetailAccount { get; set; }
    public string AccountType { get; set; }
    public string? AccountID { get; set; }
    public string? AccountCode { get; set; }
    public string BusinessName { get; set; }
    public string ContactPerson { get; set; }
    public string Account { get; set; }
    public string DocNumber { get; set; }
    public string Status { get; set; }
    public string Agreement { get; set; }

    //card 1
    public string Address { get; set; }
    public int AreaID { get; set; }
    public string AreaCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Cluster { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }

    //card 2
    public string PrincipleID { get; set; }
    public string PrincipleName { get; set; }

    //card 3 Taxation
    public string CNIC { get; set; }
    public string Expiry { get; set; }
    public string NTN { get; set; }
    public string STRN { get; set; }

    //card 4
    public string KickbackAllowed { get; set; }
    public string RecIncentive { get; set; }
    public string KickbackMethod { get; set; }
    public string AddIncentive { get; set; }
    public string SalesPersonID { get; set; }
    public string SalesPerson { get; set; }
    public string CreditDays { get; set; }
    public string CreditLimit { get; set; }

    //public List<int> Brands { get; set; } 
    public bool IsActive { get; set; }
    }


    public class EditCustomerDetails
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ControlAccountID { get; set; }
        public string ControlAccount { get; set; }
        public string DetailAccountID { get; set; }
        public string DetailAccount { get; set; }
        public string AccountType { get; set; }
        public string? AccountID { get; set; }
        public string? AccountCode { get; set; }
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }
        public string Account { get; set; }
        public string DocNumber { get; set; }
        public string Status { get; set; }
        public string Agreement { get; set; }

        //card 1
        public string Address { get; set; }
        public int AreaID { get; set; }
        public string AreaCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Cluster { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        //card 2
        public string PrincipleID { get; set; }
        public string PrincipleName { get; set; }

        //card 3 Taxation
        public string CNIC { get; set; }
        public string Expiry { get; set; }
        public string NTN { get; set; }
        public string STRN { get; set; }

        //card 4
        public string KickbackAllowed { get; set; }
        public string RecIncentive { get; set; }
        public string KickbackMethod { get; set; }
        public string AddIncentive { get; set; }
        public string SalesPersonID { get; set; }
        public string SalesPerson { get; set; }
        public string CreditDays { get; set; }
        public string CreditLimit { get; set; }

        //public List<int> Brands { get; set; } 
        public bool IsActive { get; set; }
    }

}
