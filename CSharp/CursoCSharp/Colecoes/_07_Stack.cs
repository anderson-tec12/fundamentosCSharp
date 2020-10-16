using System;
//removendo o genreci
//using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class _07_Stack {
        public static void Executar() {
            //um stack é parecido com a fila porem o primeiro a entrar é o ultimo a sair
            var pilha = new Stack();

            //adicionando 
            pilha.Push(3);
            pilha.Push("String");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var i in pilha) {
                Console.WriteLine(i);
            }

            //remove o ultimo elemento  add 
            Console.WriteLine("Pop: {0}", pilha.Pop());
            Console.WriteLine("  ");

            foreach (var i in pilha) {
                Console.WriteLine(i);
            }

            //peek pega o proximo mas nao o remove da lista
            Console.WriteLine("Peek: {0}", pilha.Peek());
            Console.WriteLine("  ");
        }
    }
}
