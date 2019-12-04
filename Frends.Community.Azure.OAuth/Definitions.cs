using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS1591

namespace Frends.Community.Azure.OAuth
{
    public class OAuthProperties
    {
        /// <summary>
        /// Argument for new AuthenticationContext(*AuthContextURL*);
        /// </summary>
        [DisplayName("Azure login url + TenantId")]
        [DefaultValue("https://login.windows.net/[TenantId]")]
        [DisplayFormat(DataFormatString = "Text")]
        public string AuthContextURL { get; set; }

        /// <summary>
        /// Resource name for authContext.AcquireTokenAsync(*Resource*, credential);
        /// </summary>
        [DisplayName("Resource name")]
        [DefaultValue("https://management.azure.com/")]
        [DisplayFormat(DataFormatString = "Text")]
        public string Resource { get; set; }

        /// <summary>
        /// Client ID from Azure
        /// </summary>
        [DisplayName("Azure ClientId")]
        [DefaultValue("XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX")]
        [DisplayFormat(DataFormatString = "Text")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret from Azure
        /// </summary>
        [PasswordPropertyText]
        public string ClientSecret { get; set; }
    }
}
