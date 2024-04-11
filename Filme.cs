public class Filme
{
    public int IdFilme { get; }
    public string Titulo { get; }
    public string Genero { get; }
    public int UnidadesDisponiveis { get; }

    public Filme(int idFilme, string titulo, string genero, int unidadesDisponiveis)
    {
        IdFilme = idFilme;
        Titulo = titulo;
        Genero = genero;
        UnidadesDisponiveis = unidadesDisponiveis;
    }
}
