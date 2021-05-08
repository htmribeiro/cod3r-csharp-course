using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            // modificando o valor da variável
            raio = 5.5;
            //PI = 3.1415; -> mostra que não é possível alterar uma constante

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área da da circunferência é: " + area);

            // Tipo internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            //byte idade = 41;
            byte idade = byte.MaxValue;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValor = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor Int " + menorValor);

            uint populacaoBrasileira = 207_600_000; // podemos usar o "_" como separador universal
            Console.WriteLine("População 'fake' brasileira é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
