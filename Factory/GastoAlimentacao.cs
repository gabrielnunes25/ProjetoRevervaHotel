public class GastoAlimentacao : Gasto
{
    public abstract IGasto CreateGasto()
    {
        return new Alimentacao();
    }
}
