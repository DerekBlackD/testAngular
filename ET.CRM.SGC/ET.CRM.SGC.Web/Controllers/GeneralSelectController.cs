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
    public class GeneralSelectController : ApiController
    {
        BizGeneral oBizGeneral = new BizGeneral();
        // GET api/generalselect
        public IEnumerable<GeneralSelect> GetGeneralSelectItems([FromUri]int intModuleID, int intOptionID)
        {
            List<GeneralSelect> listGeneralSelect = new List<GeneralSelect>();
            listGeneralSelect = oBizGeneral.getGeneralSelectItems(intModuleID, intOptionID);
            return listGeneralSelect;
        }

        // GET api/generalselect/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/generalselect
        public void Post([FromBody]string value)
        {
        }

        // PUT api/generalselect/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/generalselect/5
        public void Delete(int id)
        {
        }
    }
}
