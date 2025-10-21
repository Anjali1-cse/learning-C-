namespace FetchingDatafromAPI
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    internal class Program
    {
        static async Task GetWebsiteContentAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string data = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
                Console.WriteLine("Fetched Data:");
                Console.WriteLine(data);
            }
        }
        static async Task Main()
        {
            Console.WriteLine("Fetching data from API...");
            await GetWebsiteContentAsync();
            Console.WriteLine("Done!");
        }
    }
}
