using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class BuriedLogComponent
    {
        [JsonPropertyName("buriedData")]
        public string BuriedData { get; set; }

        [JsonPropertyName("priceCenterBuriedData")]
        public string PriceCenterBuriedData { get; set; }

        [JsonPropertyName("choice3")]
        public bool? Choice3 { get; set; }
    }
}
