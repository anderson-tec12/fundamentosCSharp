using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _10_CONTINUE {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("numero pares entre 1 e {0}", intervalo);

            for (var i = 1; i <= intervalo; i++) {
                if(i % 2 == 1) {
                    //chama a proxima interação do i
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}
