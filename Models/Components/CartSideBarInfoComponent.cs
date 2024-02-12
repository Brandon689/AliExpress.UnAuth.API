using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class CartSideBarInfoComponent
    {
        [JsonPropertyName("hideCartSideBar")]
        public bool? HideCartSideBar { get; set; }

        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }
    }
}
