using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class BannerInfo
    {
        [JsonPropertyName("promotionBanner")]
        public PromotionBanner PromotionBanner { get; set; }
    }
}
