using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.CRM.SGC.Entities
{

    public class Menu
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public List<SubMenu> SubMenu { get; set; }
    }

    public class SubMenu
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public List<SubMenuSon> SubMenuSon { get; set; }
    }

    public class SubMenuSon
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
    }
}
