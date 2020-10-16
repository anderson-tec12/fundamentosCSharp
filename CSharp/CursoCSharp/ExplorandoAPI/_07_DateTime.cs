using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ExplorandoAPI {
    class _07_DateTime {
        public static void Executar() {

            //opcionais palvras year month day, se passar com as palavras especiais nao tem ordem
            var dateTime = new DateTime(year:2019, month: 10, day: 26); // ano / mes / dia

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);
            
            var hoje = new DateTime(year: 2019, month: 10, day: 26);
            Console.WriteLine(hoje.ToLongDateString());

            Console.WriteLine(new DateTime().ToShortDateString());
            Console.WriteLine(new DateTime().Date);


            //formatando a data
            Console.WriteLine(hoje.ToString("dd"));
            Console.WriteLine(hoje.ToString("dd-MM-yyyy"));
            Console.WriteLine(hoje.ToString("d"));
            Console.WriteLine(hoje.ToString("D"));
            Console.WriteLine(hoje.ToString("g"));
            Console.WriteLine(hoje.ToString("G"));
        }
    }
}
