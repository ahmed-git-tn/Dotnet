using Main.Model;
using System.Text.Json;

var file = File.ReadAllText(@".\Data\MOCK_DATA_PERSONNES.json");
var list = JsonSerializer.Deserialize<List<Person>>(file);
var orderedByFirstName = list.OrderBy(p => p.first_name);
foreach (var item in orderedByFirstName)
{
    Console.WriteLine(item.first_name + " " + item.last_name+ " " + item.email);
    await Task.Delay(500);
}
