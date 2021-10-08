using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExMediatorPattern
{
    public partial class Form1 : Form
    {
        ConcreteMediator concreteMediator = new ConcreteMediator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btTeste_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button bt = (Button) sender;
            concreteMediator.TrocaTela(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            concreteMediator.TrocaTela(3);
        }
    }
}
