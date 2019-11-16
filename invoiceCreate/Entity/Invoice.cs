using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoiceCreate.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPriceAmount { get; set; }
        public int ProductSubAmount { get; set; }
        public int ProductTotalAmount { get; set; }
        public List<Customer> Customer { get; set; }
    }
}
