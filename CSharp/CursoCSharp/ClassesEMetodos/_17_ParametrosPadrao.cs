using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class _17_ParametrosPadrao {
        public static int Somar(int a = 1, int b =1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10));
        }
    }
}
