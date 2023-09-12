public class Aeroporto
{
    private string _nome;
    private string _codigoIATA;
    private string _cidade;
    private string _pais;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string CodigoIATA
    {
        get => _codigoIATA;
        set => _codigoIATA = value;
    }

    public string Cidade
    {
        get => _cidade;
        set => _cidade = value;
    }

    public string Pais
    {
        get => _pais;
        set => _pais = value;
    }

    public Aeroporto()
    {
        _nome = string.Empty;
        _codigoIATA = string.Empty;
        _cidade = string.Empty;
        _pais = string.Empty;
    }

    public Aeroporto(string nome, string codigoIATA, string cidade, string pais)
    {
        _nome = nome;
        _codigoIATA = codigoIATA;
        _cidade = cidade;
        _pais = pais;
    }
}
