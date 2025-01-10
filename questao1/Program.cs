int Somar(int indice)
{
    int soma = 0;
    for (int k = 0; k <= indice; k++)
    {
        soma += k;
    }
    return soma;
}

Console.WriteLine(Somar(13)); // 91