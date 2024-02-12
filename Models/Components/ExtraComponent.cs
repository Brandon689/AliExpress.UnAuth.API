using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class ExtraComponent
    {
        [JsonPropertyName("expressionExt")]
        public string ExpressionExt { get; set; }

        [JsonPropertyName("aeOrderFrom")]
        public string AeOrderFrom { get; set; }

        [JsonPropertyName("showCoinAnim")]
        public bool? ShowCoinAnim { get; set; }

        [JsonPropertyName("uiTestInfo")]
        public UiTestInfo UiTestInfo { get; set; }

        [JsonPropertyName("freightExt")]
        public string FreightExt { get; set; }

        [JsonPropertyName("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonPropertyName("detailPageUrl")]
        public string DetailPageUrl { get; set; }

        [JsonPropertyName("envInfo")]
        public EnvInfo EnvInfo { get; set; }

        [JsonPropertyName("complaintUrl")]
        public string ComplaintUrl { get; set; }

        [JsonPropertyName("productDetailImageUrl")]
        public string ProductDetailImageUrl { get; set; }
    }
}
