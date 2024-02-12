using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class BlacklistComponent
    {
        [JsonPropertyName("inBlackList")]
        public bool? InBlackList { get; set; }
    }
}
