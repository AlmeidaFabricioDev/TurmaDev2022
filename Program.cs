using NewEnumExercise.Entities;
using NewEnumExercise.Entities.Enum;
using System.Globalization;

namespace NewEnumExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();

            Console.WriteLine("ENTRE COM OS DADOS DO FUNCIONÁRIO:");
            Console.Write("Nome : ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Nivel do Funcionário (Junior/NivelMedio/Senior) : ");
            NivelFuncionario niveltrab = Enum.Parse<NivelFuncionario>(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Salário Base : ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(nomeDepartamento);
            Funcionario func = new Funcionario(nome, niveltrab, salario, departamento);

            Console.WriteLine();
            Console.Write("Quantos contratos serão associados a este funcionário : ");
            int numContratos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numContratos; i++)
            {
                Console.WriteLine();
                Console.Write("Digite os dados do #" + (i + 1) + " contrato: ");
                Console.WriteLine();
                Console.Write("Data (DD/MM/YYYY) <- Digite neste formato : ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Valor por hora : ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.Write("Horas trabalhadas : ");
                int horas = int.Parse(Console.ReadLine());

                ContratoDeHora contratoHora = new ContratoDeHora(data, valorPorHora, horas);
                func.AddContratos(contratoHora);
            }

            Console.WriteLine();
            Console.Write("Digite o mês e ano neste formato -> (MM/YYYY) para calcular os ganhos : ");
            string mesAno = Console.ReadLine();
            int mesReferencia = int.Parse(mesAno.Substring(0, 2));
            int anoReferencia = int.Parse(mesAno.Substring(3));
            Console.WriteLine();
            Console.Write("Nome : " + func.Nome);
            Console.WriteLine();
            Console.Write("Departamento : " + func.Departamento.Nome);
            Console.WriteLine();
            Console.Write("Income for " + mesAno + " : " + func.Ganhos(anoReferencia, mesReferencia));

        }
    }
}