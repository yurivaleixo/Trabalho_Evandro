public class Carro
{
    private int _id;
    private String _placa;
    private String _descricao;

     public int Id
    {
        get => _id;
        set => _id = value;
    }
    public string Placa
    {
        get => _placa;
        set => _placa = value;
    }
    public string Descricao
    {
        get => _descricao;
        set => _descricao = value;
    }
    public Carro()
    {   
        _placa = string.Empty;
        _descricao = string.Empty;
        _id = 0;
    }
    public Carro(string placa, string descricao, int id){
        _placa = placa;
        _descricao = descricao; 
        _id = id;
    }
}