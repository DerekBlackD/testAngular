using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ET.CRM.SGC.Entities;

namespace ET.CRM.SGC.Web.Controllers
{
    public class MenuController : ApiController
    {
        List<Menu> lstMenu = new List<Menu>();
        
        public MenuController()
        {
            Menu oMenu = new Menu();
            oMenu.ID = 1;
            oMenu.Name = "Menu 1";
            oMenu.SubMenu = new List<SubMenu>();
            oMenu.SubMenu.Add(new SubMenu { ID = 11, Name = "Gestión Telefónica", Url = "ColPhoneMngt", SubMenuSon = new List<SubMenuSon>()});
            oMenu.SubMenu.Add(new SubMenu { ID = 12, Name = "Gestión de Campo", Url = "ColAddressMngt", SubMenuSon = new List<SubMenuSon>() });
            oMenu.SubMenu.Add(new SubMenu { ID = 13, Name = "Gestión Progresiva", Url = "ColProgressiveMngt", SubMenuSon = new List<SubMenuSon>() });
            oMenu.SubMenu.Add(new SubMenu { ID = 14, Name = "Análisis de Recaudación", Url = "ColCollectionAnalysis", SubMenuSon = new List<SubMenuSon>() });
            oMenu.SubMenu.Add(new SubMenu { ID = 15, Name = "Asignación de Cartera", Url = "ColAssignment", SubMenuSon = new List<SubMenuSon>() });
            lstMenu.Add(oMenu);
            Menu oMenu1 = new Menu();
            oMenu1.ID = 2;
            oMenu1.Name = "Menu 2";
            oMenu1.SubMenu = new List<SubMenu>();
            lstMenu.Add(oMenu1);
        }

        //GET api/Menu
        public IEnumerable<Menu> getMenu()
        {
            return lstMenu;
        }
    }
}
