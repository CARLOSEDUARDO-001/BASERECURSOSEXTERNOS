using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPATH
{
    public class ScraperBase
    {
        public async Task<string> GetHTMLAsync(string url)
        {
            //metodo que envia solicitud a https://kenslearningcurve.com/free-tutorials/ 
            HttpClient client = new();
            HttpRequestMessage request = new(HttpMethod.Get, url);
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();
            throw new Exception($"Request to {url} failed.");
        }
    }
}
