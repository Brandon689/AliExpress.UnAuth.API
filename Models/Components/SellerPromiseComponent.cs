using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class SellerPromiseComponent
    {
        [JsonPropertyName("returnPolicyGuarantees")]
        public List<object> ReturnPolicyGuarantees { get; set; }

        [JsonPropertyName("hasOverseaWarehouse")]
        public bool? HasOverseaWarehouse { get; set; }

        [JsonPropertyName("hasNoReasonFreeReturn")]
        public bool? HasNoReasonFreeReturn { get; set; }

        [JsonPropertyName("warranyDetailMap")]
        public WarranyDetailMap WarranyDetailMap { get; set; }

        [JsonPropertyName("serviceDetails")]
        public ServiceDetails ServiceDetails { get; set; }

        [JsonPropertyName("sellerGuaranteePromiseList")]
        public List<object> SellerGuaranteePromiseList { get; set; }

        [JsonPropertyName("returnPromise")]
        public ReturnPromise ReturnPromise { get; set; }
    }
}
