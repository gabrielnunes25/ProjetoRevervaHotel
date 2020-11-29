
public class PagamentoCommand : ICommand
{
    Pagamento Pagamento {get; set;}
    private string _tipo;

    public bool Execute()
    {
        if(_tipo = "debito"){
            pagamento.PagarCartaoDebito();
        }else{
            pagamento.PagarCartaoCredtio();
        }
    }

    public void SetTipo(string tipo)
    {
        _tipo = tipo;
    }
}
