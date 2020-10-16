using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class _01_MEMBROS {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Anderson Barros silva";
            sicrano.Idade = 27;

            Console.WriteLine("Sicrano nome: {0} de {1} anos", sicrano.Nome, sicrano.Idade);

            sicrano.ApresentarNoConsole();
            sicrano.Apresentar();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();

            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
