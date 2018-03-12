using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerepessoas
{
    
    public partial class Form1 : Form
    {
        Pessoa newpessoa = null;

        public Form1()
        {
            
            InitializeComponent();
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Pessoa newpessoa = new Pessoa();
            
            newpessoa = new Pessoa(textBox1.Text, monthCalendar1.SelectionRange.Start, textBox2.Text);

            listBox1.Items.Add(newpessoa.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            newpessoa.pontos();
            listBox1.Items.Add(newpessoa.ToString());

        }
    }
}
