using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class _05_DelegateComoParametro {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string Calculadora(Operacao op, int a, int b) {
            var resultado = op(a, b);
            return "resultado: " + resultado;
        }

        public static void Executar() {
            Operacao subtracao = (int x, int y) => {
                return x - y;
            };

            Console.WriteLine(Calculadora(subtracao, 20, 5));
            Console.WriteLine(Calculadora(Soma, 20,5));
        }
    }
}
