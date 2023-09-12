public class Jato
{
    private string _nome;
    private int _velocidade;
    private string _valor;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public int Velocidade
    {
        get => _velocidade;
        set => _velocidade = value;
    }

    public string Valor
    {
        get => _valor;
        set => _valor = value;
    }

    public Jato()
    {
        _nome = string.Empty;
        _velocidade = 0;
        _valor = string.Empty;
    }

    public Jato(string nome, int velocidade, string valor)
    {
        _nome = nome;
        _velocidade = velocidade;
        _valor = valor;
    }
}
