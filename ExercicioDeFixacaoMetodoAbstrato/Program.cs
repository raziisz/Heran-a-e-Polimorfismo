using ExercicioDeFixacaoMetodoAbstrato.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoMetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuintes> listContr = new List<Contribuintes>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Pagador de taxa #{i}: ");
                Console.Write("Pessoa Física ou Jurídica(f/j)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'f' || type == 'F')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listContr.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                } else if(type =='j' || type == 'J')
                {
                    Console.Write("Número de funcionarios: ");
                    int numFuncionario = int.Parse(Console.ReadLine());

                    listContr.Add(new PessoaJuridica(nome, rendaAnual, numFuncionario));
                }
                else
                {
                    i--;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Taxas a pagar");
            double soma = 0.0;
            foreach (Contribuintes contribuintes in listContr)
            {
                Console.WriteLine(contribuintes.Nome+": $ "
                    +contribuintes.Imposto().ToString("F2",CultureInfo.InvariantCulture));
                soma += contribuintes.Imposto();
            }

            Console.WriteLine();
            Console.WriteLine("Total de taxas pagas: $ "+soma);


        }
    }
}
