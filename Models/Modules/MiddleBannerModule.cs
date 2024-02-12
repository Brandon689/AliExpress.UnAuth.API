using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Modules
{
    public class MiddleBannerModule
    {
        [JsonPropertyName("END_IN")]
        public string ENDIN { get; set; }

        [JsonPropertyName("DAYS")]
        public string DAYS { get; set; }

        [JsonPropertyName("DAY")]
        public string DAY { get; set; }

        [JsonPropertyName("STARTS_IN")]
        public string STARTSIN { get; set; }
    }
}
