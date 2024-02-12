using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models
{
    public class WebCouponInfoComponent
    {
        [JsonPropertyName("usingNewCouponApi")]
        public bool? UsingNewCouponApi { get; set; }

        [JsonPropertyName("couponList")]
        public List<object> CouponList { get; set; }

        [JsonPropertyName("promotionPanelDTO")]
        public PromotionPanelDTO PromotionPanelDTO { get; set; }

        [JsonPropertyName("couponAttributes")]
        public CouponAttributes CouponAttributes { get; set; }
    }
}
