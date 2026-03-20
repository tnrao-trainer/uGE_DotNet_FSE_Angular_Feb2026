using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string data = await GetWebContentAsync("https://www.w3schools.com/angular/customers.php");
        Console.WriteLine(data.Substring(0, 200)); // Preview first 200 chars

        Console.ReadLine();
    }

    static async Task<string> GetWebContentAsync(string url)
    {
        HttpClient client = new HttpClient();
        return await client.GetStringAsync(url);
    }
}