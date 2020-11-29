using System;

public abstract class Gasto
{
    IGasto Gasto {get; set;}
    Date Data = Gasto.GetData();

    public abstract IGasto CreateGasto();
}
