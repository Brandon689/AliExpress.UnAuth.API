using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class BuyerComponent
    {
        [JsonPropertyName("adultCertificationStatus")]
        public int? AdultCertificationStatus { get; set; }
    }
}
