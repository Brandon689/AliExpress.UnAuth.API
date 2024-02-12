using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class Message
    {
        [JsonPropertyName("iconAddress")]
        public string IconAddress { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }

        [JsonPropertyName("actionTarget")]
        public string ActionTarget { get; set; }
    }
}
