public class Cliente
{
    public int IdCliente { get; }
    public string Nome { get; }

    public Cliente(int idCliente, string nome)
    {
        IdCliente = idCliente;
        Nome = nome;
    }
}
