Console.WriteLine("Digite algum nome para ser invertido: ");

string PalavraNormal = Console.ReadLine();

string PalavraInvertida = Inverter(PalavraNormal);
Console.WriteLine(PalavraInvertida);

static string Inverter(string text)
{

    char[] charArray = text.ToCharArray();

    string Ivt = String.Empty;

    for (int i = charArray.Length - 1; i >= 0; i--)
    {
        Ivt += charArray[i];
    }

    return Ivt;
}


