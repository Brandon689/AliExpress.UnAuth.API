using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class ActionConfs
    {
        [JsonPropertyName("buyNowBtn")]
        public BuyNowBtn BuyNowBtn { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}
