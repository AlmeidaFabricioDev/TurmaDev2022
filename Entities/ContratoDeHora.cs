using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEnumExercise.Entities
{
    internal class ContratoDeHora
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHora()
        {

        }

        public ContratoDeHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double TotalValue()
        {
            return ValorPorHora * Horas;
        }
    }
}
