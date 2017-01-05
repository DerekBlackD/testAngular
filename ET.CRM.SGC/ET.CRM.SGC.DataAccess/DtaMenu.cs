using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;

namespace ET.CRM.SGC.DataAccess
{
    public class DtaMenu
    {
        public List<Menu> getMenuItemsDA()
        {
            List<Menu> lstMenu = new List<Menu>();
            lstMenu.Add(new Menu { ID = 1, Name = "Cobranza" });
            lstMenu.Add(new Menu { ID = 2, Name = "Administración" });
            lstMenu.Add(new Menu { ID = 3, Name = "Consultas" });
            lstMenu.Add(new Menu { ID = 4, Name = "Importaciones" });
            lstMenu.Add(new Menu { ID = 5, Name = "Soporte" });
            lstMenu.Add(new Menu { ID = 6, Name = "Seguridad" });
            return lstMenu;
        }

        public List<SubMenu> getSubMenuItemsDA(int intIDMenu)
        {
            List<SubMenu> lstSubMenu = new List<SubMenu>();
            switch (intIDMenu){
                case 1:
                    lstSubMenu.Add(new SubMenu { ID = 11, Name = "Gestión Telefónica", Url = "ColPhoneMngt" });
                    lstSubMenu.Add(new SubMenu { ID = 12, Name = "Gestión de Campo", Url = "ColAddressMngt" });
                    lstSubMenu.Add(new SubMenu { ID = 13, Name = "Gestión Progresiva", Url = "ColProgressiveMngt" });
                    lstSubMenu.Add(new SubMenu { ID = 14, Name = "Análisis de Recaudación", Url = "ColCollectionAnalysis" });
                    lstSubMenu.Add(new SubMenu { ID = 15, Name = "Asignación de Cartera", Url = "ColAssignment" });
                    break;
                case 2:
                    lstSubMenu.Add(new SubMenu { ID = 21, Name = "Mantenimiento de Clientes", Url = "ColMaintenanceCustomer" });
                    lstSubMenu.Add(new SubMenu { ID = 22, Name = "Mantenimiento de Cartera de Clientes", Url = "ColMaintenancePortfolioCustomer" });
                    lstSubMenu.Add(new SubMenu { ID = 23, Name = "Mantenimiento de Gestores", Url = "ColMaintenanceManager" });
                    break;
                case 3:
                    lstSubMenu.Add(new SubMenu { ID = 31, Name = "Consulta de Recaudación", Url = "ColQueryCollection" });
                    lstSubMenu.Add(new SubMenu { ID = 32, Name = "Consulta de Notificaciones", Url = "ColQueryNotificaciones" });
                    lstSubMenu.Add(new SubMenu { ID = 33, Name = "Reporte de Carteras", Url = "ColPortfolioReport" });
                    break;
                case 4:
                    lstSubMenu.Add(new SubMenu { ID = 41, Name = "Carga Masiva", Url = "ColBulkUpload" });
                    lstSubMenu.Add(new SubMenu { ID = 42, Name = "Otras importaciones", Url = "ColBulkUpload" });
                    break;
                case 5:
                    lstSubMenu.Add(new SubMenu { ID = 51, Name = "Configuraciones", Url = "#" });
                    lstSubMenu.Add(new SubMenu { ID = 52, Name = "Buscadores", Url = "ColSearchers" });
                    break;
                case 6:
                    lstSubMenu.Add(new SubMenu { ID = 61, Name = "Mantenimiento de Usuarios", Url = "ColSecurityUser" });
                    lstSubMenu.Add(new SubMenu { ID = 62, Name = "Mantenimiento de Opciones", Url = "ColSecurityOption" });
                    break;
            }
            return lstSubMenu;
        }

        public List<SubMenuSon> getSubMenuSonItems(int intIDSubMenu)
        {
            List<SubMenuSon> lstSubMenuSon = new List<SubMenuSon>();
            switch (intIDSubMenu)
            {
                case 51:
                    lstSubMenuSon.Add(new SubMenuSon { ID = 511, Name = "Configuración General", Url = "ColGeneralConfig" });
                    lstSubMenuSon.Add(new SubMenuSon { ID = 512, Name = "Resultados de Gestión", Url = "ColResultsConfig" });
                    break;
            }
            return lstSubMenuSon;
        }
    }
}
