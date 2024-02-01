using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Matrix.Infastructure.Services.Repositories
{
    public class LocalPurchaseRepo : ILocalPurchaseRepo
    {
        private MatrixContext _context;
        public LocalPurchaseRepo(MatrixContext context)
        {
            _context = context;
        }

        public async Task<bool> EditLocalPurchase(EditLocalPurchase req)
        {
            try
            {
                var isExist = await _context.LocalPurchase.Where(x => x.RecID == req.RecID).FirstOrDefaultAsync();
                if (isExist != null)
                {
                    //isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
                    isExist.TransactionDate = DateTime.UtcNow;
                    isExist.InvoiceDate = DateTime.UtcNow;
                    isExist.PaymentDueDate = DateTime.UtcNow;
                    isExist.SupplierID = req.SupplierID;
                    isExist.SupplierName = req.SupplierName;
                    isExist.SupplierInvoiceNo = req.SupplierInvoiceNo;
                    isExist.Others = req.Other;
                    isExist.Discount = req.Discount;
                    isExist.Total = req.Total;
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerateLocalPurchase(LocalPurchaseRequest req)
        {
            try
            {
                tblLocalPurchase tblreq = new tblLocalPurchase
                {
                    InvoiceDate = req.InvoiceDate,
                    PaymentDueDate = req.PaymentDueDate,
                    TransactionDate = req.TransactionDate,
                    SupplierID = req.SupplierID,
                    SupplierName = req.SupplierName,
                    SupplierInvoiceNo = req.SupplierInvoice,
                    SubTotal = req.LineItems.Sum(s => (s.Rate * s.QTY)),
                    Others = req.Other,
                    Discount = req.Discount,
                    Total = (((req.LineItems.Sum(s => (s.Rate * s.QTY))) + req.Other) - req.Discount),
                    Remarks = req.Remarks,
                    PurchaseDetails = req.LineItems.Select(s => new tblLocalPurchaseDetails
                    {
                        WareHouseID = s.WareHouseID,
                        Amount = (s.Rate * s.QTY),
                        ModelID = s.ModelID,
                        Rate = s.Rate,
                        QTY = s.QTY
                    }).ToList()
                };
                _context.LocalPurchase.Add(tblreq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetLocalPurchase>> GetLocalPurchase()
        {
            try
            {
                return await _context.LocalPurchase
                    .Where(x => x.IsActive == EStatus.Active)
                    .Select(x => new GetLocalPurchase
                    {
                        RecID = x.RecID,
                        TransactionNo = x.TransactionNo,
                        TransactionDate = x.TransactionDate.ToString("dd/MM/yyyy"),
                        SupplierID = x.SupplierID,
                        SupplierName = x.SupplierName,
                        SupplierInvoiceNo = x.SupplierInvoiceNo,
                        InvoiceDate = x.InvoiceDate.ToString("dd/MM/yyyy"),
                        PaymentDueDate = x.PaymentDueDate.ToString("dd/MM/yyyy"),
                        Other = x.Others,
                        Discount = x.Discount,
                        Total = x.Total,
                    }).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<EditLocalPurchase> GetLocalPurchase(int RecID)
        {
            try
            {
                var isExist = await _context.LocalPurchase.FirstOrDefaultAsync(b => b.RecID == RecID);

                if (isExist != null)
                {
                    var localPurchaseDTO = new EditLocalPurchase
                    {
                        RecID = isExist.RecID,
                        TransactionNo = isExist.TransactionNo,
                        TransactionDate = isExist.TransactionDate,
                        InvoiceDate = isExist.InvoiceDate,
                        PaymentDueDate = isExist.PaymentDueDate,
                        SupplierID = isExist.SupplierID,
                        SupplierName = isExist.SupplierName,
                        SupplierInvoiceNo = isExist.SupplierInvoiceNo,
                        Other = isExist.Others,
                        Discount = isExist.Discount,
                        Total = isExist.Total,
                        Remarks = isExist.Remarks,
                        LineItems = _context.LocalPurchaseDetails.Select(s => new LocalPurchaseLineItemRequest
                        {
                            ModelID = s.ModelID,
                            Rate = s.Rate,
                            QTY = s.QTY,
                            WareHouseID = s.WareHouseID,
                            Amount = s.Amount
                        }).ToList()
                    };
                    return localPurchaseDTO;
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
