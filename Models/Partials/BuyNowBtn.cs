using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class BuyNowBtn
    {
        [JsonPropertyName("bgColorStart")]
        public string BgColorStart { get; set; }

        [JsonPropertyName("bgColorEnd")]
        public string BgColorEnd { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }

        [JsonPropertyName("textColor")]
        public string TextColor { get; set; }
    }
}
