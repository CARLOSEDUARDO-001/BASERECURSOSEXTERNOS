
using HtmlAgilityPack;
using XPATH;

namespace XPATH
{
    public class KensLearningCurverScraper : ScraperBase
    {

        public async Task<List<Article>> Scrape()
        {
            string url = "https://kenslearningcurve.com/free-tutorials/";
            string html = await GetHTMLAsync(url);

            HtmlDocument htmlDoc = new();
            htmlDoc.LoadHtml(html);

            HtmlNodeCollection items = htmlDoc.DocumentNode.SelectNodes("//ul[@class='penci-wrapper-data penci-grid penci-shortcode-render']/li");

            List<Article> articles = new();
            
            int incremento = 1;
            int factorial = 4;
            foreach (HtmlNode node in items)
            {

                if (incremento != factorial)
                { 
                  articles.Add(new Article() {

                    Title = node.SelectSingleNode(string.Format("//li[{0}]/article/div[@class='content-list-right content-list-center']/div[@class='header-list-style']/h2/a", incremento)).InnerHtml,
                    Description = node.SelectSingleNode(string.Format("//li[{0}]/article/div[@class='content-list-right content-list-center']/div[@class='item-content entry-content']/p", incremento)).InnerText,
                    Link = new Uri(node.SelectSingleNode(string.Format("//li[{0}]/article/div/a", incremento)).GetAttributeValue("href", string.Empty))
                  });
                    incremento++;
                }
                else
                {
                    factorial += 4;
                    incremento++;
                }
                
            }

            return articles;
        }

    }
}
