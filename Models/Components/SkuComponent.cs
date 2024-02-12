using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class SkuComponent
    {
        [JsonPropertyName("selectedSkuAttr")]
        public string SelectedSkuAttr { get; set; }

        [JsonPropertyName("hasSkuProperty")]
        public bool? HasSkuProperty { get; set; }

        [JsonPropertyName("productSKUPropertyList")]
        public List<ProductSKUPropertyList> ProductSKUPropertyList { get; set; }

        [JsonPropertyName("skuPropertyJson")]
        public string SkuPropertyJson { get; set; }
    }
}
