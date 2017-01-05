using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ET.CRM.SGC.Entities;
using ET.CRM.SGC.Business;

namespace ET.CRM.SGC.Web.Controllers
{
    public class CustomerController : ApiController
    {
        BizCustomer oBizCustomer = new BizCustomer();
        // GET api/customer
        public Customer GetCustomer()
        {
            Customer oCustomer = new Customer();
            oCustomer = oBizCustomer.getCustomer(1);
            return oCustomer;
        }

        // GET api/customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/customer
        public void Post([FromBody]string value)
        {
        }

        // PUT api/customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/customer/5
        public void Delete(int id)
        {
        }
    }
}
