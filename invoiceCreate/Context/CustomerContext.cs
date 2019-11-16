using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoiceCreate.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
    }
}
