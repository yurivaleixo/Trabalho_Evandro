public class Passagem
{
    private string _destino;
    private float _preco;
    private string _companhiaAerea;

    public string Destino
    {
        get => _destino;
        set => _destino = value;
    }

    public float Preco
    {
        get => _preco;
        set => _preco = value;
    }

    public string CompanhiaAerea
    {
        get => _companhiaAerea;
        set => _companhiaAerea = value;
    }

    public Passagem()
    {
        _destino = string.Empty;
        _preco = 0f;
        _companhiaAerea = string.Empty;
    }

    public Passagem(string destino, float preco, string companhiaAerea)
    {
        _destino = destino;
        _preco = preco;
        _companhiaAerea = companhiaAerea;
    }
}
