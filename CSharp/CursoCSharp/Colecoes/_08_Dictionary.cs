using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class _08_Dictionary {
        public static void Executar() {
            //Dictionary pode repetir o valormas nao a chave
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "homem aranha");
            filmes.Add(2004, "Os incriveis");
            filmes.Add(2006, "O grande truque");

            if (filmes.ContainsKey(2006)) {
                Console.WriteLine("2004: "+filmes[2004] ); //da erro se nao existir a chave
                Console.WriteLine("2004: "+ filmes.GetValueOrDefault(2004)); //se nao tiver volta vazio
            }

            Console.WriteLine(filmes.ContainsValue("linux")); //retorna true ou false

            //removendo, se existir e conseguir remover retorna true se nao volta false
            Console.WriteLine($"Removel : {filmes.Remove(2004)}");

            //outra forma de pegar o valor 

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine(filme2006);

            foreach(var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }


            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine("nome do filme: {0} Ano: {1}",filme.Value, filme.Key);
            }

            foreach (var filme in filmes) {
                Console.WriteLine("nome do filme: {0} Ano: {1}", filme.Value, filme.Key);
            }
        }
    }
}
