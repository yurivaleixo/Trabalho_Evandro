public class Macarrao
{
    private string _nome;
    private string _tipo;
    private string _molho;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string Tipo
    {
        get => _tipo;
        set => _tipo = value;
    }

    public string Molho
    {
        get => _molho;
        set => _molho = value;
    }

    public Macarrao()
    {
        _nome = string.Empty;
        _tipo = string.Empty;
        _molho = string.Empty;
    }

    public Macarrao(string nome, string tipo, string molho)
    {
        _nome = nome;
        _tipo = tipo;
        _molho = molho;
    }
}
