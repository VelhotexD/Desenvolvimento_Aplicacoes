using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5_2160424
{
    public class Cliente
    {

        private string nome;
        private int nif;
        private float total;


        public string Nome { get; set; }

        public int NIF { get; set; }

        public float Total { get; set; }

        public Cliente(string nome, int nif, float total)
        {
            Nome = nome;
            NIF = nif;
            Total = total;
        }

        
        

        public override string ToString()
        {
            return Nome;
        }
    }
}
