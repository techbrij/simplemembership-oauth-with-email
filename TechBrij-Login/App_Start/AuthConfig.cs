using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using TechBrij_Login.Models;

namespace TechBrij_Login
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "Z6IcaCRZ75fQXuyyZiKC0w",
                consumerSecret: "Uz545MDNn8GafiK19yjkcYoKF6O9bpbXIoPwjpcUA");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "126191344226024",
                appSecret: "6bdb19bbffd4fb7f7fc015ae76ab5a03");

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
