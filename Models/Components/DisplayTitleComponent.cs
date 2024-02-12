using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class DisplayTitleComponent
    {
        [JsonPropertyName("origTitle")]
        public bool? OrigTitle { get; set; }

        [JsonPropertyName("orig")]
        public bool? Orig { get; set; }

        [JsonPropertyName("transTitle")]
        public bool? TransTitle { get; set; }

        [JsonPropertyName("trans")]
        public bool? Trans { get; set; }
    }
}
