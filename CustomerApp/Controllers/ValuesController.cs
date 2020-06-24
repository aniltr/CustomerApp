using CustApp.DataContext;
using CustApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustApp.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly CustomerContext context = new CustomerContext();
        // GET api/values
        public IEnumerable<Customer> Get()
        {
            return context.Customers;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
