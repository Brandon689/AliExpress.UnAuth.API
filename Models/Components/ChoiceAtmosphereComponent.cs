using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class ChoiceAtmosphereComponent
    {
        [JsonPropertyName("serviceBlockIcon")]
        public ServiceBlockIcon ServiceBlockIcon { get; set; }

        [JsonPropertyName("logisticsBlockIcon")]
        public LogisticsBlockIcon LogisticsBlockIcon { get; set; }
    }
}
