using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEnumExercise.Entities.Enum;

namespace NewEnumExercise.Entities
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public NivelFuncionario Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoDeHora> Contratos { get; set; } = new List<ContratoDeHora>();

        public Funcionario()
        {

        }

        public Funcionario(string name, NivelFuncionario nivel, double salarioBase, Departamento departamento)
        {
            Nome = name;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContratos(ContratoDeHora contrato)
        {
            Contratos.Add(contrato);
        }

        public double Ganhos(int year, int month)
        {
            double soma = SalarioBase;
            foreach (ContratoDeHora contrato in Contratos)
            {
                if (contrato.Data.Year == year && contrato.Data.Month == month)
                {
                    soma += contrato.TotalValue();
                }
            }
            return soma;
        }
    }
}
