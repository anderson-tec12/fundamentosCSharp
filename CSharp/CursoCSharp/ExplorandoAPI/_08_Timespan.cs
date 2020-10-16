using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ExplorandoAPI {
    class _08_Timespan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes); 
            Console.WriteLine("Minutos: " + intervalo.TotalMinutes); //converte toda a data para minutos
            Console.WriteLine("Minutos: " + intervalo.TotalMilliseconds); //converte toda a data para minutos
        }
    }
}
