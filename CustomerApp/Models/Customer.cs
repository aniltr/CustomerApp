using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustApp.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
    }
}