using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblSalesInvoice
    {
        [Key]
        public int RecID { get; set; }
        public string InvoiceNo { get; set; }
        public int TransactionType { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public decimal Total { get; set; }
        public string Remarks { get; set; }
    }
}
