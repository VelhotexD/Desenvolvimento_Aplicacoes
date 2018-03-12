using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balburdia
{
    class Coisa
    {
        private string nome;
        private List<int> blist = null;
        private int totalvalores;
        private DateTime hora;

        //List<int> AList = new List<int>();
        //alist.add(1);
        //int elem = alist.count();

        //random rand = new random();
        //blist.add(rand.next());

        public string Nome {
            get
            {
                return nome;
            }
        }


        public List<int> Blist
        {
            get
            {
                return blist;
            }
        }

        public int TotalValores
        {
            get
            {
                return totalvalores;
            }
        }

        public DateTime Hora
        {
            get
            {
                return hora;
            }
        }




        public Coisa(string nome)
        {
            this.nome = nome;
            totalvalores = 0;
            hora = DateTime.Now;
            blist = new List<int>();

        }


        public void InventarValor()
        {

            Random numbrand = new Random();
            int numb = numbrand.Next();
            blist.Add(numb);
            totalvalores = totalvalores + numb;
        }


        public override string ToString()
        {
            string valor = "";

            for (int i = 0; i < blist.Count(); i++)
            {
                valor = valor + ',' + blist[i].ToString(); 
            }
            return string.Concat("Nome: ", Nome, "Valores", valor, "Total", totalvalores);
        }

        
    }
}
