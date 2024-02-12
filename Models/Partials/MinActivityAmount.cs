using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class MinActivityAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
