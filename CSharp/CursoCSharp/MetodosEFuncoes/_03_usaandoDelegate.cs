using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    

    class _03_usaandoDelegate {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine( a + b);
        } 

        public static void Executar() {
            //associar funcoes pre criadas ao delegate

            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(5.6, 5.4));
            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.6, 5.4);
        }    
    }
}
