using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ET.CRM.SGC.Entities;
using ET.CRM.SGC.Business;

namespace ET.CRM.SGC.Web.Controllers
{
    public class MenuController : ApiController
    {
     
        //GET api/Menu
        public IEnumerable<Menu> getMenu()
        {
            BizMenu oBizMenu = new BizMenu();
            List<Menu> lstMenu = new List<Menu>();
            lstMenu = oBizMenu.getMenuItems();
            return lstMenu;
        }
    }
}
