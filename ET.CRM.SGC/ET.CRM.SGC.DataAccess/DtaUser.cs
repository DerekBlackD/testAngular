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
        private static List<User> lstUser = new List<User> { 
        new User{ BusinessID = 1, ID = 1, UserName="jpena", FullName = "Junior Peña", Email="juniorp@eratec.com", Password="977bad728c0477bde9231b3f65d7f965d5cc20a22c20a71fba94cb1532959bdf", NumberOfNotifications = 12, State = 1},
        new User{ BusinessID = 1, ID = 2, UserName= "asoto", FullName= "Alejandra Soto", Email="asoto@eratec.com", Password="942678ce85a4b1a4e11658f77e61b022a178acb6319abc7d359bb54e89ae66bb", NumberOfNotifications = 4, State = 1}};

        public User ValidateLogin(String UserName, String Password)
        {
            /* clave: eratec - varchar(64)
             * hex: 977bad728c0477bde9231b3f65d7f965d5cc20a22c20a71fba94cb1532959bdf
             * HEX: 977BAD728C0477BDE9231B3F65D7F965D5CC20A22C20A71FBA94CB1532959BDF
             * h:e:x: 97:7b:ad:72:8c:04:77:bd:e9:23:1b:3f:65:d7:f9:65:d5:cc:20:a2:2c:20:a7:1f:ba:94:cb:15:32:95:9b:df 
             * base64: l3utcowEd73pIxs/Zdf5ZdXMIKIsIKcfupTLFTKVm98=  */

            /* clave: CusTer@5854 - varchar(64)
             * hex: 942678ce85a4b1a4e11658f77e61b022a178acb6319abc7d359bb54e89ae66bb
             * HEX: 942678CE85A4B1A4E11658F77E61B022A178ACB6319ABC7D359BB54E89AE66BB
             * h:e:x: 94:26:78:ce:85:a4:b1:a4:e1:16:58:f7:7e:61:b0:22:a1:78:ac:b6:31:9a:bc:7d:35:9b:b5:4e:89:ae:66:bb 
             * base64: lCZ4zoWksaThFlj3fmGwIqF4rLYxmrx9NZu1TomuZrs= */

            //0 - Invalid Username or Password
            //1 - OK
            //2 - The user has expired

            User oUser = new User();
            int Resul = lstUser.Where(x => x.UserName == UserName && x.Password == Password).ToList().Count;
            if (Resul > 0)
            {
                oUser.BusinessID = lstUser.Where(x => x.UserName == UserName && x.Password == Password).First().BusinessID;
                oUser.ID = lstUser.Where(x => x.UserName == UserName && x.Password == Password).First().ID;
                oUser.State = lstUser.Where(x => x.UserName == UserName && x.Password == Password).First().State;
            }
            else
            {
                oUser.State = 0;
            }
            return oUser;
        }

        public User getUserByID(int BusinessID, int UserID)
        {
            User oUser = new User();
            oUser = lstUser.Where(x => x.BusinessID == BusinessID && x.ID == UserID).First();
            return oUser;
        }
    }

}
