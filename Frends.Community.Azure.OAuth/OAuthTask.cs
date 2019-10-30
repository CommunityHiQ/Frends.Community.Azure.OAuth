using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

#pragma warning disable CS1591

namespace Frends.Community.Azure.OAuth
{
    /// <summary>
    /// Class 
    /// </summary>
    public class OAuthTask
    {
        /// <summary>
        /// Get JWT access token from Azure.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>string AccessToken</returns>
        public static async Task<string> GetAccessToken(OAuthProperties properties, CancellationToken cancellationToken)
        {
            // check for interruptions
            cancellationToken.ThrowIfCancellationRequested();
                        
            var authContext = new AuthenticationContext(properties.AuthContextURL);
            var credential = new ClientCredential(properties.ClientId, properties.ClientSecret);
            AuthenticationResult  result = await authContext.AcquireTokenAsync(properties.Resource, credential);

            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            return result.AccessToken;
        }
    }
}
