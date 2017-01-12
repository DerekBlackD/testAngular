using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;
using ET.CRM.SGC.DataAccess;

namespace ET.CRM.SGC.Business
{
    public class BizUser
    {
        DtaUser oDtaUser = new DtaUser();
        public int ValidateLogin(String UserName, String Password){
            int statusLogin;
            statusLogin = oDtaUser.ValidateLogin(UserName, Password);
            return statusLogin;
        }
    }
}
