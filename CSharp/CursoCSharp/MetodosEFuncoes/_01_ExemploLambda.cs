using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class _01_ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("LAMBDA COM C#");
            };

            algoNoConsole();

            //int é o tipo de retorno 
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //padando parmetros pra Func
            //int é o tipo de parametro
            //string é p tipo do return
            Func<int, string> conversorHex = (numero) => {
                return numero.ToString("x");
            };

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => {
               return  String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            };

            Console.WriteLine(formatarData(26,10,2019));
        }
    }
}
