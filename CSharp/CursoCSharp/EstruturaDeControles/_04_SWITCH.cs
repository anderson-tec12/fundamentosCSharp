using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControles {
    class _04_SWITCH {
        public static void Executar() {
            Console.WriteLine("Avalie meu atendimento de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota) {
                case 0:
                    Console.WriteLine("pessimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("RUIM");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Execelente");
                    break;
                default:
                    Console.WriteLine("nota invalida");
                    break;
                
            }

            Console.WriteLine("FIM !!");
        }
    }
}
