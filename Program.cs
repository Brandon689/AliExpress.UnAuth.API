using AliExpress.UnAuth.API.Models;
using System.Text.Json;

HttpClient _httpClient = new HttpClient();


//?spm=a2g0o.detail.1000061.2.f17cDS29DS29OJ&shop_sortType=bestmatch_sort

var htmlString = await Scrape("https://www.aliexpress.com/item/1005006467826169.html");
AliexpressItem item = JsonSerializer.Deserialize<AliexpressItem>(htmlString);
Console.WriteLine(htmlStrinsg);
File.WriteAllText("../../../X.html", htmlStrinsg);
//Console.WriteLine(item.PriceComponent.OrigPrice.MaxAmount.Value);
//Console.WriteLine(item.PriceComponent.OrigPrice.MinAmount.Value);
//Console.WriteLine(item.PriceComponent.OrigPrice.MinPrice.Value);
//Console.WriteLine(item.PriceComponent.OrigPrice.MaxPrice.Value);

//Console.WriteLine(item.PriceComponent.DiscountPrice.MinActivityAmount.Value);
//Console.WriteLine(item.PriceComponent.DiscountPrice.MaxActivityAmount.Value);

//Console.WriteLine(JsonSerializer.Serialize(item.PriceComponent, new JsonSerializerOptions() { WriteIndented=true }));

async Task<string> Scrape(string product)
{
    string content = await _httpClient.GetStringAsync(product);
    string findFragment = "window.runParams = {\n                            data: ";
    int start = content.IndexOf(findFragment);
    content = content.Substring(start);
    content = content.Substring(findFragment.Length);
    int end = content.IndexOf("};");
    content = content[..(end + 1)];
    content = content.Trim();
    content = content[..^1];
    return content;
}

async Task<string> ScrapeAll(string products)
{
    string content = await _httpClient.GetStringAsync(products);
    return content;
}
