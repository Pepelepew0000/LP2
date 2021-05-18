using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    abstract class Mensalista : Empregado
    {
        public double AT_Salario_Mensal;

        public double Salario_Mensal
        {
         //tbm pode ser feito como public *tipo* *nome_do_metodo* {get; set;}
            get { return AT_Salario_Mensal; }
            set { AT_Salario_Mensal = value; }
        }

        public override double SalarioBruto()
        {
            return Salario_Mensal;
        }





    }
}
