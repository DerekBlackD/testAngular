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
            //oCustomer.Phones = oDACustomer.getAllCustomerPhoneDA(intIDCustomer);
            return oCustomer;
        }

        public List<CustomerPhone> getAllCustomerPhone()
        {
            List<CustomerPhone> lstCustomerPhone = new List<CustomerPhone>();
            lstCustomerPhone = oDACustomer.getAllCustomerPhoneDA(0);
            return lstCustomerPhone;
        }
        public CustomerPhone getCustomerPhone(int intIDCustomer, int intIDCustomerPhone)
        {
            CustomerPhone oCustomerPhone = new CustomerPhone();
            oCustomerPhone = oDACustomer.getCustomerPhoneDA(intIDCustomer, intIDCustomerPhone);
            return oCustomerPhone;
        }

        public void insertCustomerPhone(CustomerPhone oCustomerPhone)
        {
            oDACustomer.insertCustomerPhone(oCustomerPhone);
        }

        public void updateCustomerPhone(int intIdCustomer, CustomerPhone oCustomerPhone)
        {
             oDACustomer.updateCustomerPhone(intIdCustomer, oCustomerPhone);
        }
    }
}
