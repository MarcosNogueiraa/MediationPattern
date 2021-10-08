using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExMediatorPattern
{
    public partial class Form3 : Form
    {
        ConcreteMediator concreteMediator = new ConcreteMediator();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            concreteMediator.TrocaTela(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            concreteMediator.TrocaTela(2);

        }
    }
}
