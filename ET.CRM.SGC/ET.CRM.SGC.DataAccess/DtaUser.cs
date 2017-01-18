using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.CRM.SGC.Entities;

namespace ET.CRM.SGC.DataAccess
{
    public class DtaUser
    {
        private static List<User> lstUsers = new List<User> { 
        new User{ BusinessID = 1, ID = 1, UserName="jpena", FullName = "Junior Peña", Email="juniorp@eratec.com", Password="977bad728c0477bde9231b3f65d7f965d5cc20a22c20a71fba94cb1532959bdf", NumberOfNotifications = 12, State = 1},
        new User{ BusinessID = 1, ID = 2, UserName= "asoto", FullName= "Alejandra Soto", Email="asoto@eratec.com", Password="942678ce85a4b1a4e11658f77e61b022a178acb6319abc7d359bb54e89ae66bb", NumberOfNotifications = 4, State = 1}};

        private static List<Profile> lstProfiles = new List<Profile> {
            new Profile{ BusinessID = 1, UserID = 1, ID = 1, Description = "Administrador"},
            new Profile{ BusinessID = 1, UserID = 2, ID = 2, Description = "Administrador"},
            new Profile{ BusinessID = 1, UserID = 2, ID = 3, Description = "Gestor"}
        };

        public User ValidateLogin(String UserName, String Password)
        {
            /* clave: eratec - varchar(64)
             * hex: 977bad728c0477bde9231b3f65d7f965d5cc20a22c20a71fba94cb1532959bdf */

            /* clave: CusTer@5854 - varchar(64)
             * hex: 942678ce85a4b1a4e11658f77e61b022a178acb6319abc7d359bb54e89ae66bb */

            //0 - Invalid Username or Password
            //1 - OK
            //2 - The user has expired

            User oUser = new User();
            int Resul = lstUsers.Where(x => x.UserName == UserName && x.Password == Password).ToList().Count;
            if (Resul > 0)
            {
                oUser.BusinessID = lstUsers.Where(x => x.UserName == UserName && x.Password == Password).First().BusinessID;
                oUser.ID = lstUsers.Where(x => x.UserName == UserName && x.Password == Password).First().ID;
                oUser.State = lstUsers.Where(x => x.UserName == UserName && x.Password == Password).First().State;
            }
            else
            {
                oUser.BusinessID = 0;
                oUser.ID = 0;
                oUser.State = 0;
            }
            return oUser;
        }

        public User getUserByID(int BusinessID, int UserID)
        {
            User oUser = new User();
            oUser = lstUsers.Where(x => x.BusinessID == BusinessID && x.ID == UserID).First();
            return oUser;
        }

        public List<Profile> getProfileByUserID(int BusinessID, int UserID)
        {
            List<Profile> lstProfile = new List<Profile>();
            lstProfile = lstProfiles.Where(x => x.BusinessID == BusinessID && x.UserID == UserID).ToList();
            return lstProfile;
        }
    }

}
