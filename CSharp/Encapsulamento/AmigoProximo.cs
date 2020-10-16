using System;
using System.Collections.Generic;
using System.Text;


namespace Encapsulamento {
    public class AmigoProximo {
        //ConsoleModifiers nao herda precisamos instanciar para acessar os atributos
        //chamdo de composição
        public readonly SubCelebridade amiga = new SubCelebridade();
        

        public void MeusAcessos() {
            Console.WriteLine("Amiga da familha....");
            Console.WriteLine(amiga.InfoPublica);
            Console.WriteLine(amiga.JeitoDeFalar);
            Console.WriteLine(amiga.NumeoCelular);
        }

    }
}
