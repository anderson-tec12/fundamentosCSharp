using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class _01_Arrays {
        public static void Executar() {
            //array é do tipo homogeinio ou seja so valem um tipo de dados 
            // array nao cresce dinamicamente
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Mivane";
            alunos[2] = "Raphael";
            alunos[3] = "Davi";
            alunos[4] = "gabriel";
           
            foreach(var nome in alunos) {
                Console.WriteLine(nome);
            }

            double somatorio = 0;
            double[] notas = {
                5,7,10,1,4
            };

            foreach(var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("nota atigindo da turma {0} media da class {1}",somatorio,media);

            char[] letras = { 'A', 'R', 'R','A','Y' };
            string palavras = new string(letras);
            Console.WriteLine(palavras);
        }
    }
}
