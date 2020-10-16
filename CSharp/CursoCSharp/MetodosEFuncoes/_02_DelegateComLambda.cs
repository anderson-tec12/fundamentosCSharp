using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    //double é o tipo de retorno Operacao é o nome do delegate
    //Operacao agora é um tipo , podemos cria um variavel e falar que ela é do tipo  Operacao
    delegate double Operacao(double x, double y);

    class _02_DelegateComLambda {

        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mul = (x, y) => x * y;

            Console.WriteLine(sum(2,5));
            Console.WriteLine(sub(2,5));
            Console.WriteLine(mul(2,5));
        }
    }
}
