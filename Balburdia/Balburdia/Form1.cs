using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balburdia
{
    public partial class Form1 : Form
    {
        Coisa newcoisa = null;
        List<Coisa> lcoisa = null;

        public Form1()
        {
            InitializeComponent();
            lcoisa = new List<Coisa>();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            Coisa newcoisa = new Coisa(txbNome.Text);
            lbNome.Items.Add(newcoisa.ToString());  
        }
        
        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            lcoisa = new List<Coisa>();
            for (int i = 0; i < lbNome.Items.Count; i++)
            {

                Coisa nome = new Coisa(lbNome.Items[i].ToString());
                lcoisa.Add(nome);
                
            }
            atualizar_lista();

        }

        public void atualizar_lista()
        {

            lbBalburdia.DataSource = null;
            lbBalburdia.DataSource = lcoisa;
            

        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lcoisa.Count; i++)
            {
                lcoisa[i].InventarValor();
            }

        }
    }
}
