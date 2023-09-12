public class AviaoComercial
{
    private string _modelo;
    private int _anoFabricacao;
    private string _companhiaAerea;
    private bool _emOperacao;

    public string Modelo
    {
        get => _modelo;
        set => _modelo = value;
    }

    public int AnoFabricacao
    {
        get => _anoFabricacao;
        set => _anoFabricacao = value;
    }

    public string CompanhiaAerea
    {
        get => _companhiaAerea;
        set => _companhiaAerea = value;
    }

    public bool EmOperacao
    {
        get => _emOperacao;
        set => _emOperacao = value;
    }

    public AviaoComercial()
    {
        _modelo = string.Empty;
        _anoFabricacao = 0;
        _companhiaAerea = string.Empty;
        _emOperacao = false;
    }

    public AviaoComercial(string modelo, int anoFabricacao, string companhiaAerea, bool emOperacao)
    {
        _modelo = modelo;
        _anoFabricacao = anoFabricacao;
        _companhiaAerea = companhiaAerea;
        _emOperacao = emOperacao;
    }
}
