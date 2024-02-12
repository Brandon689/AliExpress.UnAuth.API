﻿using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Partials
{
    public class Background
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
