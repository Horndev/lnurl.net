# lnurl.net
Library for Lightning Network URL in C#

## Background

See https://github.com/fiatjaf/awesome-lnurl for some great examples and background on LNURL.

## LNURL-AUTH + MVC

The objective of the library is to enable users to uthenticate on .NET websites using their Lightning wallet.

For example, Bitcoin Lightning Wallet (BLW) supports this.

### Installation

Install like any other MVC Core middleware in your Web App's Startup.cs:

```
services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.LoginPath = "/signin";
    options.LogoutPath = "/signout";
})
.AddLnurlAuth(options =>
{
    options.CallbackPath = "";
    options.AccessDeniedPath = "";
});
```

#### Options

**CallbackPath:*** This is where the wallet will call back
**AccessDeniedPath:*** This is the custom endpoint to direct the user on failed authentication.



