using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models
{
    public class WebActionConfComponent
    {
        [JsonPropertyName("actionConfs")]
        public ActionConfs ActionConfs { get; set; }

        [JsonPropertyName("orderUrl")]
        public string OrderUrl { get; set; }

        [JsonPropertyName("shoppingCartUrl")]
        public string ShoppingCartUrl { get; set; }
    }
}
