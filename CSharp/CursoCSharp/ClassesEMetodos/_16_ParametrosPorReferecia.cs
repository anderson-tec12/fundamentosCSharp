using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class _16_ParametrosPorReferecia {

        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            int b = 3;
            AlterarOut(out b);
            Console.WriteLine(b);
        }
    }
}
