
using Newtonsoft.Json;
using questao3;

string filePath = Path.Combine(Directory.GetCurrentDirectory(), "dados.json");

string json = File.ReadAllText(filePath);

List<Dados>? dados = JsonConvert.DeserializeObject<List<Dados>>(json);

double valorMaximo = dados.Max(d => d.Valor);
double valorMinimo = dados.Min(d => d.Valor);
double media = dados.Average(d => d.Valor);
int diasAcimaDaMedia = dados.Count(d => d.Valor > media);

Console.WriteLine($"Valor máximo: {valorMaximo:F2}");
Console.WriteLine($"Valor mínimo: {valorMinimo}");
Console.WriteLine($"Média: {media:F2}");
Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
