using Azure.Core;
using Azure.Identity;
using Microsoft.Data.SqlClient;
using System;

using System.Threading.Tasks;

namespace EpisodeApp.Data
{
    public class CustomAzureSQLAuthProvider : SqlAuthenticationProvider
    {
        private static readonly string[] _azureSqlScopes = new[]
        {
            "https://database.windows.net/.default"
        };

        private static readonly TokenCredential _credential = new DefaultAzureCredential();
        
        public override Task<SqlAuthenticationToken> AcquireTokenAsync(SqlAuthenticationParameters parameters)
        {
            var tokenRequestContext = new TokenRequestContext(_azureSqlScopes);
            var tokenResult = _credential.GetToken(tokenRequestContext, default);
            return Task.FromResult(new SqlAuthenticationToken(tokenResult.Token, tokenResult.ExpiresOn));
        }

        public override bool IsSupported(SqlAuthenticationMethod authenticationMethod) => authenticationMethod.Equals(SqlAuthenticationMethod.ActiveDirectoryDeviceCodeFlow);
    }
}
