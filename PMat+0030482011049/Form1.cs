using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMat_0030482011049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EXE_Click(object sender, EventArgs e)
        {
            float[] A = new float[10];
            float[] B = new float[10];
            int I=0;
            string message= "INSIRA UM VALOR NUMERICO ATÉ O FIM DAS MSGS";
            string title = "Entrada de valores";
            string D;
            object myvalue;

            



            for (I = 0; I < 10; I++)
            {
                myvalue = Interaction.InputBox(title, message);
                D = myvalue.ToString();
                MessageBox.Show(D);
                A[I] = float.Parse(D);
            }

            I = 0;
            

            while( I<10 )
            {
                D =("Vetor A " + A[I].ToString("0.##"));
                LBox.Items.Add(D);
                if (I % 2 == 0)
                {
                    B[I] = A[I] * 5;
                }
                else
                {
                    B[I] = A[I] + 5;
                }
                D = ("Vetor B "+ B[I].ToString("0.##"));
                LBox.Items.Add(D);
                I++;
            }


        }
    }
}
