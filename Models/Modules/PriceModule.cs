using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class PriceModule
    {
        [JsonPropertyName("LOT")]
        public string LOT { get; set; }

        [JsonPropertyName("PRE_ORDER_PRICE")]
        public string PREORDERPRICE { get; set; }

        [JsonPropertyName("INSTALLMENT")]
        public string INSTALLMENT { get; set; }

        [JsonPropertyName("DEPOSIT")]
        public string DEPOSIT { get; set; }
    }
}
