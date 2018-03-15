using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    public class LinhaCompras
    {
        public string descricao;
        public int valor;

        public LinhaCompras()
        {
            

        }

        public override string ToString()
        {
            return string.Concat(descricao);
        }
    }
}
