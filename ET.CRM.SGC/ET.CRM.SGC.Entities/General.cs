using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.CRM.SGC.Entities
{
    public class General
    {
        public int ID { get; set; }
    }

    public class GeneralSelect
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public int OptionID { get; set; }
        public String Code { get; set; }
        public String Description { get; set; }
    }
}
