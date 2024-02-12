using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models
{
    public class MarketingInfo4ChoiceComponent
    {
        [JsonPropertyName("bgColorStart")]
        public string BgColorStart { get; set; }

        [JsonPropertyName("bgColorEnd")]
        public string BgColorEnd { get; set; }

        [JsonPropertyName("blockIcon")]
        public BlockIcon BlockIcon { get; set; }
    }
}
