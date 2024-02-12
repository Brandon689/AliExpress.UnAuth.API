using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class AbTestComponent
    {
        [JsonPropertyName("detailNewVersion")]
        public int? DetailNewVersion { get; set; }

        [JsonPropertyName("openDescHover")]
        public bool? OpenDescHover { get; set; }

        [JsonPropertyName("hideCustomerService")]
        public bool? HideCustomerService { get; set; }

        [JsonPropertyName("rmStoreLevelAB")]
        public bool? RmStoreLevelAB { get; set; }
    }
}
