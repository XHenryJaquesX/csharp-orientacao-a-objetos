class Podcast
{
    private List<Episodio> listaEpisodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios => listaEpisodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
    }

    public void ExibeFichaTecnicaPodcast()
    {
        string palavrasEpisodioEle = listaEpisodios.Count == 1 ? "episódio sendo ele" : "episódios sendo ele";
        Console.WriteLine($"O podcast {Nome} apresentado por {Host} possui {TotalEpisodios} {palavrasEpisodioEle}:\n");
        int numero = 1;
        foreach (Episodio episodio in listaEpisodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine($"Episódio {numero}: {episodio.Titulo}");
            Console.WriteLine($"Resumo: {episodio.Resumo}\n");        
        }
    }
}