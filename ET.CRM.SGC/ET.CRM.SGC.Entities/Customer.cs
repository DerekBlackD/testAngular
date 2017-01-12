using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.CRM.SGC.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public String DocumentType { get; set; }
        public String DocumentNumber { get; set; }
        public String Names { get; set; }
        public String LastName { get; set; }
        public String SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String State { get; set; }
        public List<CustomerPhone> Phones { get; set; }
        public List<CustomerAddress> Addresses { get; set; }
        public List<CustomerAccount> Accounts { get; set; }
    }

    public class CustomerPhone
    {
        public int BusinnesID { get; set; }
        public int CustomerID { get; set; }
        public int ID { get; set; }
        public String PhoneNumber { get; set; }
        public String PhoneCode { get; set; }
        public String Annexed { get; set; }
        public String Class { get; set; }
        public String ClassName { get; set; }
        public String Origin { get; set; }
        public String OriginName { get; set; }
        public String Provider { get; set; }
        public String ProviderName { get; set; }
        public int Priority { get; set; }
        public int SubPriority { get; set; }
        public String Observation { get; set; }
        public String State { get; set; }
    }

    public class CustomerAddress
    {
        public int ID { get; set; }
        public String FullAddress { get; set; }
        public int NumberAddress { get; set; }
        public String Origin { get; set; }
        public String OriginName { get; set; }
        public int Priority { get; set; }
        public String DepartmentCode { get; set; }
        public String ProvinceCode { get; set; }
        public String DistrictCode { get; set; }
        public String State { get; set; }
    }

    public class CustomerAccount
    {
        public int ID { get; set; }
        public String AccountNumber { get; set; }
        public String Product { get; set; }
        public String Sector { get; set; }
        public decimal CapitalAmount { get; set; }
        public decimal DebtAmount { get; set; }
        public decimal CampaignAmount { get; set; }
        public DateTime AssignmentDate { get; set; }
        public int Fee { get; set; }
        public DateTime DueDate { get; set; }
        public String State { get; set; }
    }
}
