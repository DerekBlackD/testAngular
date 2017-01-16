using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.CRM.SGC.Entities
{
    public class User
    {
        public int BusinessID { get; set; }
        public int ID { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String FullName{ get; set; }
        public String Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int NumberOfNotifications { get; set; }
        public int State { get; set; }
    }

    public class Profile
    {
        public int BusinessID { get; set; }
        public int UserID { get; set; }
        public int ID { get; set; }
        public String Description { get; set; }
    }

    public class Menu
    {
        public int BusinessID { get; set; }
        public int ProfileID { get; set; }
        public int ID { get; set; }
        public String Name { get; set; }
        public List<SubMenu> SubMenu { get; set; }
    }

    public class SubMenu
    {
        public int BusinessID { get; set; }
        public int MenuID { get; set; }
        public int ID { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public List<SubMenuSon> SubMenuSon { get; set; }
    }

    public class SubMenuSon
    {
        public int BusinessID { get; set; }
        public int SubMenuID { get; set; }
        public int ID { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
    }
}
