using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto{
        public string Nome;
        public double Preco;
        
        public Produto(string nome, double preco ) {
            Nome = nome;
            Preco = preco;
        }

        // sobre escrita do metodo equal que esta sendo usado na aula de igualdade
        public override bool Equals(object obj) {
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;
        }

        //sobre escrita do metodo GetHashCode usado em _04_Set
        public override int GetHashCode() {
            return Nome.Length;
        }
    }

    class _02_List {
        public static void Executar() {
            var livro = new Produto("Game Of Thrones", 49.9);

            var carrinho = new List<Produto>();
           //adiciona um item a lista
            carrinho.Add(livro);

            var combo = new List<Produto>{
                new Produto("camiseta", 29.9),
                new Produto("9 temporada baby shark", 89.9),
                new Produto("poster", 11.5)
            };

            //adiciona um range a lista
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);//remove da lista o item de indice 3

            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine(" {0} {1} ", item.Nome, item.Preco);
            }
        }
    }
}
