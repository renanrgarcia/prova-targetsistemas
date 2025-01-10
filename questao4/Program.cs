using questao4;

List<Estado> estados = new List<Estado>
    {
        new Estado { Nome = "SP", Faturamento = 67836.43 },
        new Estado { Nome = "RJ", Faturamento = 36678.66 },
        new Estado { Nome = "MG", Faturamento = 29229.88 },
        new Estado { Nome = "ES", Faturamento = 27165.48 },
        new Estado { Nome = "Outros", Faturamento = 19849.53 }
    };

double total = estados.Sum(e => e.Faturamento);

foreach (var estado in estados)
{
    Console.WriteLine($"{estado.Nome} - {estado.Faturamento / total:P}");
}