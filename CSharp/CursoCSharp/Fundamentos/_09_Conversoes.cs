using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _09_Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);

            /*
             * não é possivel converter um double diretamente para um int 
             * "chamamos isso de converção implicita"
            double nota = 9.7;
            int notaInt = nota;
            */

            //Convertento explicitamente um double para int
            double nota = 9.7;
            //essa converção ignora as casas decimais
            //(int) => isso se chama castin
            int notaTruncada = (int)nota; 

            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            //Outra maneira de converte
            Console.WriteLine("Digite sua idade novamente");
            string idade2String = Console.ReadLine();
            int novaConvercao = Convert.ToInt32(idade2String);

            Console.WriteLine("Nova converção " + novaConvercao);

            //tentando converte se possivel uma string em um numero
            Console.WriteLine("Digite mais um numero");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // variavel que tem a sctring e a variavel que vai receber a converção

            Console.WriteLine(numero);

            //outra maneira
            Console.WriteLine("Informe mais um numero");
            int.TryParse(Console.ReadLine(), out int numeroDois);
            Console.WriteLine(numeroDois);
            Console.WriteLine(numeroDois);
        }
    }
}
