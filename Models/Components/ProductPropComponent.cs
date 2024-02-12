using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class ProductPropComponent
    {
        [JsonPropertyName("showPropGroups")]
        public bool? ShowPropGroups { get; set; }

        [JsonPropertyName("propGroups")]
        public List<object> PropGroups { get; set; }

        [JsonPropertyName("props")]
        public List<Prop> Props { get; set; }
    }
}
