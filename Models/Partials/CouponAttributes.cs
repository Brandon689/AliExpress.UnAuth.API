using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class CouponAttributes
    {
        [JsonPropertyName("couponPackageText")]
        public string CouponPackageText { get; set; }
    }
}
