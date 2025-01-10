Console.WriteLine("Digite um número inteiro positivo para saber se ele pertence à sequencia de Fibonacci: ");

int numero = int.Parse(Console.ReadLine());

if (PertenceFibonacci(numero))
    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
else
    Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");

static bool PertenceFibonacci(int numero)
{
    if (numero < 0)
    {
        return false;
    }

    if (numero == 0 || numero == 1)
    {
        return true;
    }

    int a = 0, b = 1, c = 1;
    while (c <= numero)
    {
        if (c == numero)
        {
            return true;
        }
        a = b;
        b = c;
        c = a + b;
    }
    return false;
}