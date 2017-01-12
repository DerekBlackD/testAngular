using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.CRM.SGC.Entities
{
    class User
    {
        public int ID { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Name{ get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
