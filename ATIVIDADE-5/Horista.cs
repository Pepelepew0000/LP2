using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    class Horista:Empregado
        // n existe herança multipla infelismente :(
    {
        public double SalarioHora { get; set; }

        public double Num_Hora { get; set; }

        public int dias_falta { get; set; }


        public override double SalarioBruto()
        {
            return (SalarioHora * Num_Hora);
        }

        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(Data_entrada);
            return (Convert.ToInt32(span.Days) - dias_falta);
        }

    }
}
