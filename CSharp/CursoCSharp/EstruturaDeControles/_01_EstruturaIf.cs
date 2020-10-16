using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _01_EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;            
            Console.WriteLine("Digite uma nota");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamento (S/N)");
            entrada = Console.ReadLine();
            if(entrada == "S" || entrada == "s") {
                bomComportamento = true;
            }

            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra");
            }
        }
    }
}
