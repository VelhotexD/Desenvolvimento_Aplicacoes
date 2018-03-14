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
        public List<Cliente> lcliente = null;

        public Form1()
        {
            InitializeComponent();
            lcliente = new List<Cliente>();

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
