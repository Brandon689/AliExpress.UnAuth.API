using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models
{
    public class PlazaSellerServiceComponent
    {
        [JsonPropertyName("warranty")]
        public Warranty Warranty { get; set; }

        [JsonPropertyName("hasWarrantyInfo")]
        public bool? HasWarrantyInfo { get; set; }
    }
}
