using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models
{
    public class BannerComponent
    {
        [JsonPropertyName("promotionBannerInfo")]
        public PromotionBannerInfo PromotionBannerInfo { get; set; }

        [JsonPropertyName("bannerType")]
        public string BannerType { get; set; }
    }
}
