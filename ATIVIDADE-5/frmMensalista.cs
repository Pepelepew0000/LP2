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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //instanciar
            Mensalista Objmensalista = new Mensalista();

            //set
            Objmensalista.Matricula = Convert.ToInt32(txtmatricula.Text);
            Objmensalista.Nome = txtnome.Text;
            Objmensalista.Data_entrada = Convert.ToDateTime(txtdata.Text);
            Objmensalista.Salario_Mensal = Convert.ToDouble(txtsal);

            //get
            MessageBox.Show("matricula:" + Objmensalista.Matricula +
                            "nome :" + Objmensalista.Nome +
                            "Data de entrada na empresa:" + Objmensalista.Data_entrada.ToShortDateString() +
                            "Salario Bruto: " + Objmensalista.SalarioBruto().ToString("N2"));

        }
    }
}
