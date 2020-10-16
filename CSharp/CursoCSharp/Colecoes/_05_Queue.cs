using System;
using System.Collections; //o queue daqui nao usa generic
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class _05_Queue {
        public static void Executar() {
            //criando uma fila que todo os valores são do tipo string
            var fila = new Queue<string>();

            //Enfileirando;
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Deltrano");

            //exibe o proximo a sair da fila ou seja o primeiro
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            //removendo o primeiro da fila
            fila.Dequeue();
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            //criando uma fila sem o Generic
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(4.5);

            Console.WriteLine(salada.Contains("Item")); // cuidado pde ser false pois é case sensitive
        }
    }
}
