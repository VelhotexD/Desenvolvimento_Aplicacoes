using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFicha2
{
    public partial class Form1 : Form
    {
        private DateTime contadorTempo;

        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 10));
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) { 
                

                timer1.Stop();
                button1.Text = "Start";
            }
            else
            {
                
                
                timer1.Enabled = false;
                timer1.Start();
                button1.Text = "Stop";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(toolStripStatusLabelHora.Text+"@"+toolStripStatusLabelContador.Text);
        }

    }
}
