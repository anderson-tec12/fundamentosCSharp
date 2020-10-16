using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class _07_ParametrosVariaveis {

        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Ola {0}", pessoa);
            }
        }
        public static void Executar() {
            Recepcionar("Anderson", "Mivane", "Raphael", "Davi", "Gabriel");
        }
    }
}
