using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class WebViewComponent
    {
        [JsonPropertyName("viewName")]
        public string ViewName { get; set; }
    }
}
