using System;
class Plataforma2D

{
    private int proximaPosicao = 0;
    private string[] array;
    private const int tamanhoDaPlataforma = 40;
    private string[,] plataforma;

    // Construtor
    public Plataforma2D()
    {
        plataforma = GeraPlataformaDeAray(); // Inicializa a plataforma
    }

    public void AdicionarElemento(string texto)
    {
        if (proximaPosicao < array.Length)
        {
            array[proximaPosicao] = texto;
            proximaPosicao++;
            Console.WriteLine("Adicionado com sucesso");
        }
        else
        {
            Console.WriteLine("Erro: O array está cheio.");
        }
    }

    string[,] GeraPlataformaDeAray()
    {
        string[,] plataforma = new string[tamanhoDaPlataforma, tamanhoDaPlataforma];

        for (int i = 0; i < tamanhoDaPlataforma; i++)
        {
            for (int j = 0; j < tamanhoDaPlataforma; j++)
            {
                plataforma[i, j] = " ";
            }
        }

        return plataforma;
    }

    void renderizaPlataforma(int x, int y)
    {
        Console.Clear();

        plataforma[y - 1, x] = " ";
        plataforma[y + 1, x] = " ";
        plataforma[y, x - 1] = " ";
        plataforma[y, x + 1] = " ";
        plataforma[y, x] = "O";

        string plataformaString = "";

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

    public void MovimentaLetra()
    {
        int y = 10;
        int x = 10;
        renderizaPlataforma(x, y);

        while (true)
        {
            var tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.W && y > 1)
            {
                y--;
                renderizaPlataforma(x, y);
            }
            if (tecla.Key == ConsoleKey.S && y < tamanhoDaPlataforma - 2)
            {
                y++;
                renderizaPlataforma(x, y);
            }

            if (tecla.Key == ConsoleKey.A && x > 1)
            {
                x--;
                renderizaPlataforma(x, y);
            }
            if (tecla.Key == ConsoleKey.D && x < tamanhoDaPlataforma - 2)
            {
                x++;
                renderizaPlataforma(x, y);
            }

            Thread.Sleep(50);
        }
    }
}
