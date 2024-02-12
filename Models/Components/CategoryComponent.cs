using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API.Models.Components
{
    public class CategoryComponent
    {
        [JsonPropertyName("topCategoryId")]
        public int? TopCategoryId { get; set; }

        [JsonPropertyName("kidBaby")]
        public bool? KidBaby { get; set; }

        [JsonPropertyName("secondLevelCategoryId")]
        public int? SecondLevelCategoryId { get; set; }
    }
}
