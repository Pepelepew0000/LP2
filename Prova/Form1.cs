using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soprogresso
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

      
   
            lbox.Items.Add(txtbox.ToString());
            txtbox.Text = string.Empty;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            float[,] M = new float[9, 4];
            int I,J,K=32;

            lbox.BeginUpdate();
            for ( I = 0; I < 9; I++ )
            {
                for (J = 0; J < 4; J++)
                {
                    M[I, J] = float.Parse(lbox.GetItemText(K));
                }
                K--;
            }
            lbox.EndUpdate();



        }
    }
}
