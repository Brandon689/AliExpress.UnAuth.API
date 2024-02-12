using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class ProductDescComponent
    {
        [JsonPropertyName("descriptionUrl")]
        public string DescriptionUrl { get; set; }
    }
}
