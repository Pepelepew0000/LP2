using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Horista Objhorista = new Horista();


            Objhorista.Nome = txtnome.Text;
            Objhorista.Matricula = Convert.ToInt32(txtmat.Text);
            Objhorista.SalarioHora = Convert.ToDouble(txtsal.Text);
            Objhorista.Num_Hora = Convert.ToDouble(txtHoras.Text);
            Objhorista.Data_entrada = Convert.ToDateTime(txtdataEntrada.Text);
            Objhorista.dias_falta = Convert.ToInt32(txtFaltas.Text);


            MessageBox.Show()

        }
    }
}
