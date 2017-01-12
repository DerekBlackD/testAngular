using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
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

namespace ET.CRM.SGC.Web.Auth.Provider
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

            //var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

            //ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);

            BizUser oBizUser = new BizUser();
            String EncodePassword = ET.CRM.SGC.Utilities.SecurityTools.EncryptPassword(context.Password);
            int intResul = oBizUser.ValidateLogin(context.UserName, EncodePassword);

            if (intResul == 0)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                context.Rejected();
                return Task.FromResult<object>(null);
            }

            //if (!user.EmailConfirmed)
            //{
            //    context.SetError("invalid_grant", "User did not confirm email.");
            //    return;
            //}

            //ClaimsIdentity oAuthIdentity = await GenerateUserIdentityAsync(userManager, "JWT");

            //var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            //identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            //identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
            //context.Validated(identity);

            var ticket = new AuthenticationTicket(SetClaimsIdentity(context), new AuthenticationProperties());

            context.Validated(ticket);
            return Task.FromResult<object>(null);
        }
        private static ClaimsIdentity SetClaimsIdentity(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity("JWT");
            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            identity.AddClaim(new Claim("sub", context.UserName));
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