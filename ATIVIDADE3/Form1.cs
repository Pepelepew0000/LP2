using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERIFICADORDETRIANGULOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lA, lB, lC;

            lA = double.Parse(L1.Text);
            lB = double.Parse(L2.Text);
            lC = double.Parse(L3.Text);

            if(Math.Abs(lA - lB) < lC && lC < lA + lB)
            {
                if (Math.Abs(lA - lC) < lB && lB < lA + lC)
                {
                   if (Math.Abs(lB - lC) < lA && lA < lB + lC)
                    {
                        if (lC == lB && lA == lB)
                        {
                            MessageBox.Show("É um triângulo equilatero e também isóceles");
                        }else if (lA!=lB&& lB!=lC&& lC != lA)
                        {
                            MessageBox.Show("É um triângulo escaleno");
                        }
                        else
                        {
                            MessageBox.Show("É um triângulo isóceles");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Corra! Não é um triângulo!");
                    }

                }
                else
                {
                    MessageBox.Show("Corra! Não é um triângulo!");
                }

            }
            else
            {
                MessageBox.Show("Corra! Não é um triângulo!");
            }
                      
        }
    }
}
