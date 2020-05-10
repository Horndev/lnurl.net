using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace LnurlAuth
{
    public class LnurlAuthPostConfigureOptions : IPostConfigureOptions<LnurlAuthOptions>
    {
        private readonly IDataProtectionProvider _dp;

        public LnurlAuthPostConfigureOptions(IDataProtectionProvider dataProtection)
        {
            _dp = dataProtection;
        }

        public void PostConfigure(string name, LnurlAuthOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
