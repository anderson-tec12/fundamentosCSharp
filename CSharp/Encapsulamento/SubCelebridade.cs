using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        //todos
        public string InfoPublica = "Tenho um Instgrem";

        //herença
        protected string CorDosOlhos = "Verde";

        //mesmo projet (assemply)
        internal ulong NumeoCelular = 5511999998888;

        //herança ou n mesmo projeto
        protected internal string JeitoDeFalar = "Muitas girias";

        //mesma Class ou herança no mesmo projeto (C# >= 7.2)
        //private protected string SegredoFimalia = "Bla bla";

        //private é o padrao 
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade......");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeoCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
