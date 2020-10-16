using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _09_BREAK {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("o numero que queremos é {0} ", numero);

            for(int i = 1; i <= numero; i++) {
                Console.Write("{0} é o numero que queremos : ", i);
                if(numero == i) {
                    Console.WriteLine("SIM!!");
                    break;
                } else {
                    Console.WriteLine("NÂO");
                }
            }
        }
    }
}
