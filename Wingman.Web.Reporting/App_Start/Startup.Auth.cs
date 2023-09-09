using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wingman.Web.Reporting
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = "https://localhost:7048",
                ClientId = "Wingman.Dektop",
                ClientSecret = "tE!st007",
                //RedirectUri = "http://localhost:49816/signin-oidc",
                //PostLogoutRedirectUri = "http://localhost:49816", //Same value as set on Config.cs on IdentityServer 
                ResponseType = "id_token token", // to get id_token + access_token 
                RequireHttpsMetadata = false,
                TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    NameClaimType = "name"
                }, // This is to set Identity.Name 
                SignInAsAuthenticationType = "Cookies"
            });
        }
    }
}