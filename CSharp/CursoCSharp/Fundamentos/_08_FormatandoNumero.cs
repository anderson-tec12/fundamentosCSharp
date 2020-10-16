using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos {
    class _08_FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 1 casa decimal ele vai arredondar pois existem mais de 1
            Console.WriteLine(valor.ToString("C")); //valor monetario RS
            Console.WriteLine(valor.ToString("P")); //percentual
            Console.WriteLine(valor.ToString("#.##")); //2 casas decimais

            //defindindo a cultura monetaria e simbolos

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura)); //C = dinheiro 0 = casa decimal cultura é a região 

            //adicionando 0 a esquerdas
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
