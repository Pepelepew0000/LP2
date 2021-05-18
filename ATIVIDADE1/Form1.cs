using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULARAIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtb1.Clear();
            txtb2.Clear();
            lbl1.Text = "RESULTADO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2;

             num1 = float.Parse(txtb1.Text);
             num2 = float.Parse(txtb2.Text);

            if (rdbsoma.Checked)
            {
                num1 = num1 + num2;
                lbl1.Text  = num1.ToString();
                
            }else if (rdbdiv.Checked)
            {
                num1 = num1 / num2;
                lbl1.Text = num1.ToString();
            }
            else if(rdbmull.Checked) {
                num1 = num1 * num2;
                lbl1.Text = num1.ToString();
            }
            else if (rdbsub.Checked)
            {
                num1 = num1 - num2;
                lbl1.Text = num1.ToString();
            }





        }

 
    }
}
