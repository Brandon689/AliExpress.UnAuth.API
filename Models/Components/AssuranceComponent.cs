using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class AssuranceComponent
    {
        [JsonPropertyName("assuranceDetails")]
        public AssuranceDetails AssuranceDetails { get; set; }
    }
}
