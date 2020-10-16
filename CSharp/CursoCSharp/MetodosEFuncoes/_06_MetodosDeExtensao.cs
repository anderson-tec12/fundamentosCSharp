using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiros {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static int Subtracao     (this int num, int outroNumero) {
            return num - outroNumero;
        }
    }

    class _06_MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(5));
            Console.WriteLine(numero.Subtracao(3));
        }
    }
}
