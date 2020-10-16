using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _14_OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!boleano);
            numero1++;

            Console.WriteLine(numero1);
            --numero1;
            Console.WriteLine(numero1);

            // neste caso  o numero 1 so vai ser incrementado apos a comparação
            //ja o numero 2 vai ser decrementado antes da comparação
            Console.WriteLine(numero1++ == --numero2);
               
        }
    }
}
