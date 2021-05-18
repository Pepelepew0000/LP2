using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    abstract class Empregado
    {
        //atributos
        private int AT_Matricula;
        private string AT_Nome;
        private DateTime AT_Data_entrada;

        public int Matricula
        {
            get { return AT_Matricula; }
            set { AT_Matricula = value; }
        }

        public string Nome
        {
            get { return AT_Nome; }
            set { AT_Nome = value; }
        }

        public DateTime Data_entrada
        {
            get { return AT_Data_entrada; }
            set { AT_Data_entrada = value; }
        }

        // Virtual antes do metodo permite ser sobreescrito
        //polimorfismo???

        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(AT_Data_entrada);
            return (span.Days);

        }

        public abstract double SalarioBruto();



    }
}
