public class Alimentacao : IGasto
{
    float Valor {get; set;}
    string Sescricao {get; set;}

    public Date GetData()
    {
        return new Date();
    }
}
