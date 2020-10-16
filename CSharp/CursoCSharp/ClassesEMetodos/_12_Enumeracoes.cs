using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};
    public class Filme {
        public string filme;
        public Genero GeneroDoFilme;
    }

    class _12_Enumeracoes {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.filme = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine("{0} É {1}", filmeParaFamilia.filme, filmeParaFamilia.GeneroDoFilme);

        }
    }
}
