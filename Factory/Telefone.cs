public class Telefone : IGasto
{
    float Valor { get; set; }
    float Duracao { get; set; }

    public Date GetData()
    {
        return new Date();
    }
}
