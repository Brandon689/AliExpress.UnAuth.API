﻿using System.Text.Json.Serialization;
using AliExpress.UnAuth.API.Models.Partials;

namespace AliExpress.UnAuth.API.Models
{
    public class ModuleLayoutInfo
    {
        [JsonPropertyName("questionAndAnswer")]
        public QuestionAndAnswer QuestionAndAnswer { get; set; }

        [JsonPropertyName("review")]
        public Review Review { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("specification")]
        public Specification Specification { get; set; }
    }
}
