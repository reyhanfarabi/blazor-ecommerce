using HtmlAgilityPack;

namespace BlazorEcommerce.Services.CurrencyService;

public class CurrencyService
{
    private HttpClient _httpClient { get; set; }

    public CurrencyService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<float> GetExchangeRate()
    {
        string html = await GetExchangeRateHTMLSource();

        HtmlDocument htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);

        // get usd to idr exhange rate cell by using xpath
        var nodes = htmlDoc.DocumentNode.SelectNodes("/html/body/div[3]/div/div[2]/div[2]/table/tbody/tr[1]/td[3]/div");
        string rate = nodes[0].FirstChild.InnerText;

        return float.Parse(string.Join("", rate.Split('.')).Replace(',', '.'));
    }

    private async Task<string> GetExchangeRateHTMLSource()
    {
        var response = await _httpClient.GetStringAsync("https://fiskal.kemenkeu.go.id/informasi-publik/kurs-pajak");
        return response;
    }
}
