using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace Matrix.Infastructure.Services.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private MatrixContext _context;
        public CustomerRepo(MatrixContext context)
        {
            _context = context;
        }

        //public void AddCustomer(CustomerDTO req)
        //{
        //    try
        //    {
        //        var isExist = _context.Customers.Where(x => x.CustomerID == req.CustomerID).FirstOrDefault();
        //        if (isExist != null)
        //            throw new Exception("Customer with the same name already exist");

        //        tblCustomer tblReq = new tblCustomer
        //        {
        //            CustomerName = req.CustomerName,
        //            ControlAccount = req.ControlAccount,
        //            DetailAccount = req.DetailAccount,
        //            AccountType = req.AccountType,

        //        };
        //        _context.Customers.Add(tblReq);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void AddCustomerDetails(AddCustomerDetails req)
        {
            try
            {
                var isExist = _context.Customers.Where(x => x.CustomerID == req.CustomerID).FirstOrDefault();
                if (isExist != null)
                    throw new Exception("Customer with the same name already exist");

                tblCustomer tblReq = new tblCustomer
                {
                    AccountID = req.AccountID,
                    AccountCode = req.AccountCode,
                    CustomerName = req.CustomerName,
                    ControlAccount = req.ControlAccount,
                    ControlAccountID = req.ControlAccountID,
                    DetailAccountID = req.DetailAccountID,
                    DetailAccount = req.DetailAccount,
                    SalesPersonID = req.SalesPersonID,
                    SalesPerson = req.SalesPerson,
                    AccountType = req.AccountType,
                    BusinessName = req.BusinessName,
                    ContactPerson = req.ContactPerson,
                    DocNumber = req.DocNumber,
                    Status = req.Status,
                    Agreement = req.Agreement,
                    Account = req.Account,
                    Address = req.Address,
                    AreaID = req.AreaID,
                    AreaCode = req.AreaCode,
                    City = req.City,
                    State = req.State,
                    Cluster = req.Cluster,
                    Country = req.Country,
                    Phone = req.Phone,
                    Mobile = req.Mobile,
                    Email = req.Email,
                    PrincipleID = req.PrincipleID,
                    PrincipleName = req.PrincipleName,
                    CNIC = req.CNIC,
                    Expiry = req.Expiry,
                    NTN = req.NTN,
                    STRN = req.STRN,
                    KickbackMethod = req.KickbackMethod,
                    KickbackAllowed = req.KickbackAllowed,
                    RecIncentive = req.RecIncentive,
                    AddIncentive = req.AddIncentive,
                    CreditDays = req.CreditDays,
                    CreditLimit = req.CreditLimit,
                };
                _context.Customers.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<bool> EditCustomer(EditCustomerDTO req)
        //{
        //    try
        //    {
        //        var isExist = await _context.Customers.Where(x => x.CustomerID == req.CustomerID).FirstOrDefaultAsync();
        //        if (isExist != null)
        //        {
        //            isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
        //            isExist.CustomerName = req.CustomerName;
        //            isExist.ControlAccount = req.ControlAccount;
        //            isExist.DetailAccount = req.DetailAccount;
        //            isExist.AccountType = req.AccountType;
        //            await _context.SaveChangesAsync();
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public async Task<bool> EditCustomerDetails(EditCustomerDetails req)
        {
            try
            {
                var isExist = await _context.Customers.Where(x => x.CustomerID == req.CustomerID).FirstOrDefaultAsync();
                if (isExist != null)
                {
                    //isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
                    isExist.AccountCode = req.AccountCode;
                    isExist.BusinessName = req.BusinessName;
                    isExist.ContactPerson = req.ContactPerson;
                    isExist.DocNumber = req.DocNumber;
                    isExist.Status = req.Status;
                    isExist.Agreement = req.Agreement;
                    isExist.Address = req.Address;
                    isExist.AreaID = req.AreaID;
                    isExist.City = req.City;
                    isExist.State = req.State;
                    isExist.Cluster = req.Cluster;
                    isExist.Country = req.Country;
                    isExist.Phone = req.Phone;
                    isExist.Mobile = req.Mobile;
                    isExist.Email = req.Email;
                    isExist.PrincipleID = req.PrincipleID;
                    isExist.PrincipleName = req.PrincipleName;
                    isExist.CNIC = req.CNIC;
                    isExist.Expiry = req.Expiry;
                    isExist.NTN = req.NTN;
                    isExist.STRN = req.STRN;
                    isExist.KickbackAllowed = req.KickbackAllowed;
                    isExist.RecIncentive = req.RecIncentive;
                    isExist.AddIncentive = req.AddIncentive;
                    isExist.SalesPerson = req.SalesPerson;
                    isExist.CreditDays = req.CreditDays;
                    isExist.CreditLimit = req.CreditLimit;
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<List<GetCustomers>> GetCustomers()
        //{
        //    try
        //    {
        //        return await _context.Customers.Where(s => s.IsActive == EStatus.Active)
        //    .Select(s => new GetCustomers
        //    { CustomerID = s.CustomerID, CustomerName = s.CustomerName, ControlAccount = s.ControlAccount, DetailAccount = s.DetailAccount, AccountType = s.AccountType }
        //    ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public async Task<GetCustomers> GetCustomer(int CustomerID)
        //{
        //    try
        //    {
        //        var isExist = await _context.Customers.FirstOrDefaultAsync(b => b.CustomerID == CustomerID);

        //        if (isExist != null)
        //        {
        //            var CustomerDTO = new GetCustomers
        //            {
        //                CustomerID = isExist.CustomerID,
        //                CustomerName = isExist.CustomerName,
        //                ControlAccount = isExist.ControlAccount,
        //                DetailAccount = isExist.DetailAccount,
        //                AccountType = isExist.AccountType,
        //                IsActive = (int)isExist.IsActive == 2 ? true : false
        //            };
        //            return CustomerDTO;
        //        }
        //        else
        //        {
        //            throw new Exception("Null Data!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public async Task<List<GetCustomerDetails>> GetCustomerDetails()
        {
            try
            {
                return await _context.Customers.Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
            .Select(s => new GetCustomerDetails
            {
                CustomerID = s.CustomerID,
                CustomerName = s.CustomerName,
                ControlAccountID = s.ControlAccountID,
                ControlAccount = s.ControlAccount,
                AccountType = s.AccountType,
                DetailAccountID = s.DetailAccountID,
                DetailAccount = s.DetailAccount,
                AccountID = s.AccountID,
                AccountCode = s.AccountCode,
                BusinessName = s.BusinessName,
                ContactPerson = s.ContactPerson,
                DocNumber = s.DocNumber,
                Status = s.Status,
                Agreement = s.Agreement,
                Account = s.Account,
                Address = s.Address,
                AreaID = s.AreaID,
                AreaCode = s.AreaCode,
                City = s.City,
                State = s.State,
                Cluster = s.Cluster,
                Country = s.Country,
                Phone = s.Phone,
                Mobile = s.Mobile,
                Email = s.Email,
                PrincipleID = s.PrincipleID,
                PrincipleName = s.PrincipleName,
                CNIC = s.CNIC,
                Expiry = s.Expiry,
                NTN = s.NTN,
                STRN = s.STRN,
                KickbackAllowed = s.KickbackAllowed,
                RecIncentive = s.RecIncentive,
                KickbackMethod = s.KickbackMethod,
                AddIncentive = s.AddIncentive,
                SalesPersonID = s.SalesPersonID,
                SalesPerson = s.SalesPerson,
                CreditDays = s.CreditDays,
                CreditLimit = s.CreditLimit,
            }
            ).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<GetCustomerDetails> GetCustomerDetail(int CustomerID)
        {
            try
            {
                var isExist = await _context.Customers.FirstOrDefaultAsync(b => b.CustomerID == CustomerID);

                if (isExist != null)
                {
                    var CustomerDTO = new GetCustomerDetails
                    {
                        CustomerID = isExist.CustomerID,
                        CustomerName = isExist.CustomerName,
                        ControlAccount = isExist.ControlAccount,
                        ControlAccountID = isExist.ControlAccountID,
                        DetailAccount = isExist.DetailAccount,
                        DetailAccountID = isExist.DetailAccountID,
                        SalesPersonID = isExist.SalesPersonID,
                        AccountType = isExist.AccountType,
                        AccountID = isExist.AccountID,
                        AccountCode = isExist.AccountCode,
                        BusinessName = isExist.BusinessName,
                        ContactPerson = isExist.ContactPerson,
                        DocNumber = isExist.DocNumber,
                        Status = isExist.Status,
                        Agreement = isExist.Agreement,
                        Account = isExist.Account,
                        Address = isExist.Address,
                        AreaCode = isExist.AreaCode,
                        AreaID = isExist.AreaID,
                        City = isExist.City,
                        State = isExist.State,
                        Cluster = isExist.Cluster,
                        Country = isExist.Country,
                        Phone = isExist.Phone,
                        Mobile = isExist.Mobile,
                        Email = isExist.Email,
                        PrincipleID = isExist.PrincipleID,
                        PrincipleName = isExist.PrincipleName,
                        CNIC = isExist.CNIC,
                        Expiry = isExist.Expiry,
                        NTN = isExist.NTN,
                        STRN = isExist.STRN,
                        KickbackAllowed = isExist.KickbackAllowed,
                        RecIncentive = isExist.RecIncentive,
                        KickbackMethod = isExist.KickbackMethod,
                        AddIncentive = isExist.AddIncentive,
                        SalesPerson = isExist.SalesPerson,
                        CreditDays = isExist.CreditDays,
                        CreditLimit = isExist.CreditLimit,
                        IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return CustomerDTO;
                }
                else
                {
                    throw new Exception("Null Data!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
