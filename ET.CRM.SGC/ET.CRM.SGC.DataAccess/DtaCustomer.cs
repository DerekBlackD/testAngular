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
        private static List<CustomerPhone> lstCustomerPhone = new List<CustomerPhone>{
            new CustomerPhone { ID = 1, PhoneNumber = "999111333", Annexed = "1", Origin = "01", OriginName = "BASE_MOVISTAR34", Provider = "04", ProviderName = "Bitel", Priority = 1 },
            new CustomerPhone { ID = 2, PhoneNumber = "999111111", Annexed = "0", Origin = "01", OriginName = "BASE_MOVISTAR34", Provider = "01", ProviderName = "Movistar", Priority = 2 },
            new CustomerPhone { ID = 3, PhoneNumber = "999111222", Annexed = "0", Origin = "01", OriginName = "BASE_MOVISTAR34", Provider = "02", ProviderName = "Claro", Priority = 3 },
            new CustomerPhone { ID = 4, PhoneNumber = "999111555", Annexed = "1", Origin = "02", OriginName = "CLAROTELEFONOS", Provider = "01", ProviderName = "Movistar", Priority = 3 },
            new CustomerPhone { ID = 5, PhoneNumber = "999111666", Annexed = "1", Origin = "03", OriginName = "ESSALUD", Provider = "03", ProviderName = "Entel", Priority = 3 },
            new CustomerPhone { ID = 6, PhoneNumber = "999111777", Annexed = "73", Origin = "04", OriginName = "EQUIFAX_SAC", Provider = "01", ProviderName = "Movistar", Priority = 3 },
            new CustomerPhone { ID = 7, PhoneNumber = "999111888", Annexed = "1", Origin = "05", OriginName = "COMPRADO", Provider = "01", ProviderName = "Movistar", Priority = 3 },
            new CustomerPhone { ID = 8, PhoneNumber = "999111999", Annexed = "1", Origin = "06", OriginName = "MOVISTAR2016", Provider = "03", ProviderName = "Entel", Priority = 4 },
            new CustomerPhone { ID = 9, PhoneNumber = "999111000", Annexed = "1", Origin = "06", OriginName = "MOVISTAR2016", Provider = "03", ProviderName = "Entel", Priority = 5 }
        };

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

        public List<CustomerPhone> getAllCustomerPhoneDA(int intIDCustomer)
        {
            return lstCustomerPhone;
        }

        public CustomerPhone getCustomerPhoneDA(int intIDCustomer, int intPhoneID)
        {
            CustomerPhone oCustomerPhone = new CustomerPhone();
            oCustomerPhone = lstCustomerPhone.Find(x => x.ID == intPhoneID);
            return oCustomerPhone;
        }

        public void insertCustomerPhone(CustomerPhone oCustomerPhone){
            int intNewID;
            intNewID = lstCustomerPhone.Count + 1;
            oCustomerPhone.ID = intNewID;
            lstCustomerPhone.Add(oCustomerPhone);
        }

        public void updateCustomerPhone(int intIDCustomer, CustomerPhone oCustomerPhone)
        {
            List<CustomerPhone> lstUpdate = new List<CustomerPhone>();
            lstCustomerPhone
                .Where(x => x.ID == oCustomerPhone.ID)
                .Select(c => { c.Provider = oCustomerPhone.Provider; return c; }).ToList();
        }
    }
}
