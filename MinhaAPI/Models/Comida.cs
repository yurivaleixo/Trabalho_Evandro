public class Comida
{
    private string _nome;
    private string _tipo;
    private int _caloriasPorPorcao;

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

    public int CaloriasPorPorcao
    {
        get => _caloriasPorPorcao;
        set => _caloriasPorPorcao = value;
    }

    public Comida()
    {
        _nome = string.Empty;
        _tipo = string.Empty;
        _caloriasPorPorcao = 0;
    }

    public Comida(string nome, string tipo, int caloriasPorPorcao)
    {
        _nome = nome;
        _tipo = tipo;
        _caloriasPorPorcao = caloriasPorPorcao;
    }
}
