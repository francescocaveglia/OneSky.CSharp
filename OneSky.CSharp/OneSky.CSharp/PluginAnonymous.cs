﻿namespace OneSky.CSharp
{
    internal class PluginAnonymous : IPluginAnonymous
    {
        private const string SingUpAddress = "https://plugin.api.onesky.io/1/accounts/sign-up";
        private const string SingInAddress = "https://plugin.api.onesky.io/1/accounts/sign-in";

        private const string SingUpEmailBody = "email";
        private const string SingInEmailBody = "email";
        private const string SingInPasswordBody = "password";

        public IOneSkyResponse SingUp(string email)
        {
            return OneSkyHelper.CreateAnonymousRequest(SingUpAddress).Body(SingUpEmailBody, email).Post();
        }

        public IOneSkyResponse SingIn(string email, string password)
        {
            return
                OneSkyHelper.CreateAnonymousRequest(SingInAddress)
                    .Body(SingInEmailBody, email)
                    .Body(SingInPasswordBody, password)
                    .Post();
        }
    }
}