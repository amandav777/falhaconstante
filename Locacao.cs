using System;

public class Locacao
{
    public Cliente Cliente { get; }
    public Filme Filme { get; }

    public Locacao(Cliente cliente, Filme filme)
    {
        if (filme.UnidadesDisponiveis <= 0)
        {
            throw new ArgumentException("O filme não está disponível para locação.");
        }

        Cliente = cliente;
        Filme = filme;
    }
}
