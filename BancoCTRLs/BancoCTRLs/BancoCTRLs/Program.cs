﻿void testaArray()
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







void testaTecla()
{
    Console.WriteLine("Pressione 'W' para executar uma ação ou 'ESC' para sair...");

    // Loop até o usuário pressionar a tecla ESC
    while (true)
    {
        // Captura a tecla pressionada
        var tecla = Console.ReadKey(true); // 'true' oculta a tecla pressionada no console

        // Verifica se a tecla pressionada foi ESC
        if (tecla.Key == ConsoleKey.Escape)
        {
            Console.WriteLine("Saindo...");
            break; // Sai do loop
        }

        // Verifica se a tecla pressionada foi 'W'
        if (tecla.Key == ConsoleKey.W)
        {
            Console.WriteLine("Você pressionou a tecla 'W'! Executando ação...");
            // Aqui você pode adicionar a lógica que deseja executar
        }
        else
        {
            // Caso a tecla pressionada não seja 'W' nem 'ESC'
            Console.WriteLine($"Você pressionou: {tecla.KeyChar}");
        }
    }
}





int tamanhoDaPlataforma = 40;

string[,] GeraPlataformaDeAray()
{

   
    string[,] plataforma = new string[tamanhoDaPlataforma, tamanhoDaPlataforma];

    for(int i = 0; i < tamanhoDaPlataforma; i++)
    {
        for(int j = 0; j<tamanhoDaPlataforma; j++)
        {
            plataforma[i, j] = " ";
        }
    }

    return plataforma;

    

}

void renderizaPlataforma(string[,] plataforma, int x, int y)
{
    Console.Clear();

    plataforma[y-1,x] = " ";
    plataforma[y+1,x] = " ";
    plataforma[y,x-1] = " ";
    plataforma[y,x+1] = " ";
    plataforma[y, x] = "O";

    string plataformaString= "";
    
    for (int i = 0; i < tamanhoDaPlataforma; i++)
    {
        for (int j = 0; j < tamanhoDaPlataforma; j++)
        {
            plataformaString += plataforma[i, j];
        }
        plataformaString += "\n";
    }
    Console.WriteLine(plataformaString);
    Console.WriteLine($"Coordenadas: x:{x} y:{y}");

}

string[,] plataforma = GeraPlataformaDeAray();



void MovimentaLetra() {
   
    int y = 10;
    int x = 10;

    bool emMovimento = false;

    while (true)
    {
        var tecla = Console.ReadKey(true);

        if(tecla.Key == ConsoleKey.W && y>1)
        {
            y--;
            renderizaPlataforma(plataforma,x,y);
        }
        if (tecla.Key == ConsoleKey.S && y < tamanhoDaPlataforma-2)
        {
            y++;
            renderizaPlataforma(plataforma, x, y);
        }

        if (tecla.Key == ConsoleKey.A && x>1)
        {
            x--;
            renderizaPlataforma(plataforma, x, y);
        }
        if (tecla.Key == ConsoleKey.D && x< tamanhoDaPlataforma-2)
        {
            x++;
            renderizaPlataforma(plataforma, x, y);
        }
        Thread.Sleep(50);
    }
}

MovimentaLetra();

// Mantém o terminal aberto até o usuário pressionar uma tecla
Console.WriteLine(" \nPressione qualquer tecla para sair...");
Console.ReadKey();