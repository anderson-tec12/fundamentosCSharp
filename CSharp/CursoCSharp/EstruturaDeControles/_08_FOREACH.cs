using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _08_FOREACH {
        public static void Executar() {
            var palavra = "Opla!";

            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }

            var familia = new string[] {
                "Anderson",
                "Mivane",
                "Raphael",
                "Davi",
                "gabriel"
            };

            foreach(var integrante in familia) {
                Console.WriteLine(integrante);
            }
        }
    }
}
