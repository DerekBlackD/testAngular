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
    public class CustomerPhoneController : ApiController
    {
        BizCustomer oBizCustomer = new BizCustomer();
        // GET: api/CustomerPhone
        public List<CustomerPhone> getAllCustomerPhone()
        {
            return oBizCustomer.getAllCustomerPhone();
        }

        // GET: api/CustomerPhone/5
        public CustomerPhone getCustomerPhone(int id)
        {
            CustomerPhone oCustomerPhone = new CustomerPhone();
            oCustomerPhone = oBizCustomer.getCustomerPhone(0,id);
            return oCustomerPhone;
        }

        // POST: api/CustomerPhone
        public void Post([FromBody]CustomerPhone oCustomerPhone)
        {
            oBizCustomer.insertCustomerPhone(oCustomerPhone);
        }

        // PUT: api/CustomerPhone/5
        public void Put(int id, [FromBody]CustomerPhone oCustomerPhone)
        {
            oBizCustomer.updateCustomerPhone(id, oCustomerPhone);
        }

        // DELETE: api/CustomerPhone/5
        public void Delete(int id)
        {
        }
    }
}
