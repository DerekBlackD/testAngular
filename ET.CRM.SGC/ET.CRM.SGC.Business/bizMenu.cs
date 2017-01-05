using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;
using ET.CRM.SGC.DataAccess;

namespace ET.CRM.SGC.Business
{
    public class BizMenu
    {
        DtaMenu oDAMenu = new DtaMenu();
        public List<Menu> getMenuItems()
        {
            List<Menu> lstMenu = new List<Menu>();
            lstMenu = oDAMenu.getMenuItemsDA();

            foreach (Menu iMenu in lstMenu)
            {
                iMenu.SubMenu = oDAMenu.getSubMenuItemsDA(iMenu.ID);

                foreach (SubMenu iSubMenu in iMenu.SubMenu)
                {
                    iSubMenu.SubMenuSon = oDAMenu.getSubMenuSonItems(iSubMenu.ID);
                }
            }

            return lstMenu;
        }
    }
}
