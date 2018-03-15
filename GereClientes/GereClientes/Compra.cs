using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    public class Compra
    {

        public DateTime tempo_compra;
        public int total_compras;

        public List<LinhaCompras> ListcompraList = null;

        public Compra()
        {
            tempo_compra = DateTime.Now;
            ListcompraList = new List<LinhaCompras>();
        }

        public override string ToString()
        {
            return string.Concat(tempo_compra,"|", total_compras);
        }
    }
}
