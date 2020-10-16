using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        public static int Soma(int a, int b) {
            return a + b ;
        }

        public static int Multiplicar(int a, int b) {
            return a * b ;
        }
    }

    class _04_MetodosEstaticos {
        public static void Executar() {
            Console.WriteLine(CalculadoraEstatica.Soma(5, 5));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(5, 5));
        }
    }
}
