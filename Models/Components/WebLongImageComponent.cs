using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models
{
    public class WebLongImageComponent
    {
        [JsonPropertyName("showLongImage")]
        public bool? ShowLongImage { get; set; }
    }
}
