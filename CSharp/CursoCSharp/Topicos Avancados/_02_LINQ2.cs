using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.Topicos_Avancados {
    class _02_LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){Nome= "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno(){Nome= "Andre", Idade = 21, Nota = 4.3 },
                new Aluno(){Nome= "Ana", Idade = 25, Nota = 9.5 },
                new Aluno(){Nome= "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno(){Nome= "Ana", Idade = 21, Nota = 7.7 },
                new Aluno(){Nome= "Julia", Idade = 22, Nota = 7.5 },
                new Aluno(){Nome= "Marcio", Idade = 18, Nota = 6.8 },
            };

            //single se nao achar gera erro, procure usar singleOrDefault
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine("{0} {1}", pedro.Nome, pedro.Nota);

            //retorna a primeir ana
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine("{0} {1}", ana.Nome, ana.Nota);

            Console.WriteLine("=================");
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var aluno in exemploSkip) {
                Console.WriteLine(aluno.Nome);
            }

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
