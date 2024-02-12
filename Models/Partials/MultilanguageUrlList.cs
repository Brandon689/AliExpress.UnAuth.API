using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class MultilanguageUrlList
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("languageUrl")]
        public string LanguageUrl { get; set; }
    }
}
