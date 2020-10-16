using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _05_WHILE {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16); //entre 1 e 16
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas = 0;

            while(tentativaRestante > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;

                if(palpite == numeroSecreto) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} temtativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }else if(palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente");
                    Console.WriteLine("tentativas restantes {0}", tentativaRestante);
                } else {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("tentativas restantes {0}", tentativaRestante);
                }
            }
        }
    }
}
