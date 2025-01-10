Console.WriteLine("Digite o texto que deseja inverter: ");

string texto = Console.ReadLine();

List<char> novoTexto = new List<char>();

for (int i = texto.Length - 1; i >= 0; i--)
{
    novoTexto.Add(texto[i]);
}

Console.WriteLine([.. novoTexto]);