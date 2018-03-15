using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereClientes
{
    public partial class Form1 : Form
    {
        Cliente newcliente = null;
        Compra newcompra = null;
        LinhaCompras newlinhacompras = null;

        public List<Cliente> lcliente = null;

        public Form1()
        {
            InitializeComponent();
            lcliente = new List<Cliente>();

        }



        private void btAddCliente_Click(object sender, EventArgs e)
        {
            Cliente newcliente = new Cliente(tbNome.Text, Int32.Parse(tbNif.Text));
            lcliente.Add(newcliente);

            listBoxCliente.DataSource = null;
            listBoxCliente.DataSource = lcliente;

            tbNome.Text = "";
            tbNif.Text = "";

        }

        private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxCliente.SelectedIndex < 0) {
                listBoxCliente.SelectedIndex = 0;
                newcliente = lcliente[listBoxCliente.SelectedIndex];

            }
            else
            {
                newcliente = lcliente[listBoxCliente.SelectedIndex];
                lbCliente.Text = newcliente.nome;
                lbNif.Text = newcliente.nif.ToString();
                
            }
        }

        private void btCriarCompra_Click(object sender, EventArgs e)
        {
            Compra newcompra = new Compra();

            lcliente[listBoxCliente.SelectedIndex].compraList.Add(newcompra);

            listBoxCompras.DataSource = lcliente[listBoxCliente.SelectedIndex].compraList;
            ComprarTotal();
            atualizar_compra();
        }


        public void Total()
        {

            int valor = 0;
            int total = 0;
            for (int i = 0; i < lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList.Count; i++)

            {

                valor = int.Parse(lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList[i].valor.ToString());
                

                total = total + valor;
            }

           


            llinatotal.Text = string.Concat(total, "€");
        }


        public void ComprarTotal()
        {

            int valor = 0;
            int total = 0;
            for (int i = 0; i < lcliente[listBoxCliente.SelectedIndex].compraList.Count; i++)

            {

                valor = int.Parse(lcliente[listBoxCliente.SelectedIndex].compraList[i].total_compras.ToString());
                

                total = total + valor;
            }




            ltotal.Text = string.Concat(total, "€");
        }



        private void btAddLinha_Click(object sender, EventArgs e)
        {
            LinhaCompras newlinhacompras = new LinhaCompras(tbDescricao.Text, Int32.Parse(tbValor.Text));

            lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList.Add(newlinhacompras);

            Lblinhacompra.DataSource = null;
            Lblinhacompra.DataSource = lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList;

            Total();
            atualizar_lista_compra();
        }



        public void atualizar_compra()
        {

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = lcliente[listBoxCliente.SelectedIndex].compraList;

        }

        public void atualizar_lista_compra()
        {

            Lblinhacompra.DataSource = null;
            Lblinhacompra.DataSource = lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList;

        }


        private void btApagarCompra_Click(object sender, EventArgs e)
        {

            if (listBoxCompras.SelectedIndex != -1)
            {
                lcliente[listBoxCliente.SelectedIndex].compraList.RemoveAt(listBoxCompras.SelectedIndex);
                atualizar_compra();
            }
            else
            {
                MessageBox.Show("É necessario selecionar uma compra para apagar");
            }
        }

        private void btApagarLinha_Click(object sender, EventArgs e)
        {

             lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList.RemoveAt(listBoxCompras.SelectedIndex);
             Lblinhacompra.DataSource = null;
             atualizar_lista_compra();

            
        }

        private void listBoxCompras_Click(object sender, EventArgs e)
        {
            Lblinhacompra.DataSource = null;
            Lblinhacompra.DataSource = lcliente[listBoxCliente.SelectedIndex].compraList[listBoxCompras.SelectedIndex].ListcompraList;
        }

        private void listBoxCliente_Click(object sender, EventArgs e)
        {

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = lcliente[listBoxCliente.SelectedIndex].compraList;
            
        }
    }
}
