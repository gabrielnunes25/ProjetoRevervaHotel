public class Pagamento
{
    float Valor {get; set;}

    public bool PagarCartaoDebito()
    {
        return false;
    }

    public bool PagarCartaoCredtio()
    {
        return true;
    }
}
