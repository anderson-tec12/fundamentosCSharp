using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _06_DOWHILE {
        public static void Executar() {
            string entrada;

            //do sempre é executado pelo menos 1x
            do {
                Console.WriteLine("Qual o seu nome ?");
                entrada = Console.ReadLine();
                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("Deseja continuar (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
