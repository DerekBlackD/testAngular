using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;
using ET.CRM.SGC.DataAccess;

namespace ET.CRM.SGC.Business
{
    public class BizGeneral
    {
        DtaGeneral oDAGeneral = new DtaGeneral();

        public List<GeneralSelect> getGeneralSelectItems(int intModuleID, int intOptionID)
        {
            List<GeneralSelect> listGeneralSelect = new List<GeneralSelect>();
            listGeneralSelect = oDAGeneral.getGeneralSelectItemsDA(intModuleID, intOptionID);
            return listGeneralSelect;
        }
    }
}
