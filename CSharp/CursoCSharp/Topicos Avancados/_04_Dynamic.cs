using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Topicos_Avancados {
    class _04_Dynamic {
        public static void Executar() {
            //tipo dinamico lembra as linguagens fracamnte tipada mas cuidado pode gerar problemas
            dynamic meuOjeto = "teste";
            meuOjeto = 1;
            Console.WriteLine(meuOjeto);
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria julia";
            aluno.nota = 8;
        }
        
    }
}
