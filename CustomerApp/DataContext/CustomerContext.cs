using CustApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustApp.DataContext
{
    public class CustomerContext :DbContext
    {
        public CustomerContext() : base("CustomerDBConnection")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}