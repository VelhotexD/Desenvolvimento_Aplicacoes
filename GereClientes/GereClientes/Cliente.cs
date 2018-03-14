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
        
        public List<Compra> compraList = null;

        public Cliente(string nome, int nif)
        {
            this.nome = nome;
            this.nif = nif;
            this.compraList = new List<Compra>();
        }


        public override string ToString()
        {

            return string.Concat(nome,"(",nif,")");
        }


    }
}
