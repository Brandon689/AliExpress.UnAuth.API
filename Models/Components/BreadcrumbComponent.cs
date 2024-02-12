using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class BreadcrumbComponent
    {
        [JsonPropertyName("categoryUrl")]
        public string CategoryUrl { get; set; }

        [JsonPropertyName("pathList")]
        public List<PathList> PathList { get; set; }

        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; }
    }
}
