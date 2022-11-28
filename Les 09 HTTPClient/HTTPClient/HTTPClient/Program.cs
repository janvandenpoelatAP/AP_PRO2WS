using HTTPClient;
using Newtonsoft.Json;
using System.Net.Http.Headers;

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://api.github.com");
    client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    var url = "repos/symfony/symfony/contributors";
    var response = client.GetAsync(url).GetAwaiter().GetResult();
    response.EnsureSuccessStatusCode();
    var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

    List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(result);
    foreach (var contributor in contributors)
    {
        Console.WriteLine($"{contributor.Login}: {contributor.Contributions}");
    }
}