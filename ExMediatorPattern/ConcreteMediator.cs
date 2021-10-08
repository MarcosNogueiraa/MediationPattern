using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ExMediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        Form1 form1;
        Form2 form2;
        Form3 form3;

        public void TrocaTela(int novoForm)
        { 

            if (novoForm == 1)
            {
                form1 = new Form1();
                form1.ShowDialog();

            }else if(novoForm == 2)
            {
                form2 = new Form2();
                form2.ShowDialog();

            }else if(novoForm == 3)
            {
                form3 = new Form3();
                form3.ShowDialog();
            }
        }


    }
}
