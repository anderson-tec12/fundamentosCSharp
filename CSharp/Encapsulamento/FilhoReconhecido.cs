using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class FilhoReconhecido: SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho reconhecido .......");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeoCelular);
            Console.WriteLine(JeitoDeFalar);
            
        }
    }
}
