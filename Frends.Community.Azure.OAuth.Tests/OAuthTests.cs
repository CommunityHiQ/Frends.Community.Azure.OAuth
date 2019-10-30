using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using TestConfigurationHandler;

namespace Frends.Community.Azure.OAuth.Tests
{
    public class Tests
    {
        private OAuthProperties props;

        [SetUp]
        public void Setup()
        {
            // from C:\VSTestConfiguration\Config.json . See Config_template.json

            string tenantId = ConfigHandler.ReadConfigValue("Frends.Community.Azure.OAuth.TenantId");

            props = new OAuthProperties()
            {
                AuthContextURL = ConfigHandler.ReadConfigValue("Frends.Community.Azure.OAuth.AuthContextURLPrefix") + tenantId,
                Resource = ConfigHandler.ReadConfigValue("Frends.Community.Azure.OAuth.Resource"),
                ClientId = ConfigHandler.ReadConfigValue("Frends.Community.Azure.OAuth.ClientId"),
                ClientSecret = ConfigHandler.ReadConfigValue("Frends.Community.Azure.OAuth.ClientSecret")
            };
        }

        /// <summary>
        /// Get token from Azure
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task TestAccessToken()
        {          
            var token = await Frends.Community.Azure.OAuth.OAuthTask.GetAccessToken(props, new CancellationToken()
                );

            Assert.IsTrue(token!=null);
        }
    }
}