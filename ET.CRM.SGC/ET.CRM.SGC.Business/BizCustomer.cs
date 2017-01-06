using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;
using ET.CRM.SGC.DataAccess;

namespace ET.CRM.SGC.Business
{
    public class BizCustomer
    {
        DtaCustomer oDACustomer = new DtaCustomer();

        public Customer getCustomer(int intIDCustomer)
        {
            Customer oCustomer = new Customer();
            oCustomer = oDACustomer.getCustomerDA(intIDCustomer);
            oCustomer.Phones = oDACustomer.getCustomerPhoneDA(intIDCustomer);
            return oCustomer;
        }
    }
}
