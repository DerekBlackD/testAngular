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
        public User ValidateLogin(String UserName, String Password){
            User oUser = new User();
            oUser = oDtaUser.ValidateLogin(UserName, Password);
            return oUser;
        }

        public User getUserByID(int BusinessID, int UserID)
        {
            User oUser = new User();
            oUser = oDtaUser.getUserByID(BusinessID, UserID);
            oUser.Profiles = oDtaUser.getProfileByUserID(BusinessID, UserID);
            return oUser;
        }
    }
}
