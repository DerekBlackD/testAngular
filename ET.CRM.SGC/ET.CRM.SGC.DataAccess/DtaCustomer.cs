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
    }
}
