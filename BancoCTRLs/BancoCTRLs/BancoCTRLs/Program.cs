void testaArray()
{
    int tamanhoDoArray = 2;
    int[] idades = new int[tamanhoDoArray];

    //insere idades
    for (int i = 0; i < tamanhoDoArray; i++)
    {
        idades[i] = i;
    }

    //le idades
    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"idade {i}: {idades[i]}");
    }

    //media das idades
    int acumuladorDeIdade = 0;
    float media = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        acumuladorDeIdade += idades[i];
    }
    media = (float)acumuladorDeIdade / idades.Length;
    Console.WriteLine($"Media de idades é {media}");
}

void TestaBuscaPalavra()
{
    int iteracoes = 5;
    string[] palavras = new string[iteracoes];

    for (int i = 0; i < iteracoes; i++)
    {
        Console.Write($"Digite a {i + 1}ª palavra: ");
        palavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    bool palavraEncontrada = false;

    foreach (string palavra in palavras)
    {
        if (palavra == busca)
        {
            palavraEncontrada = true;
            break; // Parar o loop ao encontrar a palavra
        }
    }

    if (palavraEncontrada)
    {
        Console.WriteLine("Palavra existe");
    }
    else
    {
        Console.WriteLine("Palavra não encontrada");
    }

}

Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.5, 0);
amostra.SetValue(8.8, 1);
amostra.SetValue(9.9, 2);
amostra.SetValue(4.5, 3);
amostra.SetValue(6.8, 4);

void TestaMediana(Array array) { 




   
        Console.WriteLine("Array para calculo da mediana");

        double[] numerosOrdenados = (double[])array.Clone();

        Console.WriteLine("Não ordenados: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($" {numerosOrdenados[i]}");
        }

        Array.Sort(numerosOrdenados);


       
        Console.WriteLine(" \nOrdenados: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($" {numerosOrdenados[i]}");
        }
    

}
TestaMediana(amostra);






// Mantém o terminal aberto até o usuário pressionar uma tecla
Console.WriteLine(" \nPressione qualquer tecla para sair...");

Console.ReadKey();
