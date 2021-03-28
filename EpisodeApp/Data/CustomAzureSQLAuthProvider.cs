using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace EpisodeApp.Data
{
    public class CustomAzureSQLAuthProvider : SqlAuthenticationProvider
    {
        private static readonly string[] _scope = new string[]
        {
            "https://database.windows.net/.default"
        };
        private static readonly TokenCredential _credential = new DefaultAzureCredential();
        public override Task<SqlAuthenticationToken> AcquireTokenAsync(SqlAuthenticationParameters parameters)
        {
            var tokenRequestContext = new TokenRequestContext(_scope);
            var tokenResult = _credential.GetToken(tokenRequestContext, default);
            return Task.FromResult(new SqlAuthenticationToken(tokenResult.Token, tokenResult.ExpiresOn));
        }

        public override bool IsSupported(SqlAuthenticationMethod authenticationMethod) => authenticationMethod.Equals(SqlAuthenticationMethod.ActiveDirectoryDeviceCodeFlow);

    }
}