using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double H,W,D;

            H = double.Parse(txtAltura.Text);
            W = double.Parse(txtPeso.Text);

         
            Math.Round(W, 3);



            if (rdb1.Checked == true)
            {


                D = (H * 72.7) - 58;
                Math.Round(D, 3);
                if (W > D)
                {
                    MessageBox.Show("Regime Obrigatório Ja");
                    

                } else if (W == D)
                {
                    MessageBox.Show("Você está com o peso ideal");
                }
                else if (W < D)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                    H = (float)(72.7 * H) - 58;
                    lblresult.Text = H.ToString();

                }

            }
            else if (rdb2.Checked == true)
            {
                D = (H * 62.1) - 44.7;
                Math.Round(D,3);

                if (W > D)
                {
                    MessageBox.Show("Regime Obrigatório Ja");

                }
                else if (W == D)
                {
                    MessageBox.Show("Você está com o peso ideal");
                }
                else if (W < D)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }
            }
        }
    }
}
