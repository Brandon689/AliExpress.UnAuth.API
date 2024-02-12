﻿using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class BpSpainFreeReturn
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }
}
