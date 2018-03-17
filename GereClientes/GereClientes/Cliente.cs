using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    public class Cliente
    {
        public string nome;
        public int nif;
        public int total_clientes;
        public int total;
        
        public List<Compra> compraList = null;

        public Cliente(string nome, int nif)
        {
            this.nome = nome;
            this.nif = nif;
            compraList = new List<Compra>();
            total = 0;
        }


        public override string ToString()
        {

            return string.Concat(nome,"(",nif,")");
        }


    }
}
