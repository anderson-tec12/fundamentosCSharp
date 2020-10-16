using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _10_OperadoresAritimeticos {
        public static void Executar() {
            //preco com desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine(totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            //double imc = peso / (altura * altura);
            //usando elevação a potencia
            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine(imc);

            //numero par/impar
            int par = 40;
            int impar = 51;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
