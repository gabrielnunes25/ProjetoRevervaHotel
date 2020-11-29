public class GastoTelefone : Gasto
{
    public abstract IGasto CreateGasto()
    {
        return new Telefone();
    }
}
