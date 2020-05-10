using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace LnurlAuth
{
    public class LnurlAuthHandler : RemoteAuthenticationHandler<LnurlAuthOptions>
    {
        public LnurlAuthHandler(IOptionsMonitor<LnurlAuthOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) 
            : base(options, logger, encoder, clock)
        {
        }

        protected override Task<HandleRequestResult> HandleRemoteAuthenticateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
