using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            CultureInfo culturaBr = new CultureInfo("pt-BR");
            Console.WriteLine($"O total do Preço + Imposto é de {total.ToString("C", culturaBr)}");
            Console.WriteLine($"Com o Desconto de {desconto.ToString("P0")}");
            Console.WriteLine("O preço final é {0}", totalComDesconto.ToString("C", culturaBr));

            // IMC
            double peso = 93.3;
            double altura = 1.88;
            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"O seu IMC é {imc.ToString("F1")}.");

            // Número Par/Impar
            int par = 24;
            int impar = 55;

            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
