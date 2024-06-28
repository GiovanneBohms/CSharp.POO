Musica musica1 = new Musica();
musica1.Nome = "jao";
musica1.Artista = "Peter";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Angrylaine";
musica2.Artista = "Elaine";
musica2.Duracao = 280;
musica2.Disponivel = true;
Console.WriteLine(musica2.Disponivel);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();