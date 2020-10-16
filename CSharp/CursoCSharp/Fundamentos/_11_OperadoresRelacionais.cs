using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _11_OperadoresRelacionais {
        public static void Executar() {
            double nota = 6.0;
            double notaDecorte = 7.0;

            Console.WriteLine("Nota invalida {0}", nota > 10.0);
            Console.WriteLine("Nota invalida {0}", nota < 0.0);
            Console.WriteLine("Nota  perfeita {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar {0}", nota != 10.0);
            Console.WriteLine("Passou por media {0}", nota >= notaDecorte);
            Console.WriteLine("Recuperação {0} ", nota < notaDecorte);
            Console.WriteLine("Reprovado {0} ", nota <= 3.0);
        }
    }
}
