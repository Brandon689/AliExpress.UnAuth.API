using AliExpress.UnAuth.API.Models;
using System.Text.Json;

HttpClient _httpClient = new HttpClient();

var htmlString = await Scrape("https://www.aliexpress.com/item/1005005669534694.html");
AliexpressItem item = JsonSerializer.Deserialize<AliexpressItem>(htmlString);

Console.WriteLine(item.PriceComponent.OrigPrice.MaxAmount.Value);

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
