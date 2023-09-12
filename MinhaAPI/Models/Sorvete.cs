public class Sorvete
{
    private string _sabor;
    private int _quantidade;
    private string _marca;

    public string Sabor
    {
        get => _sabor;
        set => _sabor = value;
    }

    public int Quantidade
    {
        get => _quantidade;
        set => _quantidade = value;
    }

    public string Marca
    {
        get => _marca;
        set => _marca = value;
    }

    public Sorvete()
    {
        _sabor = string.Empty;
        _quantidade = 0;
        _marca = string.Empty;
    }

    public Sorvete(string sabor, int quantidade, string marca)
    {
        _sabor = sabor;
        _quantidade = quantidade;
        _marca = marca;
    }
}
