using System;

public class Reserva
{
    //VARIAVEIS
    Date Entrada {get; set;}
    Date Saida {get; set;}
    Quarto Quarto {get; set;}
    Cliente Cliente {get; set;}
    List<Gasto> Gastos = new List<Gasto>();

    //METODOS
    public void relatório()
    {
        foreach(Gasto g in Gasto )
        {
            Console.Write(g);
        }

    }

    public void Fechamento()
    {
        
    }

    public void AdicionarGasto(Gasto gasto)
    {
        
    }
}
