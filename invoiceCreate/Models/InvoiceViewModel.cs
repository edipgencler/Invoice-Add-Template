using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoiceCreate.Models
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPriceAmount { get; set; }
        public int ProductSubAmount { get; set; }
        public int ProductTotalAmount { get; set; }
    }
}
