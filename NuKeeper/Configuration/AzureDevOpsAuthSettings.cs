using System;

namespace NuKeeper.Configuration
{
    public class AzureDevOpsAuthSettings
    {
        public AzureDevOpsAuthSettings(Uri apiBase, string token)
        {
            ApiBase = apiBase;
            Token = token;
        }

        public Uri ApiBase { get; }
        public string Token { get; }
    }
}
