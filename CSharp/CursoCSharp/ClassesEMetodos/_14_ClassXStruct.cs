using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int Y;
        public int X;
    }

    public class CPonto {
        public int Y;
        public int X;
    }

    class _14_ClassXStruct {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //atribuição por valor
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X {0}", ponto1.X);
            Console.WriteLine("Copia do Ponto 1 X {0}", copiaPonto1.X);

            //AGORA COM CLASS
            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaPonto2 = ponto2; //atribuição por referencia se altera o valor troca o da copia
            ponto1.X = 3;

            Console.WriteLine("Ponto 2 X {0}", ponto2.X);
            Console.WriteLine("Copia do Ponto 2 X {0}", copiaPonto2.X);
        }
    }
}
