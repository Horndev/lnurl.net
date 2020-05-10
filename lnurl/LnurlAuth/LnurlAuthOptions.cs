using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace LnurlAuth
{
    public class LnurlAuthOptions : RemoteAuthenticationOptions
    {
        public LnurlAuthOptions()
        {
            // TODO
            ClaimsIssuer = LnurlAuthDefaults.Issuer;

            CallbackPath = LnurlAuthDefaults.CallbackPath;

        }

        /// <summary>
        /// Gets or sets the URI where the client will be redirected to authenticate.
        /// </summary>
        public string AuthorizationEndpoint { get; set; }
    }
}
