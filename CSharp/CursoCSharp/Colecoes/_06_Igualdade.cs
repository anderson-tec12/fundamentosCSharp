using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class _06_Igualdade {

        

        public static void Executar() {
            var p1 = new Produto("A", 1.89);
            var p2= new Produto("A", 1.89);
            var p3 = p2;

            //false não sao igual pq esta sendo comparado a referencia da memoria e nao os valores
            Console.WriteLine(p1 == p2);

            Console.WriteLine(p2 == p3);//true

            //ainda false pis  equals faz a comparação de referenca de memoria
            //deu true pq na class de produto fizemos um override de equals arquivo _02_List
            Console.WriteLine(p1.Equals(p2));


         
        }
    }
}
