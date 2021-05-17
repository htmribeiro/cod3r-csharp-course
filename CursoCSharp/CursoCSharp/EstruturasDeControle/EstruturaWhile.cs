using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 3;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                var corAnterior = Console.BackgroundColor;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    //var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativa(s)", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor...Tente novamente!");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                    Console.BackgroundColor = corAnterior;
                } else {
                    Console.WriteLine("Maior...Tente novamente!");
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                    Console.BackgroundColor = corAnterior;
                }
            }
        }
    }
}
