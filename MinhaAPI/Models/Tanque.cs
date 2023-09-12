public class Tanque
{
    private string _nome;
    private string _peso;
    private string _tipoMunicao;
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

    public string TipoMunicao
    {
        get => _tipoMunicao;
        set => _tipoMunicao = value;
    }

    public string Nacionalidade
    {
        get => _nacionalidade;
        set => _nacionalidade = value;
    }

    public Tanque()
    {
        _nome = string.Empty;
        _peso = string.Empty;
        _tipoMunicao = string.Empty;
        _nacionalidade = string.Empty;
    }

    public Tanque(string nome, string peso, string tipoMunicao, string nacionalidade)
    {
        _nome = nome;
        _peso = peso;
        _tipoMunicao = tipoMunicao;
        _nacionalidade = nacionalidade;
    }
}
