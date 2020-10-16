using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _07_FOR {
        public static void Executar() {
            for(int i = 0; i <=10; i++) {
                Console.WriteLine(i);
            }

            double somatorio = 0;
            string entrada;
            Console.WriteLine("informe o tamnho da turma");
            entrada = Console.ReadLine();

            int.TryParse(entrada, out int tamanhoTurma);

            for (int a = 1 ; a <= tamanhoTurma; a++){
                Console.Write("Informe a nota do aluno {0}: ", a);

                Double.TryParse(Console.ReadLine(), out double notaAtual);

                somatorio += notaAtual;
            }

            Console.WriteLine("Notas somadas {0}", somatorio);

        }
    }
}
