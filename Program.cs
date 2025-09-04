Genero pop = new Genero("Pop");

Genero forro = new Genero("Forró");

Artista nandoReis = new Artista("Nando Reis");

Artista manuBatidao = new Artista("Manu Batidão");

Album arcoIris = new Album("Para Quando o Arco-Íris Encontrar o Pote de Ouro (2000)");

Album maquinaDoTempo = new Album("Máquina do Tempo");

Musica musica1 = new Musica("All-Star", pop, nandoReis)
{
    Duracao = 182,
    Disponivel = true
};

Musica musica2 = new Musica("Relicário", pop, nandoReis)
{
    Duracao = 246,
    Disponivel = true
};

Musica musica3 = new Musica("Daqui pra Sempre", forro, manuBatidao)
{
    Duracao = 197,
    Disponivel = true
};


musica1.ExibeFichaTecnicaMusica();
arcoIris.AdicionarMusicaNoAlbum(musica1);
arcoIris.ExibeMusicasAlbum();
nandoReis.AtribuirAlbumAoArtista(arcoIris);
nandoReis.ExibirAlbunsDoArtirsta();










Convidado henry = new Convidado("Henry Jaques");
Convidado tainara = new Convidado("Tainara Leme");
Podcast pod1 = new("Corrida", "Fernanda");
Episodio episodio1 = new Episodio(1, "Piloto", 60);

episodio1.AdicionarConvidadoEpisodio(tainara);
episodio1.AdicionarConvidadoEpisodio(henry);
pod1.AdicionarEpisodio(episodio1);
pod1.ExibeFichaTecnicaPodcast();
Console.WriteLine(episodio1.Resumo);

















