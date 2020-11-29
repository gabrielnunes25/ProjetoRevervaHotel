using System;

public class Reserva
{
    Date Entrada {get; private set};
    Date Saida {get; private set};
    Quarto Quarto {get; private set};
    Cliente Cliente {get; private set};
    List<Gasto> Gastos = new List<Gasto>();


    public void relatório()
    {

    }

    public void Fechamento()
    {

    }

    public void AdicionarGasto(Gasto gasto)
    {
        
    }
}
