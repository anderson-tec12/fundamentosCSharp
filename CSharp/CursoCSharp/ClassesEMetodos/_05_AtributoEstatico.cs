using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto;

        //Criando o constructor
        public Produto(string nome, double preco, double desconto) {
            Desconto = desconto;
            Preco = preco;
            Nome = nome;
        }

        public Produto() {
            
        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }

    }

    class _05_AtributoEstatico {
        public static void Executar() {
            var produto1 = new Produto("caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                //Desconto = 0.5,
                Preco = 5.3,
                Nome = "Borracha"
            };

            Produto.Desconto = 0.9;

            Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());
        }
    }
}
