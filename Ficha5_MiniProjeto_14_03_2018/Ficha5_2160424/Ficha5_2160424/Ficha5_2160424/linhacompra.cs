using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5_2160424
{
    public class Linhacompra
    {

        string descricao;
        double valor;


        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Linhacompra(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }




        public override string ToString()
        {
            return descricao;
        }
    }
}