using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Dependente {
        public string Nome;
        public int Idade;
    }
    class _15_ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            numero++;
            Console.WriteLine("{0} {1}",numero , copiaNumero);

            Dependente dep = new Dependente() {
                Nome = "Beto",
                Idade = 20,
            };

            Dependente copiaDep = dep;
            Console.WriteLine("{0} {1}", dep.Nome, copiaDep.Nome);
            Console.WriteLine("{0} {1}", dep.Idade, copiaDep.Idade);

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine("{0} {1}", dep.Nome, copiaDep.Nome);
            Console.WriteLine("{0} {1}", dep.Idade, copiaDep.Idade);
        }
    }
}
