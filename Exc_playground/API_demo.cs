using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

//api https://xkcd.com/info.0.json

namespace Exc_playground
{
    public class API_demo
    {
        private HttpClient ApiClient { get; set; }

        public void Call()
        {
            InitializeClient();
            Console.WriteLine("Provide image number");
            int imageNumber = Int32.Parse(Console.ReadLine());
            var comic = LoadComic(imageNumber);
            Console.WriteLine(comic.Result.Img);
        }

        private void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://xkcd.com/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async Task<ComicModel> LoadComic(int comicNumber = 0)
        {
            string url;

            if(comicNumber > 0)
                url = $"https://xkcd.com/{ comicNumber }/info.0.json";
            else
                url = "https://xkcd.com/info.0.json";

            using(HttpResponseMessage response = await ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();
                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
