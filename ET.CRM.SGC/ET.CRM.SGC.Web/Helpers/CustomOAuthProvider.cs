using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using ET.CRM.SGC.Business;
using ET.CRM.SGC.Entities;

namespace ET.CRM.SGC.Web.Helpers
{
    public class CustomOAuthProvider : OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.FromResult<object>(null);
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            var allowedOrigin = "*";

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });

            User oUser = new User();
            BizUser oBizUser = new BizUser();
            String EncodePassword = ET.CRM.SGC.Utilities.SecurityTools.EncryptPassword(context.Password);
            oUser = oBizUser.ValidateLogin(context.UserName, EncodePassword);

            if (oUser.State == 0)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                //context.Rejected();
                return Task.FromResult<object>(context);
            }

            if (oUser.State == 2)
            {
                context.SetError("invalid_grant", "The user has expired.");
                //context.Rejected();
                return Task.FromResult<object>(context);
            }

            var ticket = new AuthenticationTicket(SetClaimsIdentity(context, oUser), new AuthenticationProperties());

            context.Validated(ticket);

            return Task.FromResult<object>(null);
        }
        private static ClaimsIdentity SetClaimsIdentity(OAuthGrantResourceOwnerCredentialsContext context, User oUser)
        {
            var identity = new ClaimsIdentity("JWT");
            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            identity.AddClaim(new Claim("BusinessID", oUser.BusinessID.ToString()));
            identity.AddClaim(new Claim("ID", oUser.ID.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));

            //var userRoles = context.OwinContext.Get<BookUserManager>().GetRoles(user.Id);
            //foreach (var role in userRoles)
            //{
            //    identity.AddClaim(new Claim(ClaimTypes.Role, role));
            //}

            return identity;
        }

    }
}