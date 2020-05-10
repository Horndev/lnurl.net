using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace LnurlAuth
{
    public static class LnurlAuthExtensions
    {
        public static AuthenticationBuilder AddLnurlAuth([NotNull] this AuthenticationBuilder builder)
        {
            // Add the builder extensions here...

            return builder;//.AddLnurlAuth(LnurlAuthAuthenticationDefaults.AuthenticationScheme, options => { });

            // this is how OAauth is done: https://github.com/dotnet/aspnetcore/blob/1f76cce14ac4e4698a554b65a24f28000b50396e/src/Security/Authentication/OAuth/src/OAuthExtensions.cs

        }

        public static AuthenticationBuilder AddLnurlAuth(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<LnurlAuthOptions> configuration)
        {
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<LnurlAuthOptions>, LnurlAuthPostConfigureOptions>());
            return builder;//.AddLnurlAuth(LnurlAuthAuthenticationDefaults.AuthenticationScheme, configuration);
        }
    }
}
