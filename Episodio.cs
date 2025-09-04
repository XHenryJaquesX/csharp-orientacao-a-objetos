class Episodio
{
    private List<Convidado> listaConvidados = new List<Convidado>();

    public Episodio(int numeroEpisodio, string titulo, int duracaoEpisodio)
    {
        Titulo = titulo;
        Numero = numeroEpisodio;
        Duracao = duracaoEpisodio;
    }

    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"O episódio {Numero}-{Titulo} tem duração {Duracao} minutos e conta com os convidados {string.Join(listaConvidados.Count == 2 ? " e " : ", ", listaConvidados.Select(c => c.Nome))}";

    public void AdicionarConvidadoEpisodio(Convidado convidado)
    {
        listaConvidados.Add(convidado);
    }
}