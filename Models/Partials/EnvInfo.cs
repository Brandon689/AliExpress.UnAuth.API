using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class EnvInfo
    {
        [JsonPropertyName("domestic")]
        public bool? Domestic { get; set; }

        [JsonPropertyName("traceId")]
        public string TraceId { get; set; }

        [JsonPropertyName("crawler")]
        public bool? Crawler { get; set; }
    }
}
