public class Pagar
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void Invoker()
    {
        _command.Execute();
    }
}
