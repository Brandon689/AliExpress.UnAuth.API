using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class CategoryTagComponent
    {
        [JsonPropertyName("falseHair")]
        public bool? FalseHair { get; set; }

        [JsonPropertyName("cardCoupon")]
        public bool? CardCoupon { get; set; }

        [JsonPropertyName("giftCard")]
        public bool? GiftCard { get; set; }
    }
}
