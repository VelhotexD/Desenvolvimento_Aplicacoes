using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha5_2160424
{
    public partial class Form1 : Form
    {

        //Variaveis deste tutorial: https://www.youtube.com/watch?v=EbrGoUqbb-A
        public struct Pedido
        {
            public string item;
            public double preco;
        }

        const double TAX = 0.06;
        Pedido pedido = new Pedido();

        static double subtotal = 0;
        static double totaltax = 0;
        static double total = 0;
//        string totalfinal = "PREÇO FINAL: \n";

        

        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnadicionarcliente_Click(object sender, EventArgs e)
        {
            if (this.txtboxNomeCliente.Text != "" && this.txtboxNifCliente.Text != "")
            {
                lstboxclientes.Items.Add(this.txtboxNomeCliente.Text + '-' + this.txtboxNifCliente.Text);
                
                    
                this.txtboxNomeCliente.Focus();
                this.txtboxNifCliente.Focus();
                this.txtboxNomeCliente.Clear();
                this.txtboxNifCliente.Clear();

                

            }

           
        }

        private void lblcliente_Click(object sender, EventArgs e)
        {

         //   lblcliente.Text = lstboxclientes.SelectedItem.ToString();

        }

        private void lblcliente_TextChanged(object sender, EventArgs e)
        {
           // lblcliente.Text = lstboxclientes.GetItemText(txtboxNomeCliente.SelectedText);
        }

        private void lstboxclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstboxclientes.SelectedItem != null)
            {
                
                //string[] nome = lstboxclientes.SelectedItem.ToString().Split('(');
                //lblcliente.Text = nome[0].ToString();

                //string[] nif = lstboxclientes.SelectedItem.ToString().Split(')');
                //lblclientenif.Text = nif[0].ToString();

                string[] text = lstboxclientes.SelectedItem.ToString().Split('-');
                lblcliente.Text = text[0].ToString();
                lblclientenif.Text = text[1].ToString();


            }
                //lblcliente.Text = lstboxclientes.SelectedItem.ToString();

               
            }

        private void btnAdicionarLinha_Click(object sender, EventArgs e)
        {
           
            if (this.txtboxDescricao.Text != "" && this.txtboxDescricao.Text != "")
            {
                lstboxLinhaCompras.Items.Add(this.txtboxDescricao.Text + ' ' + this.txtboxValor.Text + '€' );
              //  lblMontanteLinhaCompras.Text = txtboxValor.Text.ToString() + txtboxValor.Text.ToString();
               // lblMontanteLinhaCompras.Text = (Convert.ToInt32(txtboxValor.Text) + Convert.ToInt32(txtboxValor.Text).ToString());
                //lblMontanteLinhaCompras.Text = Convert.ToInt32(txtboxValor.Text) + Convert.ToInt32(txtboxValor.Text)).ToString();
                this.txtboxDescricao.Focus();
                this.txtboxValor.Focus();
                this.txtboxDescricao.Clear();
                this.txtboxValor.Clear();



            }





            /* foreach (object str in lstboxLinhaCompras.Items)
             {

                 lblValorAdicionarLinhaCompra.Text = (str as string).Replace("£", string.Empty);
                 lblValorAdicionarLinhaCompra.Text = lblValorAdicionarLinhaCompra.Text.Replace("\r\n", string.Empty);
                 lblValorAdicionarLinhaCompra.Text += Convert.ToInt32(lblValorAdicionarLinhaCompra);
             }*/

        }

        private void btnApagarLinhaCompras_Click(object sender, EventArgs e)
        {

            for (int i = lstboxLinhaCompras.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstboxLinhaCompras.Items.RemoveAt(lstboxLinhaCompras.SelectedIndices[i]);

                //Linhacompra l = new Linhacompra(string descricao, double valor);
            }
            
        }

        private void lstboxLinhaCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] text = lstboxclientes.SelectedItem.ToString().Split(' ');
            //lblMontanteLinhaCompras.Text = text[0].ToString();
            //lblMontanteLinhaCompras.Text = text[1].ToString();




            //Linhacompra.valor = lstboxclientes.SelectedItem.ToString().Split(' ')[0];
            //pedido.preco = Convert.ToDouble(lstboxclientes.SelectedItem.ToString().Split(' ')[1]);
            //lstboxLinhaCompras.Items.Add("Preço: " + pedido.preco);
            //totalfinal += "Item Pedido: " + pedido.preco + "\nPreço: " + pedido.preco.ToString(" ") + "\n";





            //atualizarpedido();
        }

        private void getpreco(string clientePedido)
        {
            pedido.item = clientePedido.Split(' ')[0];
            pedido.preco = Convert.ToDouble(clientePedido.Split(' ')[1]);
            lstboxLinhaCompras.Items.Add(pedido.preco);
           // totalfinal += "Item Pedido: " + pedido.preco + "\nPreço: " + pedido.preco.ToString("C2") + "\n";
        }

        private void atualizarpedido()
        {
            subtotal += pedido.preco;
            total += pedido.preco + (pedido.preco * TAX);
            totaltax += pedido.preco * TAX;

            lstboxLinhaCompras.Items.Clear();
            lstboxLinhaCompras.Items.Add(total);

            lblMontanteLinhaCompras.Text = total.ToString();
           // lstboxLinhaCompras.Items.Add("Subtotal: " + subtotal.ToString("C2"));
           // lstboxLinhaCompras.Items.Add("Tax: " + totaltax.ToString("C2"));
           //lstboxLinhaCompras.Items.Add("Total: " + total.ToString("C2"));
        }

        private void txtboxValor_TextChanged(object sender, EventArgs e)
        {

         /*   decimal sum = 0;

            for (int i = 0; i < lstboxLinhaCompras.Items.Count; i++)
            {
                sum += Convert.ToDecimal(lstboxLinhaCompras.Items[i].ToString());
            }

            lblMontanteLinhaCompras.Text = Convert.ToString(sum);
          */
        }
    }
}
