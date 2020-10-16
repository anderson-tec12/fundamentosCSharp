using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _13_OperadoresDeAtribuicao {
        public static void Executar() {
            var num1= 3;
            //atribuição aditiva
            num1 += 10;
            //atribuição subtrativa
            num1 -= 3;
            //atribuição multiplicativa
            num1 *= 5;
            //atribuição divisiva
            num1 /= 2;

            num1++; //operador unario incremento 
            num1--; //operador unario decremento 

            Console.WriteLine(num1);
        }
    }
}
