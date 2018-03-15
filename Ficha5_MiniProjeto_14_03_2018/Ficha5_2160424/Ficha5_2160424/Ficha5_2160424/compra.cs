using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5_2160424
{
    public class Compra
{

    private string datahora;
    private float total;


    public string Datahora { get; set; }
    public float Total { get; set; }

    public Compra(string datahora, int nif, float total)
    {
        Datahora = datahora;
        Total = total;
    }




    public override string ToString()
    {
        return datahora;
    }
}
}