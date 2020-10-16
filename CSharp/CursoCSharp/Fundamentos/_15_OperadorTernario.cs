using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _15_OperadorTernario {
        public static void Executar() {
            var nota = 7.0;

            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
