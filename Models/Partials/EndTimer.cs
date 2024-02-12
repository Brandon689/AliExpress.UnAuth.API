using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class EndTimer
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("endTime")]
        public object EndTime { get; set; }

        [JsonPropertyName("showCountdown")]
        public string ShowCountdown { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
