using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class _06_NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " world!").Replace("world", "Mundo");

            Console.WriteLine(saudacao);

            string valorImportante = null;

            Console.WriteLine(valorImportante);

        }
    }
}
