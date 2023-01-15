using System.Net.Http.Headers;
using Newtonsoft.Json;
using OefeningPersonsMvc.Entities;
using OefeningPersonsMVC.ViewModels;

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://localhost:5001");
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    string url = "Home";

    var response = client.GetAsync(url).GetAwaiter().GetResult();
    response.EnsureSuccessStatusCode();
    var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

    List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(result);
    foreach (var person in persons)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Address}");
    }
}
using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://localhost:5001");
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    string url = "Home";

    PersonCreateViewModel personCreateViewModel = new PersonCreateViewModel()
    {
        FirstName = "Jan",
        LastName = "Van den poel",
        Address = "Ellermanstraat 33",
        Gender = 0
    };
    var json = JsonConvert.SerializeObject(personCreateViewModel);
    var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

    var response = client.PostAsync(url, data).GetAwaiter().GetResult();
    var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    Console.WriteLine(result);
}
using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://localhost:5001");
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    string url = "Home";

    var response = client.GetAsync(url).GetAwaiter().GetResult();
    response.EnsureSuccessStatusCode();
    var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

    List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(result);
    foreach (var person in persons)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Address}");
    }
}
Console.ReadKey();
