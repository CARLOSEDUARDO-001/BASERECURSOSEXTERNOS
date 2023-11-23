using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace XPATH
{
    public partial class MicrosoftScraper : ScraperBase
    {
        /*
        public async Task<List<Article>> Scrape()
        {
            string url = "https://devblogs.microsoft.com/dotnet/category/csharp/";
            string html = await GetHTMLAsync(url);

            HtmlDocument htmlDoc = new();
            htmlDoc.LoadHtml(html);

            HtmlNodeCollection items = htmlDoc.DocumentNode.SelectNodes("//div[@class='col-md-12 content-area']/article");
            List<Article> articles = new();

            foreach (HtmlNode node in items)
            {
                string description = DescriptionRegEx()
                    .Matches(node.SelectSingleNode("div/div/div[@class='entry-content col-md-8']")
                    .InnerHtml)[0]
                    .Groups[1]
                    .Value
                    .Trim();
                articles.Add(new()
                {
                    Title = node.SelectSingleNode("div/div/div[@class='entry-content col-md-8']/header/h2/a").InnerHtml,
                    Description = description,
                    Link = new Uri(node.SelectSingleNode("div/div/div[@class='entry-content col-md-8']/header/h2/a").GetAttributeValue("href", string.Empty)),
                    ThumbnailUri = new Uri(node.SelectSingleNode("div/div/div/img").GetAttributeValue("data-src", string.Empty))
                });


            }
            return articles;

        }
        [GenerateRegex("<!-- .entry-header -->(.*)<footer class=\"entry-footer\">", RegexOptions.Multiline | RegexOptions.Singleline)]
        private static partial Regex DescriptionRegEx();
        */
    }

}
