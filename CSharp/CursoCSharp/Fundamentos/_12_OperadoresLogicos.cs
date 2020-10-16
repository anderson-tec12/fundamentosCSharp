using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _12_OperadoresLogicos {
        public static void Executar() {
            var executouTrablhoUm = true;
            var executouTrablhoDois = false;

            var comproTV50 = executouTrablhoUm && executouTrablhoDois;
            var comproSorvete = executouTrablhoUm || executouTrablhoDois;
            var comproTV32 = executouTrablhoUm ^ executouTrablhoDois; // ^ ou exclusivo

            Console.WriteLine("Comprou tv 50 {0}", comproTV50);
            Console.WriteLine("Comprou sorvete {0}", comproSorvete);
            Console.WriteLine("Comprou tv 32 {0}", comproTV32);
            Console.WriteLine("Mais saudavel{0}", !comproSorvete);
        }
    }
}
