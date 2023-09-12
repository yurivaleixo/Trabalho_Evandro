public class Blindado
{
    private string _nome;
    private string _peso;
    private int _qtdeSoldado;
    private string _nacionalidade;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string Peso
    {
        get => _peso;
        set => _peso = value;
    }

    public int QtdeSoldado
    {
        get => _qtdeSoldado;
        set => _qtdeSoldado = value;
    }

    public string Nacionalidade
    {
        get => _nacionalidade;
        set => _nacionalidade = value;
    }

    public Blindado()
    {
        _nome = string.Empty;
        _peso = string.Empty;
        _qtdeSoldado = 0;
        _nacionalidade = string.Empty;
    }

    public Blindado(string nome, string peso, int qtdeSoldado, string nacionalidade)
    {
        _nome = nome;
        _peso = peso;
        _qtdeSoldado = qtdeSoldado;
        _nacionalidade = nacionalidade;
    }
}
