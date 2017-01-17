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
    public class UserController : ApiController
    {
        BizUser oBizUser = new BizUser();

        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/User/ChangePassword")]
        [HttpPost]
        public String getOtherID()
        {
            return "Probando rutas";
        }

        // GET: api/User/5
        [Authorize]
        public User Get(int BusinessID, int ID)
        {
            User oUser = new User();
            oUser = oBizUser.getUserByID(BusinessID, ID);
            return oUser;
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
