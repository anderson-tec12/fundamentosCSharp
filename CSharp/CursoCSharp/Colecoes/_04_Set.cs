using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    
    class _04_Set {
        public static void Executar() {
            var livro = new Produto("Game Of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            //adiciona um item a lista
            carrinho.Add(livro);

            var combo = new HashSet<Produto>{
                new Produto("camiseta", 29.9),
                new Produto("9 temporada baby shark", 89.9),
                new Produto("poster", 11.5),
                new Produto("poster", 11.5) // nao vai adicionar por causa do metodo criado na class produto um override de GetHashCode
            };

            //adiciona um range a lista
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);//remove da lista o item de indice 3
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho) {
               // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine(" {0} {1} ", item.Nome, item.Preco);
            }
        }
    }
}
