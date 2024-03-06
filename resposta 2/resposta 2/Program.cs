Console.Write("Verificador de numeros para sequência de Fibonacci: ");
int numero = int.Parse(Console.ReadLine());

static bool verificacao(int numero)
{
    int a = 0;
    int b = 1;

    while (b < numero)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }

    return b == numero;
}

if (verificacao(numero))
{
    Console.WriteLine($"O numero {numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O numero {numero} não pertence à sequência de Fibonacci.");
}