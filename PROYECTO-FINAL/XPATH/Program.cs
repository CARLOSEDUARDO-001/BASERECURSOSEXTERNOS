namespace XPATH
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            KensLearningCurverScraper kensLearningCurverScraper = new();
            MicrosoftScraper microsoftScraper = new();

            List<Article> articles = await kensLearningCurverScraper.Scrape();
           // articles.AddRange(await microsoftScraper.Scrape());

            foreach (Article article in articles)
            {
                Console.WriteLine("Titulo : "+article.Title);
                Console.WriteLine("Descripcion : "+article.Description);
                Console.WriteLine("Link Articulo : "+article.Link);
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
            }

        }
    }
}