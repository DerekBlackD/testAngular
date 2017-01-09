using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;

namespace ET.CRM.SGC.DataAccess
{
    public class DtaGeneral
    {
        public List<GeneralSelect> getGeneralSelectItemsDA(int intModuleID, int intOptionID) {
            List<GeneralSelect> listSelectItems = new List<GeneralSelect>();
            if (intModuleID == 1)
            {
                switch (intOptionID)
                {
                    case 1:
                        listSelectItems.Add(new GeneralSelect { ID = 1, ModuleID = 1, OptionID = 1, Code = "", Description = "Seleccionar" });
                        listSelectItems.Add(new GeneralSelect { ID = 1, ModuleID = 1, OptionID = 1, Code = "01", Description = "Movistar" });
                        listSelectItems.Add(new GeneralSelect { ID = 2, ModuleID = 1, OptionID = 1, Code = "02", Description = "Claro" });
                        listSelectItems.Add(new GeneralSelect { ID = 3, ModuleID = 1, OptionID = 1, Code = "03", Description = "Entel" });
                        listSelectItems.Add(new GeneralSelect { ID = 4, ModuleID = 1, OptionID = 1, Code = "04", Description = "Bitel" });
                        break;
                    case 2:
                        listSelectItems.Add(new GeneralSelect { ID = 5, ModuleID = 1, OptionID = 2, Code = "", Description = "Seleccionar" });
                        listSelectItems.Add(new GeneralSelect { ID = 5, ModuleID = 1, OptionID = 2, Code = "01", Description = "BASE_MOVISTAR34" });
                        listSelectItems.Add(new GeneralSelect { ID = 6, ModuleID = 1, OptionID = 2, Code = "02", Description = "CLAROTELEFONOS" });
                        listSelectItems.Add(new GeneralSelect { ID = 7, ModuleID = 1, OptionID = 2, Code = "03", Description = "ESSALUD" });
                        listSelectItems.Add(new GeneralSelect { ID = 8, ModuleID = 1, OptionID = 2, Code = "04", Description = "EQUIFAX_SAC" });
                        listSelectItems.Add(new GeneralSelect { ID = 9, ModuleID = 1, OptionID = 2, Code = "05", Description = "COMPRADO" });
                        listSelectItems.Add(new GeneralSelect { ID = 10, ModuleID = 1, OptionID = 2, Code = "06", Description = "MOVISTAR2016" });
                        break;
                }
            }
            return listSelectItems;
        }
    }
}
