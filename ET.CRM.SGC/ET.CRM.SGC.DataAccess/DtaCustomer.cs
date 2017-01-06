using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;

namespace ET.CRM.SGC.DataAccess
{
    public class DtaCustomer
    {
        public Customer getCustomerDA(int intIDCustomer)
        {
            Customer oCustomer = new Customer();
            oCustomer.ID = 113;
            oCustomer.DocumentType = "01";
            oCustomer.DocumentNumber = "47829210";
            oCustomer.Names = "Junior";
            oCustomer.LastName = "Peña";
            oCustomer.SecondLastName = "Benito";
            return oCustomer;
        }

        public List<CustomerPhone> getCustomerPhoneDA(int intIDCustomer)
        {
            List<CustomerPhone> lstCustomerPhone = new List<CustomerPhone>();
            lstCustomerPhone.Add(new CustomerPhone { ID = 1, PhoneNumber = "999111333", Annexed = "1", Origin = "1", OriginName = "BASE_BITEL", Provider = "1", ProviderName = "Bitel", Priority = 1 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 2, PhoneNumber = "999111111", Annexed = "0", Origin = "1", OriginName = "BASE_MOVISTAR", Provider = "1", ProviderName = "Movistar", Priority = 2 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 3, PhoneNumber = "999111222", Annexed = "0", Origin = "1", OriginName = "BASE_CLARO", Provider = "1", ProviderName = "Claro", Priority = 3 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 4, PhoneNumber = "999111555", Annexed = "1", Origin = "1", OriginName = "BASE_MOVISTAR", Provider = "1", ProviderName = "Movistar", Priority = 3 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 5, PhoneNumber = "999111666", Annexed = "1", Origin = "1", OriginName = "BASE_ENTEL", Provider = "1", ProviderName = "Entel", Priority = 3 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 6, PhoneNumber = "999111777", Annexed = "73", Origin = "1", OriginName = "BASE_MOVISTAR", Provider = "1", ProviderName = "Movistar", Priority = 3 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 7, PhoneNumber = "999111888", Annexed = "1", Origin = "1", OriginName = "BASE_MOVISTAR", Provider = "1", ProviderName = "Movistar", Priority = 3 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 8, PhoneNumber = "999111999", Annexed = "1", Origin = "1", OriginName = "BASE_ENTEL", Provider = "1", ProviderName = "Entel", Priority = 4 });
            lstCustomerPhone.Add(new CustomerPhone { ID = 9, PhoneNumber = "999111000", Annexed = "1", Origin = "1", OriginName = "BASE_ENTEL", Provider = "1", ProviderName = "Entel", Priority = 5 });
            return lstCustomerPhone;
        }
    }
}
