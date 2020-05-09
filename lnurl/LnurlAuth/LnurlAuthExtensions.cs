using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authentication;

namespace LnurlAuth
{
    public static class LnurlAuthExtensions
    {
        public static AuthenticationBuilder AddLnurlAuth([NotNull] this AuthenticationBuilder builder)
        {
            // Add the builder extensions here...

            return builder;//.AddRemoteScheme<TOptions, THandler, TService>(authenticationScheme, displayName, configureOptions); 

            // this is how OAauth is done: https://github.com/dotnet/aspnetcore/blob/1f76cce14ac4e4698a554b65a24f28000b50396e/src/Security/Authentication/OAuth/src/OAuthExtensions.cs

        }
    }
}
